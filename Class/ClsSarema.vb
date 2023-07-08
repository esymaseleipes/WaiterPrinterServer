Imports WaiterModel.Cmp300

Public Class ClsSarema
    Public Property Porta As String
    Public WithEvents Tamiakh As AxCOECRCOMLib.AxCoEcrCom
    Public Event TamError(ErrorVal As String)
    Dim TamStaus As Boolean = False
    Public Event iDebug(DebugTxt As String)
    Dim CallerForm As Form
    Public Sub New()
        Tamiakh = New AxCOECRCOMLib.AxCoEcrCom()
        Tamiakh.CreateControl()
        Me.Tamiakh.Enabled = True
        Me.Tamiakh.Location = New System.Drawing.Point(1075, 81)
        Me.Tamiakh.Name = "Tamiakh"

    End Sub
    Private Function InitTam() As Boolean
        Dim TamOpenStatus As Integer = Tamiakh.Open("PORT = 1")
        If TamOpenStatus <> 0 Then CloseConnection()
        Dim Model As String = Tamiakh.EcrConfStr(2)
        Dim ris As Long
        If ris = 0 Then
            With Tamiakh
                .EventMask = "127"
                .OutEditOptions = "0"
                .EnableTradDC = False 'True
            End With
            Return True
        Else
            RaiseEvent TamError("Sarema Is Not Ready!!!")
            Return False
        End If
    End Function
    Public Function CloseConnection()
        Try
            Dim ris As Long = Tamiakh.Close()
        Catch ex As Exception
            Debug.Print("Error:Sarema->CloseConnection" & vbCrLf & ex.Message)
        End Try

    End Function
    Public Function RePrintOrder(Order As PosOrder) As Boolean
        Dim Status As Integer = Tamiakh.Status
        Dim cntr As Integer = 1
        RaiseEvent iDebug("PrintOrder" & Order.DocNum)
        For Each Tmplin As PosOrderLine In Order.PosOrderLines
            Application.DoEvents()
            If Tmplin.Price = 0 Then GoTo P1
            Do Until PrintLine(Tmplin) = 0
                Application.DoEvents()
                If cntr > 2 Then
                    Dim rettt As Long = CancellReceipt() 'CLOSERECEIPT()
                    Return False
                End If
                cntr += 1
            Loop
            If Tmplin.Disc <> 0 Then
                CreateDiscountLine(Tmplin.Disc)
            End If
P1:
            cntr = 1
        Next
        Dim retl2 As Long = PrintFooter(Order)
        Dim retl1 As Long = CLOSERECEIPT()
        Return True
    End Function


    Public Function PrintOrder(Order As PosOrder) As Boolean
        TamStaus = InitTam()

        Dim Status As Integer = Tamiakh.Status
        Dim cntr As Integer = 1
        RaiseEvent iDebug("PrintOrder" & Order.DocNum)

        For Each Tmplin As PosOrderLine In Order.PosOrderLines
            If Tmplin.Price = 0 Then GoTo P1
            If Tmplin.ToCashMachine = False Then
                Application.DoEvents()

                Do Until PrintLine(Tmplin) = 0
                    Application.DoEvents()
                    If cntr > 2 Then
                        Dim rettt As Long = CancellReceipt() 'CLOSERECEIPT()
                        CancellReceipt()
                        Return False
                    End If
                    cntr += 1
                Loop

                If Tmplin.Disc <> 0 Then
                    CreateDiscountLine(Tmplin.Disc)
                End If
            End If
P1:
            cntr = 1
        Next

        If Order.OrderDisc <> 0 Then
            CreateDiscountTotal(Order.OrderDisc)
        End If
        'If Order.Trapezi = "ΚΕΡΑΣΜΑ" Then CreateDiscountTotal()



        Dim retl2 As Long = PrintFooter(Order)
        Dim retl1 As Long = CLOSERECEIPT()
        CloseConnection()
        Return True
    End Function
    Public Function CLOSERECEIPT() As Long
        Dim Cmd As String = "CLOSE T=1"
        Dim result As String = ""
        Return Tamiakh.EcrCmd(Cmd, result)
    End Function
    Private Function CancellReceipt() As Long
        RaiseEvent iDebug("CancellReceipt")
        Dim Cmd As String = "RESPRN "
        Dim result As String
        Return Tamiakh.EcrCmd(Cmd, result)
    End Function
    Private Function PrintFooter(Order As PosOrder) As Long
        Dim Cmd As String
        If poscnfg.ShowFooterOnReceipt = True Then
            Cmd = "FOOTER L1='Τραπέζι='" & Order.Trapezi & ",L2='Αρ.Παραγγελίας='" & Order.DocNum
        Else
            Cmd = "FOOTER L1='Τραπέζι='" & Order.Trapezi
        End If
        Dim result As String
        Return Tamiakh.EcrCmd(Cmd, result)
    End Function
    Private Function PrintLine(Tmplin As PosOrderLine, Optional test As Boolean = False) As Long
        Dim Result As String
        Dim RetLineStatus As Long
        RetLineStatus = Tamiakh.EcrCmd(CretaLineCommand(Tmplin), Result)
        If RetLineStatus <> 0 Then RaiseEvent TamError(GetErrorDescr(RetLineStatus))
        Return RetLineStatus
    End Function

    Private Function CreateDiscountTotal(disc As Decimal) As Long
        Dim d As Decimal = Math.Round(disc, 2)

        Dim sdisc As String = CStr(d).Replace(",", ".")
        Dim Cmd As String = "PERCA RATE=" & sdisc & ",SUBTOT=1,DESCR='Έκπτωση %'"
        Debug.Print(Cmd)
        Dim Result As String
        Return Tamiakh.EcrCmd(Cmd, Result)
    End Function



    Private Function CreateDiscountLine(DiscRate As Double) As Long
        Dim DiscStr As String

        If DiscRate = 100 Then
            DiscRate = 99.99
            DiscStr = "'KEΡΑΣΜΑ'"
        Else
            DiscStr = "'ΕΚΠΤΩΣΗ'"
        End If

        Dim Disc As String = Math.Round(DiscRate, 2).ToString
        Dim fixDisc As String = Disc.Replace(",", ".")



        Threading.Thread.CurrentThread.Sleep(1000)

        Dim Cmd As String = "PERCA RATE=" & fixDisc & ",DESCR=" & DiscStr 'ΕΚΠΤΩΣΗ'" ' & DiscRate & " %'"
        Debug.Print("Perca Cmd=" & Cmd)
        Dim Result As String = ""
        Dim RETI As Integer = Tamiakh.EcrCmd(Cmd, Result)
        Debug.Print("Reti=" & RETI & " Resault=" & Result)
        'MsgBox("Result=" & Result & "  RETI=" & RETI)
        Return RETI
    End Function
    Private Function CretaLineCommand(OrdLine As PosOrderLine) As String
        Debug.Print("Qty=" & Math.Round(OrdLine.Quant, 2))
        Dim Cmd As String
        Dim qty As String = Math.Round(OrdLine.Quant, 2)
        Dim price As String '= Math.Round((OrdLine.Price + OrdLine.CommentVal), 2) '/ 100
        Dim fixqty As String
        Dim fixprice As String
        Dim TMPSTR As String = OrdLine.Product.sName
        price = Math.Round((OrdLine.Price + OrdLine.CommentVal), 2)
        ' price = Math.Round(OrdLine.Total / OrdLine.Quant, 2)


        TMPSTR = TMPSTR.Replace("'", "")
        TMPSTR = TMPSTR.Replace("%", "")
        fixqty = qty.Replace(",", ".")
        fixprice = price.Replace(",", ".")



        Cmd = "SALE DPT=" & OrdLine.Product.TheVat.Tmhma
        Cmd += ",DESCR='" & TMPSTR & "'"
        Cmd += " ,PRICE=" & fixprice
        Cmd += ",QTY=" & fixqty
        Debug.Print(Cmd)
        RaiseEvent iDebug("CretaLineCommand")
        RaiseEvent iDebug(Cmd)
        Return Cmd
    End Function


    Private Function GetErrorDescr(Lerror As Long) As String
        Dim serror As String
        Dim ErrorDescr As String = ""
        Debug.Print("Lerror=" & Lerror)
        serror = GetError(Lerror, 1) & "-" & GetError(Lerror, 2)
        Dim error1 As Integer = GetError(Lerror, 1)
        Dim error2 As Integer = GetError(Lerror, 2)

        ' Return (GetErrorType(error1) & "-" & GetErrorTypeMsg(error1, error2))


        If serror = "0-1" Then ErrorDescr = "Υποχρεωτική Έκδοση Ζ!!!!"
        If serror = "4-22" Then ErrorDescr = "Τέλος Χαρτοταινίας"
        If serror = "4-0" Then ErrorDescr = "Τέλος Χαρτοταινίας"
        If serror = "19-89" Then ErrorDescr = "Υποχρεωτική Έκδοση Ζ!!!!"
        If serror = "16-89" Then ErrorDescr = "Υποχρεωτική Έκδοση Ζ!!!!"
        If serror = "16-7" Then ErrorDescr = "Η αξία της Απόδειξης Είναι μεγαλύτερη απο το όριο της ταμειακής!!!!" '4103
        If ErrorDescr <> "" Then
            Return ErrorDescr
        Else
            Return serror
        End If
    End Function
    Private Function GetError(ErrNum As Long, Part As Integer) As Integer
        If Part = 1 Then Return Int(ErrNum / 256)
        If Part = 2 Then Return ErrNum And 255
    End Function
    Private Function GetErrorType(tamerrortype As Integer) As String
        Select Case tamerrortype
            Case 0
                Return "SYNTAX ERROR"
            Case 1
                Return "INSTRUCTION NOT FOUND"
            Case 2
                Return "INSTRUCTION NOT UNIC"
            Case 3
                Return "ILLEGAL INSTRUCTION"
            Case 4
                Return "FIELD NAME NOT FOUND"
            Case 5
                Return "FIELD NAME NOT UNIC"
            Case 6
                Return "ILLEGAL FIELD NAME"
            Case 7
                Return "LABEL-VALUE NOT FOUND"
            Case 8
                Return "ALFA-VALUE INVALID"
            Case 9
                Return "ILLEGAL VALUE"
            Case 10
                Return "MANDATORY FIELD MISSING"
            Case 11
                Return "UNEXPECTED END OF LINE"
            Case 12
                Return "INSTRUCTION NOT SUPPORTED"
            Case 13
                Return "NO DPT NUMBER OR ARTICLE CODE"
            Case 14
                Return "ILLEGAL DPT NUMBER"
            Case 15
                Return "ILLEGAL ECR-FILE NUMBER"
            Case 16
                Return "FILE NOT SUPPORTED BY ECR"
            Case 17
                Return "GROUPS FILE NOT SUPPORTED BY ECR"
            Case 18
                Return "SOURCE LINE EXCEDES MAX LENGHT"
            Case 19
                Return "ILLEGAL ECR NUMBER"
            Case 20
                Return "ILLEGAL OPERATOR CODE"
            Case 21
                Return "REPORT NOT SUPPORTED"
            Case 22
                Return "ILLEGAL MODIFIER CODE"
            Case 23
                Return "CURRENCIES FILE NOT SUPPORTED BY ECR"
            Case 24
                Return "ROGRAMMABLE GRAPHIC NOT AVAILABLE ON ECR"

        End Select
    End Function
    Private Function GetErrorTypeMsg(tamerrortype As Integer, tamerrorMsg As Integer)
        If tamerrortype = 0 Then
            Select Case tamerrorMsg
                Case 1
                    Return "SO NOT OPEN"
                Case 2
                    Return "INITIALIZATION ERROR"
                Case 3
                    Return "PROGRAMMING SESSION OPEN"
                Case 4
                    Return "CONFIGURATION ECR READ ERROR"
                Case 5
                    Return "ECR VERSION NOT SUPPORTED"
                Case 6
                    Return "ECR NOT IN IDLE "
                Case 7
                    Return "PROGRAMMING SESSION NOT OPEN"
                Case 8
                    Return "ECR NOT IN REG POSITION "
                Case 9
                    Return "EM-BOARD NOT INITALIZED ON ECR"
                Case 10
                    Return "INVALID BATCH LINE"
                Case 11
                    Return "FILE OPEN ERROR"
                Case 12
                    Return "ERROR FILE OPEN ERROR"
                Case 13
                    Return "LOG FILE OPEN ERROR"
                Case 14
                    Return "ERRORS DURING EXECUTION OF FILE"
                Case 15
                    Return "NO TRANSACTION OPEN"
                Case 16
                    Return "ERRORS DURING EXECUTION"
                Case 17
                    Return "NO SERVICE OBJECT FOUND"
                Case 18
                    Return "SO ALREADY OPEN"
                Case 19
                    Return "SO BUSY"
                Case 20
                    Return "NO SERIAL PORT"
                Case 21
                    Return "PROPERTY ERROR"
                Case 22
                    Return "INVALID PARAMETERES"
                Case 23
                    Return "INVALID PROPERTY"
                Case 24
                    Return "PROPERTY GET IMPOSSIBLE"
                Case 25
                    Return "CHIP-CARD ERROR"
                Case 26
                    Return "CHIP-CARD NOT BLANK"
                Case 27
                    Return "NO ECR SELECTED"
                Case 28
                    Return "CONNECTION TIME-OUT"
                Case 29
                    Return "MODEM ERROR"
                Case 30
                    Return "BROADCAST ERROR"
                Case 31
                    Return "INTERNAL ERROR : ECR STRING TOO BIG"
                Case 32
                    Return "THE ECR IS WAITING FOR CONFIRMATION"
                Case 33
                    Return "ECR MEMORY OVERFLOW"
                Case 34
                    Return "--"
                Case 35
                    Return "--"
                Case 36
                    Return "--"
                Case 37
                    Return "--"
                Case 38
                    Return "--"
                Case 39
                    Return "--"
                Case 40
                    Return "--"
                Case 41
                    Return "--"
                Case 42
                    Return "CANNOT READ EXTENDED STATUS"
            End Select
        End If

        If tamerrortype = 1 Then
            Select Case tamerrorMsg
                Case 0
                    Return "SYNTAX ERROR"
                Case 1
                    Return "INSTRUCTION NOT FOUND"
                Case 2
                    Return "INSTRUCTION NOT UNIC"
                Case 3
                    Return "ILLEGAL INSTRUCTION"
                Case 4
                    Return "FIELD NAME NOT FOUND"
                Case 5
                    Return "FIELD NAME NOT UNIC"
                Case 6
                    Return "ILLEGAL FIELD NAME"
                Case 7
                    Return "LABEL-VALUE NOT FOUND"
                Case 8
                    Return "ALFA-VALUE INVALID"
                Case 9
                    Return "ILLEGAL VALUE"
                Case 10
                    Return "MANDATORY FIELD MISSING"
                Case 11
                    Return "UNEXPECTED END OF LINE"
                Case 12
                    Return "INSTRUCTION NOT SUPPORTED"
                Case 13
                    Return "NO DPT NUMBER OR ARTICLE CODE"
                Case 14
                    Return "ILLEGAL DPT NUMBER"
                Case 15
                    Return "ILLEGAL ECR-FILE NUMBER "
                Case 16
                    Return "FILE NOT SUPPORTED BY ECR"
                Case 17
                    Return "GROUPS FILE NOT SUPPORTED BY ECR "
                Case 18
                    Return "SOURCE LINE EXCEDES MAX LENGHT"
                Case 19
                    Return "ILLEGAL ECR NUMBER"
                Case 20
                    Return "ILLEGAL OPERATOR CODE"
                Case 21
                    Return "REPORT NOT SUPPORTED"
                Case 22
                    Return "ILLEGAL MODIFIER CODE"
                Case 23
                    Return "CURRENCIES FILE NOT SUPPORTED BY ECR"
                Case 24
                    Return "PROGRAMMABLE GRAPHIC NOT AVAILABLE ON ECR"

            End Select
        End If
        If tamerrortype = 2 Then
            Select Case tamerrorMsg
                Case 0
                    Return "I/O ERROR"
            End Select
        End If

        If tamerrortype = 3 Then
            Select Case tamerrorMsg
                Case 0
                    Return "ECR SIGNALS CRITICAL ERROR"
            End Select
        End If

        If tamerrortype = 4 Then
            Select Case tamerrorMsg
                Case 0
                    Return "ECR REPORTS DATA-ERROR"
            End Select
        End If


        If tamerrortype = 5 Then
            Select Case tamerrorMsg
                Case 0
                    Return "ECR REPORTS ERROR"
            End Select
        End If

        If tamerrortype = 6 Then
            Select Case tamerrorMsg
                Case 0
                    Return "EM_LINK ERROR"
                Case 1
                    Return "ERRORS DURING EXECUTION"
                Case 2
                    Return "ILLEGAL COMMAND "
                Case 3
                    Return "DATA FILE OPEN ERROR"
                Case 4
                    Return "ERR FILE OPEN ERROR"
                Case 5
                    Return "LOG FILE OPEN ERROR "
                Case 6
                    Return "ERROR DURING ARTICLES-FILE RESET"
                Case 7
                    Return "ERROR DURING STAND-BY SET"
                Case 8
                    Return "ERROR IN DOWNLOAD OPEN"
                Case 9
                    Return "ECR ABORTS DOWNLOAD SESSION"
                Case 10
                    Return "ONE OR MORE ECR-RECORDS MISSING"
                Case 11
                    Return "ECR REPOERTS DATA-COLLECT OVERFLOW"
                Case 12
                    Return "CAN NOT BLOCK. TRANSACTION OPEN ON ECR"
            End Select
        End If

        If tamerrortype = 7 Then
            Select Case tamerrorMsg
                Case 0
                    Return "SYNTAX ERROR"
                Case 1
                    Return "UNEXPECTED END OF LINE"
                Case 2
                    Return "ALPHA FIELD INVALID"
                Case 3
                    Return "ARTICLE CODE INVALID"
                Case 4
                    Return "NOT NUMERIC FIELD"
                Case 5
                    Return "VAT FIELD INVALID "
                Case 6
                    Return "DPT FIELD INVALID"
                Case 7
                    Return "COMMAND FIELD INVALID"
                Case 8
                    Return "NUMERIC FILED ILLEGAL"
            End Select
        End If

        If tamerrortype = 8 Then
            Select Case tamerrorMsg
                Case 0
                    Return "ECR REPORTS ERROR"
            End Select
        End If

        If tamerrortype = 9 Then
            Select Case tamerrorMsg
                Case 0
                    Return "RICEVUTA RISPOSTA IMPREVISTA DA ECR"
            End Select
        End If
    End Function
    Public Function CheckTamWithPing() As Boolean
        Dim tamIp As String = poscnfg.TamIp
        Return My.Computer.Network.Ping(tamIp)
    End Function

    Public Function MarkOrderLinesAsCashMachine(Order As PosOrder) As Boolean
        Try
            For Each lin As PosOrderLine In Order.PosOrderLines.Where(Function(a) a.ToCashMachine = False)
                lin.ToCashMachine = True
            Next
            Return True
        Catch ex As Exception
            Debug.Print("Error MarkOrderLinesAsCashMachine" & vbCrLf & ex.Message)
            Return False
        End Try

    End Function

End Class
