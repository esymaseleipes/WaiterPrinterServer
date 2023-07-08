Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports WaiterModel.Cmp300

Public Class ClsHardJob
    Dim clsprint As ClsPosPrint
    Dim TheHardJobs As XPCollection(Of HardJob)
    Dim retb As Boolean
    Dim WithEvents Sarema As ClsSarema
    Dim Datatec As ClsDatatec
    Public Event RefreshGrid(po As PosOrder)
    '  Dim cloud As ClsCloud
    Public Sub New()
        clsprint = New ClsPosPrint
        Sarema = New ClsSarema
        Datatec = New ClsDatatec
        ' cloud = New ClsCloud(Nothing)
    End Sub
    Private Sub Sarema_TamError(ErrorVal As String) Handles Sarema.TamError

    End Sub
    Public Function StartHardJob() As Boolean
        Dim po As PosOrder
        Dim retb As Boolean
        Dim sortingcollection As SortingCollection = New SortingCollection
        sortingcollection.Add(New SortProperty("Oid", SortingDirection.Ascending))
        Using uw As New UnitOfWork(Kefdal)
p1:
            TheHardJobs = New XPCollection(Of HardJob)(uw)

            Debug.Print("TheHardJobs.Count =" & TheHardJobs.Count)
            If TheHardJobs.Count = 0 Then Return False
            po = TheHardJobs(0).PosOrder
            TheHardJobs.Sorting = sortingcollection
            TheHardJobs.DeleteObjectOnRemove = True

            retb = Work(TheHardJobs(0))
            uw.Delete(TheHardJobs(0))
            uw.CommitChanges()
            RaiseEvent RefreshGrid(po)
            GoTo p1
            Return retb
        End Using
    End Function
    Private Function Work(_HardJob As HardJob) As Boolean
        Debug.Print("ToDo=" & _HardJob.ToDo)
        Dim retb As Boolean = False
        Select Case _HardJob.ToDo
            Case EnHardJobs.EnPrint '1                
                retb = clsprint.PosPrint(_HardJob.PosOrder)
                'retb = clsprint.TestComments(_HardJob.PosOrder)

            Case EnHardJobs.EnCashMachine '2
                Select Case poscnfg.CashRegisterBrand
                    Case EnCashRegisterBrand.EnSarema
                        If Sarema.PrintOrder(_HardJob.PosOrder) = True Then Sarema.MarkOrderLinesAsCashMachine(_HardJob.PosOrder)
                    Case EnCashRegisterBrand.EnDataTec
                        Datatec.PrintOrder(_HardJob.PosOrder)
                End Select
            Case EnHardJobs.EnCashMachineRegen
                Select Case poscnfg.CashRegisterBrand
                    Case EnCashRegisterBrand.EnSarema
                        If Sarema.PrintOrder(_HardJob.PosOrder) = True Then Sarema.MarkOrderLinesAsCashMachine(_HardJob.PosOrder)
                    Case EnCashRegisterBrand.EnDataTec
                        Datatec.RecreateReceipt(_HardJob.PosOrder)
                End Select

            Case EnHardJobs.EnReceipt '3
                retb = ClsReceipt.ReceiptPrint(_HardJob.PosOrder)
            Case EnHardJobs.EnReceiptAll '5
                retb = ClsReceipt.ReceiptAllPrint(_HardJob.PosOrder)
            Case EnHardJobs.EnReceiptAllEn
                retb = ClsReceipt.ReceiptEnAllPrint(_HardJob.PosOrder)
            Case EnHardJobs.EnCloseOrder
                ClsCloseOrder.CloseOrder(_HardJob.PosOrder)
                'cloud.SyncPosOrder(_HardJob.PosOrder)
            Case EnHardJobs.EnOpenRoom

            Case EnHardJobs.EnUpdateTotal
                ClsRuntimeData.UpdateOrderValue(_HardJob.PosOrder)
            Case EnHardJobs.EnRefresh

        End Select


        Return retb
    End Function
End Class
