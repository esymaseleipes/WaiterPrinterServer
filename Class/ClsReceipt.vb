Imports DevExpress.Data.Filtering
Imports DevExpress.XtraReports.UI
Imports WaiterModel.Cmp300

Public Class ClsReceipt
    Public Shared Function ReceiptPrint(ord As PosOrder) As Boolean
        Try
            Dim co As CriteriaOperator = New BinaryOperator("ToReceipt", False) 'And New BinaryOperator("Price", 0, BinaryOperatorType.NotEqual)
            ord.PosOrderLines.Filter = co
            Dim ReportFile As String

            If ord.Language = 0 Then
                ReportFile = Application.StartupPath & "\Reports\ReportReceipt.repx"
            Else
                ReportFile = Application.StartupPath & "\Reports\ReportReceiptEn.repx"
            End If

            Using report As New XtraReport
                report.LoadLayout(ReportFile)
                report.ShowPrintMarginsWarning = False
                report.DataSource = ord
                Using printTool As New ReportPrintTool(report)
                    printTool.Print(poscnfg.ReceiptPrinter)
                End Using
            End Using

            ord.PosOrderLines.Filter = Nothing
            For Each lin As PosOrderLine In ord.PosOrderLines.Where(Function(a) a.ToReceipt = False)
                lin.ToReceipt = True
            Next
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function
    Public Shared Function ReceiptAllPrint(ord As PosOrder) As Boolean
        Try
            Dim ReportFile As String
            If ord.Language = 0 Then
                ReportFile = Application.StartupPath & "\Reports\ReportReceipt.repx"
            Else
                ReportFile = Application.StartupPath & "\Reports\ReportReceiptEn.repx"
            End If


            Using report As New XtraReport
                report.LoadLayout(ReportFile)
                report.ShowPrintMarginsWarning = False
                report.DataSource = ord
                Using printTool As New ReportPrintTool(report)
                    printTool.Print(poscnfg.ReceiptPrinter)
                End Using
            End Using


            If poscnfg.CloneReceiptPrinter <> "" Then
                Using report As New XtraReport
                    report.LoadLayout(ReportFile)
                    report.ShowPrintMarginsWarning = False
                    report.DataSource = ord
                    Using printTool As New ReportPrintTool(report)
                        printTool.Print(poscnfg.CloneReceiptPrinter)
                    End Using
                End Using
            End If


            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Shared Function ReceiptEnAllPrint(ord As PosOrder) As Boolean
        Try
            Dim ReportFile As String = Application.StartupPath & "\Reports\ReportReceiptEn.repx"
            Using report As New XtraReport
                report.LoadLayout(ReportFile)
                report.ShowPrintMarginsWarning = False
                report.DataSource = ord
                Using printTool As New ReportPrintTool(report)
                    printTool.Print(poscnfg.ReceiptPrinter)
                End Using
            End Using

            If poscnfg.CloneReceiptPrinter <> "" Then
                Using report As New XtraReport
                    report.LoadLayout(ReportFile)
                    report.ShowPrintMarginsWarning = False
                    report.DataSource = ord
                    Using printTool As New ReportPrintTool(report)
                        printTool.Print(poscnfg.CloneReceiptPrinter)
                    End Using
                End Using
            End If

            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function



End Class
