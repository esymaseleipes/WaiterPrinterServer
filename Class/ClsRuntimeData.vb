Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports WaiterModel.Cmp300

Public Class ClsRuntimeData
    Public Shared Function UpdateOrderValue(Ord As PosOrder) As Boolean
        Try


            Dim SqlStr As String = "Select sum(productval + CommentsVal-DISCVAL) As CalcTotal FROM PosOrderLine where posorder=" & Ord.Oid


            Dim seldata As SelectedData
            Dim OrderValue As Decimal
            Dim sOrderValue As String
            Dim OrderDiscValue As Decimal
            Dim sOrderDiscValue As String
            Dim OrderValueAfterDisc As Decimal
            Dim sOrderValueAfterDisc As String
            Using uw3 As New UnitOfWork(Kefdal)
                seldata = uw3.ExecuteQuery(SqlStr)
                OrderValue = seldata.ResultSet(0).Rows(0).Values(0)
                OrderDiscValue = OrderValue * Ord.OrderDisc / 100
                OrderValueAfterDisc = OrderValue - OrderDiscValue
                sOrderValue = CStr(OrderValue).Replace(",", ".")
                sOrderDiscValue = CStr(OrderDiscValue).Replace(",", ".")
                sOrderValueAfterDisc = CStr(OrderValueAfterDisc).Replace(",", ".")
                'SqlStr = "Update PosOrder set OrderValue=" & sOrderValue & ",OrderDiscVal=" & sOrderDiscValue & ",OrderTotal=" & sOrderValueAfterDisc & "  Where Oid=" & Ord.Oid
                SqlStr = "Update PosOrder set OrderValue=" & sOrderValue & ",OrderDiscVal=" & sOrderDiscValue & ",OrderTotal=" & sOrderValueAfterDisc & "  Where Oid=" & Ord.Oid
                seldata = uw3.ExecuteQuery(SqlStr)
            End Using
            Debug.Print("OrderValue=" & OrderValue)

            Return True
        Catch ex As Exception
            Debug.Print("GetOrderValue Error" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function



End Class

