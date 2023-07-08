Imports System
Imports System.IO
Imports WaiterModel.Cmp300
Imports System.Text
Public Class ClsDatatec



    Public Function RecreateReceipt(order As PosOrder) As Boolean
        Try
            'If order.PosOrderLines.Where(Function(a) a.ToCashMachine = False).Count = 0 Then Return True
            Dim Str As String = "FR" & vbCrLf
            Dim filepath As String = poscnfg.FiscalPath & "\" & order.Oid & ".txt"
            For Each Tmplin As PosOrderLine In order.PosOrderLines
                Application.DoEvents()
                Str += GenSaleLine(Tmplin) & vbCrLf
            Next
            Str += CreateDicountSubTotal(order)
            Str += CreateMessage(order)
            Str += CloseReceipt(order)
            Debug.Print(Str)
            Return CreateReceiptFile(Str, filepath)
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function PrintOrder(Order As PosOrder) As Boolean
        Try
            Dim Str As String = "FR" & vbCrLf
            Dim filepath As String = poscnfg.FiscalPath & "\" & Order.Oid & ".txt"
            If Order.PosOrderLines.Where(Function(a) a.ToCashMachine = False).Count = 0 Then Return True
            For Each Tmplin As PosOrderLine In Order.PosOrderLines
                If Tmplin.ToCashMachine = False Then
                    Application.DoEvents()
                    Str += GenSaleLine(Tmplin) & vbCrLf
                    Str += CreateDicountLine(Tmplin) & vbCrLf
                End If
            Next
            Str += CreateDicountSubTotal(Order)
            Str += CreateMessage(Order)
            Str += CloseReceipt(Order)
            Dim ret1 As Boolean = CreateReceiptFile(Str, filepath)
            Return MarkOrderLinesAsToTamiakh(Order)
        Catch ex As Exception
            Return True
        End Try
    End Function
    Private Function MarkOrderLinesAsToTamiakh(Order As PosOrder) As Boolean
        For Each Tmplin As PosOrderLine In Order.PosOrderLines
            If Tmplin.ToCashMachine = False Then
                Tmplin.ToCashMachine = True
            End If
        Next

    End Function

    Private Function GenSaleLine(lin As PosOrderLine) As String
        Dim Str As String = "SI|"
        Dim price As String = Math.Round(lin.Total / lin.Quant, 2)


        Str += lin.ProductDescr.ToUpper & "|"
        Str += Math.Round(lin.Quant, 2) & "|"
        Str += price & "|"
        Str += lin.Product.TheVat.Tmhma.ToString
        Str = Str.Replace(",", ".")
        Return Str
    End Function

    Private Function GenFakeSaleLine(lin As PosOrderLine) As String
        Dim Str As String
        Dim price As String = Math.Round(lin.Total / lin.Quant, 2)
        Str += lin.ProductDescr & "|"
        Str += Math.Round(lin.Quant / 100, 2) & " x " & price
        Str += price
        Str += lin.Product.TheVat.Tmhma.ToString
        Str = Str.Replace(",", ".")
        Return Str
    End Function




    Private Function CloseReceipt(Order As PosOrder) As String
        Dim str As String = ""
        Select Case Order.OrderPayType
            Case EnOrderPayType.EnPayTypeCash
                Return "CR|1"
            Case EnOrderPayType.EnPayTypeCreditCard
                Return "CD|1"
            Case EnOrderPayType.EnPayTypeRoomCharge
                Return "CR|1"
        End Select

    End Function
    Private Function CreateDicountLine(Lin As PosOrderLine) As String
        Return "P% |" & Lin.Disc & "|" & Lin.Product.TheVat.Tmhma.ToString
    End Function
    Private Function CreateDicountSubTotal(ord As PosOrder) As String
        If ord.OrderDisc = 0 Then
            Return ""
        Else
            Return "T% |" & Math.Round(ord.OrderDisc, 2) & "|1" & vbCrLf
        End If

    End Function
    Private Function CreateReceiptFile(str As String, filepath As String) As Boolean


        Using fs As New FileStream(filepath, FileMode.Create)

            Using sw As New StreamWriter(fs, Encoding.Default)
                sw.WriteLine(str)
            End Using
        End Using
    End Function
    Private Function CreateMessage(Ord As PosOrder) As String
        Dim str As String
        If Not Ord.RoomTrans Is Nothing Then
            str += "FM|1|Room:" & Ord.RoomTrans.Room.RoomDescr & vbCrLf
            str += "FM|2|Table:" & Ord.Trapezi & vbCrLf
        Else
            str += "FM|1|Table:" & Ord.Trapezi & vbCrLf
        End If

        Return str
    End Function

    'Public Function CreateFakeReceipt(Ord As PosOrder) As String
    '    Dim filepath As String = poscnfg.FiscalPath & "\" & Ord.Oid & ".txt"
    '    Dim cntr As Integer = 1
    '    Dim str As String
    '    str = "NF|0" & vbCrLf
    '    'str += "FM|1|123456789012345678901234567890" & vbCrLf
    '    For Each Tmplin As PosOrderLine In Ord.PosOrderLines
    '        str += "FM|" & cntr & "|" & CreateFakeLine(Tmplin) & vbCrLf

    '        cntr += 1
    '    Next
    '    str += "NF|1"
    '    Return CreateReceiptFile(str, filepath)
    'End Function
    'Private Function CreateFakeLine(LIN As PosOrderLine) As String
    '    Dim qnt As String = Math.Round(LIN.Quant, 2)
    '    Dim price As String = Math.Round(LIN.Price, 2)
    '    Dim s1 As String = " x "
    '    Dim Space As String = ""
    '    Space = Space.PadLeft(28 - Len(qnt) - Len(price) - Len(s1))
    '    Return qnt & s1 & Space & price
    'End Function
End Class
