Imports System.Reflection
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraReports.UI
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports WaiterModel.Cmp300

Public Class FrmStart
    Dim WithEvents clshardjob As ClsHardJob
    Dim ses1 As Session
    Dim Orders As XPCollection(Of PosOrder)
    Dim WithEvents Flogon As FormLogon


    Dim FlogonStatus As Boolean = False
    ReadOnly dictionary As XPDictionary
    Public Sub New()
        InitializeComponent()
        InitGridCollection()
        Me.Text = "NrgWaiter Printer Service " & Application.ProductVersion
        clshardjob = New ClsHardJob
        Timer1.Enabled = True
        Timer2.Enabled = False
        Dim Sexist As String = Dir(RemoteSqlConParmFile)
        If Sexist = "" Then
            BarBtnCloud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        End If
        BarBtnClearNoFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Function InitGridCollection()
        ses1 = New Session(Kefdal)
        Orders = New XPCollection(Of PosOrder)(ses1, New BinaryOperator("Finalization", False))
        Debug.Print("Orders Count=" & Orders.Count)
        UsersCollection.Session = ses1
        CmbUser.EditValue = UsersCollection(0)
        Grid1.DataSource = Orders
        Grid2.DataSource = Orders
        Grid3.DataSource = Orders


        GridView1.ActiveFilter.NonColumnFilter = "Status=1 And Finalization=False"
        GridView2.ActiveFilter.NonColumnFilter = "Status<> 1 And Finalization=False"
        If poscnfg.ShowDetailOnPrintServer = False Then
            Grid1.Visible = False
            Grid2.Visible = False
            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        If poscnfg.RoomManager = False Then
            GridView1.Columns.Where(Function(a) a.Name = "GridColumn10").First.Visible = False
            GridView2.Columns.Where(Function(a) a.Name = "GridColumn30").First.Visible = False
            GridView3.Columns.Where(Function(a) a.Name = "GridColumn59").First.Visible = False
        End If

    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim retb As Boolean
        Timer1.Enabled = False
        retb = clshardjob.StartHardJob()
        Timer1.Enabled = True
    End Sub

    Private Sub clshardjob_RefreshGrid(po As PosOrder) Handles clshardjob.RefreshGrid
        Debug.Print("Refresh Tmer Enabled" & Timer1.Enabled)
        Dim d As Boolean = ClsRuntimeData.UpdateOrderValue(po)
        Dim tmpPo As PosOrder = ses1.FindObject(Of PosOrder)(New BinaryOperator("Oid", po.Oid))
        ses1.Reload(tmpPo)
        Orders.Reload()
    End Sub
    Private Function RefreshAll() As Boolean
        Try
            Debug.Print("RefreshAll")
            Dim ses2 As Session = New Session(Kefdal)
            Dim TmpOrders As XPCollection(Of PosOrder) = New XPCollection(Of PosOrder)(ses2, New BinaryOperator("Status", 1) And New BinaryOperator("Finalization", False))
            For Each ord As PosOrder In TmpOrders
                clshardjob_RefreshGrid(ord)
            Next
            Return True
        Catch ex As Exception
            Debug.Print("RefreshAll Error " & ex.Message)
            Return False
        End Try
    End Function
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If FlogonStatus = False Then
            Flogon = New FormLogon
            Flogon.ShowDialog()
        Else
            Grid1.Visible = False
            Grid2.Visible = False
            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            BarBtnClearNoFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            FlogonStatus = False
        End If

    End Sub
    Private Sub Flogon_Logon(LogUser As MyUsers) Handles Flogon.Logon
        If LogUser.Roll.Descr = "AdministratorRoll" Then
            Grid1.Visible = True
            Grid2.Visible = True
            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            BarBtnClearNoFiscal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            FlogonStatus = True
        End If

    End Sub

    Private Sub CmbUser_EditValueChanged(sender As Object, e As EventArgs) Handles CmbUser.EditValueChanged
        Dim TmpUser As MyUsers = CmbUser.EditValue
        Debug.Print("TmpUserId=" & TmpUser.Oid)
        GridView3.ActiveFilterString = ""
        GridView3.ActiveFilterString = "[User.UserName] ='" & TmpUser.UserName & "'  And Status<>1 And Finalization=False"

        Dim ContainString As String = ""
        If TmpUser.UserName = "Administrator" Then
            ContainString = "/0#"
        Else
            ContainString = "/" & TmpUser.Oid & "#"
        End If


        'Dim ordlines As XPCollection(Of PosOrderLine) = 
        Dim ses3 As Session = New Session(Kefdal)
        Grid4.DataSource = New XPCollection(Of PosOrderLine)(ses3).Where(Function(a) a.AppComments.Contains(ContainString)).Where(Function(b) b.PosOrder.Finalization = False)
        ', New BinaryOperator("[PosOrder.Finalization]", False))
    End Sub
    Private Sub BtnOristikopoihsh_Click(sender As Object, e As EventArgs) Handles BtnOristikopoihsh.Click
        Dim uw1 As UnitOfWork = New UnitOfWork(Kefdal)
        Dim TmpUser As MyUsers = CmbUser.EditValue

        Debug.Print("TmpUser Id=" & TmpUser.Oid)

        Dim TmpOrders1 As XPCollection(Of PosOrder)
        Dim TmpOrders2 As XPCollection(Of PosOrder)
        Dim TmpOrders3 As XPCollection(Of PosOrder)


        TmpOrders1 = New XPCollection(Of PosOrder)(uw1,
                                                  New BinaryOperator("Status", EnOrderStatus.EnOrderClosed) And
                                                  New BinaryOperator("Finalization", False) And
                                                  New BinaryOperator("User.Oid", TmpUser.Oid) And
                                                  New BinaryOperator("OrderPayType", 0))

        TmpOrders2 = New XPCollection(Of PosOrder)(uw1,
                                                  New BinaryOperator("Status", EnOrderStatus.EnOrderClosed) And
                                                  New BinaryOperator("Finalization", False) And
                                                  New BinaryOperator("User.Oid", TmpUser.Oid) And
                                                  New BinaryOperator("OrderPayType", 1))

        TmpOrders3 = New XPCollection(Of PosOrder)(uw1,
                                                  New BinaryOperator("Status", EnOrderStatus.EnOrderClosed) And
                                                  New BinaryOperator("Finalization", False) And
                                                  New BinaryOperator("User.Oid", TmpUser.Oid) And
                                                  New BinaryOperator("OrderPayType", 2))






        Dim CardTotal As Double = TmpOrders3.Sum(Function(a) a.OrderTotal)
        Dim CashTotal As Double = TmpOrders1.Sum(Function(a) a.OrderTotal) + TmpOrders2.Sum(Function(a) a.OrderTotal)
        Dim report As New Oristik
        report.ShowPrintMarginsWarning = False
        report.DataSource = Nothing
        report.Title1.Text = ""
        report.XrLabel3.Text = Now.Date.ToShortDateString
        report.XrLabel5.Text = TmpUser.UserName
        report.XrLabel7.Text = CashTotal
        report.XrLabel9.Text = CardTotal
        report.XrLabel11.Text = GetKerasmataSum()

        Using printTool As New ReportPrintTool(report)
            printTool.Print(poscnfg.ReceiptPrinter)
        End Using




        For Each po As PosOrder In TmpOrders1
            Debug.Print("TmpoOrders1 Id=" & po.Oid)
            po.Finalization = True
        Next
        For Each po1 As PosOrder In TmpOrders2
            Debug.Print("TmpoOrders2 Id=" & po1.Oid)
            po1.Finalization = True
        Next
        For Each po2 As PosOrder In TmpOrders3
            Debug.Print("TmpoOrders3 Id=" & po2.Oid)
            po2.Finalization = True
        Next

        uw1.CommitChanges()
        Debug.Print("uw1.CommitChanges")
        Orders.Reload()
        Debug.Print("Orders.Reload")
        GridView1.RefreshData()
        Debug.Print("GridView1.RefreshData")
        GridView2.RefreshData()
        Debug.Print("GridView2.RefreshData")
        GridView3.RefreshData()
        Debug.Print("GridView3.RefreshData")
        Grid4.DataSource = Nothing
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim retb As Boolean
        Try
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
                retb = RefreshAll()
                Timer1.Enabled = True
            End If
        Catch ex As Exception
            Timer1.Enabled = True
        End Try


    End Sub



    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim TmpPosOrder As PosOrder = GridView1.GetFocusedRow()
        ses1.Reload(TmpPosOrder)
        Orders.Reload()

        If Not TmpPosOrder Is Nothing Then
            Dim f As FrmOrder = New FrmOrder(TmpPosOrder)
            f.ShowDialog()
        Else
            Debug.Print("Nothing")
        End If

    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Dim TmpPosOrder As PosOrder = GridView2.GetFocusedRow()
        ses1.Reload(TmpPosOrder)
        Orders.Reload()
        If Not TmpPosOrder Is Nothing Then
            Dim f As FrmOrder = New FrmOrder(TmpPosOrder)
            f.ShowDialog()
            clshardjob_RefreshGrid(TmpPosOrder)
        Else
            Debug.Print("Nothing")
        End If

    End Sub






    Private Function GetKerasmataSum() As String
        Dim sum As Decimal = 0
        For i = 0 To GridView4.RowCount - 1
            sum += GridView4.GetRowCellValue(i, "CustomSum")
        Next
        Return Math.Round(sum, 2).ToString
    End Function
    Private Sub XtraForm1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            NotifyIcon1.Visible = False
        Catch ex As Exception

        End Try
    End Sub


End Class