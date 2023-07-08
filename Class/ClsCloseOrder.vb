Imports WaiterModel.Cmp300

Public Class ClsCloseOrder
    Public Shared Function CloseOrder(ord As PosOrder)
        ord.Status = EnOrderStatus.EnOrderClosed
        ord.OrderCloseTime = Now.ToLocalTime
        ord.Save()
    End Function

    'Public Shared Function SaveFile(filename As String, contex As String)
    '    Try
    '        Dim file As System.IO.StreamWriter
    '        file = My.Computer.FileSystem.OpenTextFileWriter("ErrorFiles/" & filename, True)
    '        file.WriteLine(contex)
    '        file.Close()
    '    Catch ex As Exception

    '    End Try

    'End Function

End Class
