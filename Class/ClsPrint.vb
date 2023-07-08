Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Extensions
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraReports.UI
Imports WaiterModel.Cmp300

Public Class ClsPosPrint
    Enum printertype
        normalPrinter = 1
        clonePrinter = 2
    End Enum
    Public Shared Function ParalelPrinting(ord As PosOrder) As Boolean
        Try


            Dim op1 As CriteriaOperator
            Dim op2 As CriteriaOperator
            Dim op3 As CriteriaOperator
            Dim op4 As CriteriaOperator
            Dim op5 As CriteriaOperator
            Dim ReportPrinter1 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1", Nothing)
            Dim ReportPrinter2 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2", Nothing)
            Dim ReportPrinter3 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3", Nothing)
            Dim ReportPrinter4 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4", Nothing)
            Dim ReportPrinter5 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5", Nothing)
            Dim ReportPrinterDescr1 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1Descr", Nothing)
            Dim ReportPrinterDescr2 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2Descr", Nothing)
            Dim ReportPrinterDescr3 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3Descr", Nothing)
            Dim ReportPrinterDescr4 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4Descr", Nothing)
            Dim ReportPrinterDescr5 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5Descr", Nothing)





            Dim retb As Boolean
            op1 = New BinaryOperator("Product.Printer1", True) And New BinaryOperator("ToPrinter", False)
            op2 = New BinaryOperator("Product.Printer2", True) And New BinaryOperator("ToPrinter", False)
            op3 = New BinaryOperator("Product.Printer3", True) And New BinaryOperator("ToPrinter", False)
            op4 = New BinaryOperator("Product.Printer4", True) And New BinaryOperator("ToPrinter", False)
            op5 = New BinaryOperator("Product.Printer5", True) And New BinaryOperator("ToPrinter", False)



            If ReportPrinter1 <> "" Then ord.PosOrderLines.Filter = op1 : retb = JustPrint(ord, ReportPrinter1, ReportPrinterDescr1) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter2 <> "" Then ord.PosOrderLines.Filter = op2 : retb = JustPrint(ord, ReportPrinter2, ReportPrinterDescr2) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter3 <> "" Then ord.PosOrderLines.Filter = op3 : retb = JustPrint(ord, ReportPrinter3, ReportPrinterDescr3) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter4 <> "" Then ord.PosOrderLines.Filter = op4 : retb = JustPrint(ord, ReportPrinter4, ReportPrinterDescr4) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter5 <> "" Then ord.PosOrderLines.Filter = op5 : retb = JustPrint(ord, ReportPrinter5, ReportPrinterDescr5) : ord.PosOrderLines.Filter = Nothing


            Return True

        Catch ex As Exception
            Debug.Print("ParalelPrinting Error" & vbCrLf & ex.Message)
            Return False
        End Try

    End Function
    Public Shared Function ParalelPrintingNew(ord As PosOrder) As Boolean
        Try
            Dim op1 As CriteriaOperator
            Dim op2 As CriteriaOperator
            Dim op3 As CriteriaOperator
            Dim op4 As CriteriaOperator
            Dim op5 As CriteriaOperator

            Dim opp1 As CriteriaOperator
            Dim opp2 As CriteriaOperator
            Dim opp3 As CriteriaOperator
            Dim opp4 As CriteriaOperator
            Dim opp5 As CriteriaOperator

            Dim ReportPrinter1 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1", Nothing)
            Dim ReportPrinter2 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2", Nothing)
            Dim ReportPrinter3 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3", Nothing)
            Dim ReportPrinter4 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4", Nothing)
            Dim ReportPrinter5 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5", Nothing)

            Dim ReportPrinterDescr1 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer1Descr", Nothing)
            Dim ReportPrinterDescr2 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer2Descr", Nothing)
            Dim ReportPrinterDescr3 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer3Descr", Nothing)
            Dim ReportPrinterDescr4 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer4Descr", Nothing)
            Dim ReportPrinterDescr5 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "Printer5Descr", Nothing)


            Dim ParallelPrinter1 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter1", Nothing)
            Dim ParallelPrinter2 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter2", Nothing)
            Dim ParallelPrinter3 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter3", Nothing)
            Dim ParallelPrinter4 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter4", Nothing)
            Dim ParallelPrinter5 As String = My.Computer.Registry.GetValue(ClsRegKeys.PrinterKeyFullPath, "ParallelPrinter5", Nothing)



            Dim sortingcollection1 As SortingCollection = New SortingCollection : sortingcollection1.Add(New SortProperty("Product.Printer1", SortingDirection.Ascending))
            Dim sortingcollection2 As SortingCollection = New SortingCollection : sortingcollection2.Add(New SortProperty("Product.Printer2", SortingDirection.Ascending))
            Dim sortingcollection3 As SortingCollection = New SortingCollection : sortingcollection3.Add(New SortProperty("Product.Printer3", SortingDirection.Ascending))
            Dim sortingcollection4 As SortingCollection = New SortingCollection : sortingcollection4.Add(New SortProperty("Product.Printer4", SortingDirection.Ascending))
            Dim sortingcollection5 As SortingCollection = New SortingCollection : sortingcollection5.Add(New SortProperty("Product.Printer5", SortingDirection.Ascending))

            'ord.Sorting = sortingcollection



            Dim retb As Boolean

            If ParallelPrinter1 <> "" Then
                Dim pstr1 As String = "Product.Printer#"
                pstr1 = pstr1.Replace("#", ParallelPrinter1)
                opp1 = New BinaryOperator(pstr1, True)
            Else
                opp1 = New BinaryOperator("Product.sFileId", 0, BinaryOperatorType.Greater)
            End If

            If ParallelPrinter2 <> "" Then
                Dim pstr2 As String = "Product.Printer#"
                pstr2 = pstr2.Replace("#", ParallelPrinter2)
                opp2 = New BinaryOperator(pstr2, True)
            Else
                opp2 = New BinaryOperator("Product.sFileId", 0, BinaryOperatorType.Greater)
            End If


            If ParallelPrinter3 <> "" Then
                Dim pstr3 As String = "Product.Printer#"
                pstr3 = pstr3.Replace("#", ParallelPrinter3)
                opp3 = New BinaryOperator(pstr3, True)
            Else
                opp3 = New BinaryOperator("Product.sFileId", 0, BinaryOperatorType.Greater)
            End If
            If ParallelPrinter4 <> "" Then
                Dim pstr4 As String = "Product.Printer#"
                pstr4 = pstr4.Replace("#", ParallelPrinter4)
                opp4 = New BinaryOperator(pstr4, True)
            Else
                opp4 = New BinaryOperator("Product.sFileId", 0, BinaryOperatorType.Greater)
            End If
            If ParallelPrinter5 <> "" Then
                Dim pstr5 As String = "Product.Printer#"
                pstr5 = pstr5.Replace("#", ParallelPrinter5)
                opp5 = New BinaryOperator(pstr5, True)
            Else
                opp5 = New BinaryOperator("Product.sFileId", 0, BinaryOperatorType.Greater)
            End If
            Dim pp As SMAST


            op1 = New BinaryOperator("Product.Printer1", True) And New BinaryOperator("ToPrinter", False) Or opp1
            op2 = New BinaryOperator("Product.Printer2", True) And New BinaryOperator("ToPrinter", False) Or opp2
            op3 = New BinaryOperator("Product.Printer3", True) And New BinaryOperator("ToPrinter", False) Or opp3
            op4 = New BinaryOperator("Product.Printer4", True) And New BinaryOperator("ToPrinter", False) Or opp4
            op5 = New BinaryOperator("Product.Printer5", True) And New BinaryOperator("ToPrinter", False) Or opp5



            If ReportPrinter1 <> "" Then ord.PosOrderLines.Filter = op1 : retb = JustPrint(ord, ReportPrinter1, ReportPrinterDescr1) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter2 <> "" Then ord.PosOrderLines.Filter = op2 : retb = JustPrint(ord, ReportPrinter2, ReportPrinterDescr2) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter3 <> "" Then ord.PosOrderLines.Filter = op3 : retb = JustPrint(ord, ReportPrinter3, ReportPrinterDescr3) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter4 <> "" Then ord.PosOrderLines.Filter = op4 : retb = JustPrint(ord, ReportPrinter4, ReportPrinterDescr4) : ord.PosOrderLines.Filter = Nothing
            If ReportPrinter5 <> "" Then ord.PosOrderLines.Filter = op5 : retb = JustPrint(ord, ReportPrinter5, ReportPrinterDescr5) : ord.PosOrderLines.Filter = Nothing
            Return True
        Catch ex As Exception
            Debug.Print("ParalelPrinting Error" & vbCrLf & ex.Message)
            Return False
        End Try




    End Function





    Public Shared Function JustPrint(ord As PosOrder, ReportPrinter As String, ReportPrinterDescr As String) As Boolean
        If ord.PosOrderLines.Count = 0 Then Return True

        ord.ParallelPrintHeader = ReportPrinterDescr
        Try
            Dim ReportFile As String = Application.StartupPath & "\Reports\PosOrderReport.repx"
            Using report As New XtraReport
                report.LoadLayout(ReportFile)
                report.ShowPrintMarginsWarning = False
                report.DataSource = ord

                Using printTool As New ReportPrintTool(report)
                    printTool.Print(ReportPrinter)
                End Using
            End Using
            Return True
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return False
        End Try
    End Function








    Public Shared Function RegenPosPrint(ord As PosOrder) As Boolean
        Dim retb1 As Boolean
        Dim retb2 As Boolean
        Try
            Dim OrderPrinters As IEnumerable(Of String) = ord.PosOrderLines.Select(Function(b) b.Printer).Distinct
            For Each oPrinter As String In OrderPrinters
                retb1 = PrintPosOrderReport(ord, oPrinter, printertype.normalPrinter, True)
            Next

            ord.PosOrderLines.Filter = Nothing
            Dim OrderClonePrinters As IEnumerable(Of String) = ord.PosOrderLines.Where(Function(b) b.ClonePrinter <> "null").Select(Function(c) c.ClonePrinter).Distinct

            For Each oClonePrinter As String In OrderClonePrinters
                Debug.Print("ClonePrinter=" & oClonePrinter)
                retb2 = PrintPosOrderReport(ord, oClonePrinter, printertype.clonePrinter, True)
            Next



            ord.PosOrderLines.Filter = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Shared Function PosPrint(ord As PosOrder) As Boolean
        Dim retb1 As Boolean
        Dim retb2 As Boolean


        Try
            Dim rett1 As Boolean = UpdateProductRemain(ord)
            Dim OrderPrinters As IEnumerable(Of String) = ord.PosOrderLines.Where(Function(a) a.ToPrinter = False).Select(Function(b) b.Printer).Distinct
            '  Dim OrderClonePrinters As IEnumerable(Of String) = ord.PosOrderLines.Where(Function(a) a.ToPrinter = False).Select(Function(b) b.ClonePrinter).Distinct

            For Each oPrinter As String In OrderPrinters
                Debug.Print("oPrinter=" & oPrinter)
                retb1 = PrintPosOrderReport(ord, oPrinter, printertype.normalPrinter)
            Next



            ord.PosOrderLines.Filter = Nothing
            Dim OrderClonePrinters As IEnumerable(Of String) = ord.PosOrderLines.Where(Function(a) a.ToPrinter = False).Where(Function(b) b.ClonePrinter <> "null").Select(Function(c) c.ClonePrinter).Distinct
            For Each oPrinter As String In OrderClonePrinters
                retb2 = PrintPosOrderReport(ord, oPrinter, printertype.clonePrinter)
            Next

            ord.PosOrderLines.Filter = Nothing


            Dim retbvb As Boolean = ParalelPrinting(ord)

            ord.PosOrderLines.Filter = Nothing
            Return MarkOrderLinesAsPrinted(ord)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Shared Function PrintPosOrderReport(Ord As PosOrder, ReportPrinter As String, _pritnerType As printertype, Optional ToPrinter As Boolean = False) As Boolean
        Debug.Print("PrintPosOrderReport ReportPrinter=" & ReportPrinter)
        If ReportPrinter = "" Or ReportPrinter = "null" Then Return True
        Dim op1 As CriteriaOperator
        Dim op2 As CriteriaOperator

        If ToPrinter = False Then
            op1 = New BinaryOperator("Printer", ReportPrinter) And New BinaryOperator("ToPrinter", ToPrinter)
            op2 = New BinaryOperator("ClonePrinter", ReportPrinter) And New BinaryOperator("ToPrinter", ToPrinter)
        Else
            op1 = New BinaryOperator("Printer", ReportPrinter)
            op2 = New BinaryOperator("ClonePrinter", ReportPrinter)
        End If



        Select Case _pritnerType
            Case printertype.normalPrinter
                Ord.PosOrderLines.Filter = op1
            Case printertype.clonePrinter
                Ord.PosOrderLines.Filter = op2
        End Select

        Debug.Print("Ord.PosOrderLines.Count=" & Ord.PosOrderLines.Count)
        If Ord.PosOrderLines.Count = 0 Then Return True


        Debug.Print("Finaly Lines=" & Ord.PosOrderLines.Count)
        Ord.ParallelPrintHeader = ReportPrinter
        Try
            Dim ReportFile As String = Application.StartupPath & "\Reports\PosOrderReport.repx"
            Using report As New XtraReport
                report.LoadLayout(ReportFile)
                report.ShowPrintMarginsWarning = False
                report.DataSource = Ord
                Using printTool As New ReportPrintTool(report)
                    printTool.Print(ReportPrinter)
                End Using
            End Using
            Return True
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return False
        End Try
    End Function
    Private Shared Function MarkOrderLinesAsPrinted(Order As PosOrder) As Boolean
        Try
            For Each lin As PosOrderLine In Order.PosOrderLines.Where(Function(a) a.ToPrinter = False)
                lin.ToPrinter = True
            Next
            Return True
        Catch ex As Exception
            Debug.Print("Error MarkOrderLinesAsPrinted" & vbCrLf & ex.Message)
            Return False
        End Try

    End Function


    Private Shared Function UpdateProductRemain(ord As PosOrder) As Boolean
        For Each lin As PosOrderLine In ord.PosOrderLines
            If lin.ToPrinter = False Then
                If lin.Product.sUsrNums2 = -1 Then

                    lin.Product.sUsrNums3 = lin.Product.sUsrNums3 - lin.Quant
                    Debug.Print("Product " & lin.Product.sName & " QNT=" & lin.Product.sUsrNums3)
                End If
            End If

        Next
    End Function

End Class
