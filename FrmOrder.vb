Imports DevExpress.Xpo
Imports WaiterModel.Cmp300

Public Class FrmOrder
    Dim ses As Session
    Dim Ord As PosOrder
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(_Ord As PosOrder)
        InitializeComponent()

        ses = New Session(Kefdal)

        Ord = ses.GetObjectByKey(Of PosOrder)(_Ord.Oid)
        CmbOrderStatus.Properties.AddEnum(GetType(EnOrderStatus))
        CmbPayMode.Properties.AddEnum(GetType(EnOrderPayType))
        If poscnfg.RoomManager = True Then
            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            RoomsCollection.Session = ses
            If Not Ord.RoomTrans Is Nothing Then CmbRoom.EditValue = Ord.RoomTrans.Room
        End If

        initBind()
    End Sub



    Private Sub initBind()
        txtOrderDate.DataBindings.Add(New Binding("Text", Ord, "OrderDate"))
        txtOrderNum.DataBindings.Add(New Binding("Text", Ord, "DocNum"))
        txtStartTime.DataBindings.Add(New Binding("Text", Ord, "OrderCreateTime"))
        txtTrapezi.DataBindings.Add(New Binding("Text", Ord, "Trapezi"))
        txtUser.DataBindings.Add(New Binding("Text", Ord.User, "UserName"))
        GridControl1.DataSource = Ord.PosOrderLines
        CmbOrderStatus.DataBindings.Add(New Binding("EditValue", Ord, "Status"))
        CmbPayMode.DataBindings.Add(New Binding("EditValue", Ord, "OrderPayType"))

    End Sub




    Private Function CreateJob(todo As EnHardJobs) As Boolean
        Try
            Dim hd As HardJob = New HardJob(ses) With {
                .PosOrder = Ord,
                .ToDo = todo,
                .User = Nothing,'SES.GetObjectByKey(Of MyUsers)(LogonData.LogonUserId),
                .Station = Ord.Station
            }
            hd.Save()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub BtnChangeOrderStatus_Click(sender As Object, e As EventArgs) Handles BtnChangeOrderStatus.Click
        ses.Save(Ord)
        Me.Close()
        MsgBox("H Αλλαγή Ολοκληρώθηκε")
    End Sub



    Private Sub BtnAction_Click(sender As Object, e As EventArgs) Handles BtnAction.Click
        Select Case CmbActions.SelectedIndex
            Case 0 'Εκτύπωση Λογαριασμού
                Debug.Print("Εκτύπωση Λογαριασμού")
                CreateJob(EnHardJobs.EnReceiptAll)
            Case 1
                Debug.Print("Εκπτύπωση Εκρεμότητες Απόδειξης")
                CreateJob(EnHardJobs.EnCashMachine)
            Case 2
                Debug.Print("Επανεκτύπωση Απόδειξης")
                CreateJob(EnHardJobs.EnCashMachineRegen)
            Case 3
                Debug.Print("Εκτύπψση Ειδών")
                ClsPosPrint.RegenPosPrint(Ord)
                'ClsPosPrint.ParalelPrinting(Ord)
            Case 4
                Debug.Print("")
        End Select
        MsgBox("H Ενέργεια Ολοκληρώθηκε")
    End Sub

    Private Sub BtnChengeRoom_Click(sender As Object, e As EventArgs) Handles BtnChengeRoom.Click
        Dim room As Room = CmbRoom.EditValue

        If room Is Nothing Then
            Ord.RoomTrans = Nothing
        Else
            Ord.RoomTrans = room.RoomTransCollection.Where(Function(a) a.Status = 0).FirstOrDefault
        End If
        ses.Save(Ord)
        CreateJob(EnHardJobs.EnRefresh)
        MsgBox("H Αλλαγή Ολοκληρώθηκε")
        Me.Close()
    End Sub

    Private Sub BtnChangePayMode_Click(sender As Object, e As EventArgs) Handles BtnChangePayMode.Click
        ses.Save(Ord)
        Me.Close()
        MsgBox("H Αλλαγή Ολοκληρώθηκε")
    End Sub
End Class