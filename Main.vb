Imports System.Globalization
Imports System.Text
Imports System.Threading
Imports DevExpress.Skins
Imports DevExpress.Utils.DirectXPaint
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports WaiterModel.Cmp300

Module Main
    Public poscnfg As PosCnfg
    Public SqlConParmFile As String = Application.StartupPath & "\vault\MyErpSqlCon.json"
    Public RemoteSqlConParmFile As String = Application.StartupPath & "\vault\SqlConRemote.json"
    Public Kefdal As IDataLayer

    Public clsconnection As NrgSqlConnection.ClsConnection

    Public CryptKey As String = ""
    Public Sub main(args As String())
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("el-GR")
        SkinManager.EnableFormSkins()
        SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        CheckForExistingInstance()
p1:
        If Not args.Count = 0 Then SqlConParmFile = Application.StartupPath & "\vault\" & args(0)
        clsconnection = New NrgSqlConnection.ClsConnection(SqlConParmFile, CryptKey)
        Kefdal = clsconnection.GetDataLayer(AutoCreateOption.DatabaseAndSchema)
        If Kefdal Is Nothing Then
            If MsgBox("Το αρχείο Παραμετρών συνδεσης με το Sql Δέν Υπάρχει Θέλετε να το Ρυθμησετε τώρα", vbYesNo) = vbYes Then
                clsconnection.ShowFrmSqlDetail()
                GoTo p1
            End If
        End If
        Debug.Print(" Encoding.Default.EncodingName=" & Encoding.Default.EncodingName)
        Debug.Print(" Encoding.Default.CodePage=" & Encoding.Default.CodePage)




        Dim ses As Session = New Session(Kefdal)
        Dim PosCnfgCollection As XPCollection(Of PosCnfg) = New XPCollection(Of PosCnfg)(ses)
        poscnfg = PosCnfgCollection(0)
        Application.Run(New FrmStart)
    End Sub
    Public Sub CheckForExistingInstance()
        'Get number of processes of you program
        If Process.GetProcessesByName _
          (Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("Η Εφαρμογή Εκτελείται", "Απαγορεύονται πολλαπλά Στιγμιότυπα!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
            Application.Exit()
        End If
    End Sub

    Public Function TestClonePrinter()
        Dim ord As PosOrder
        Dim ses As Session = New Session(Kefdal)
        ord = ses.GetObjectByKey(Of PosOrder)(78581)
        Dim OrderClonePrinters As IEnumerable(Of String) = ord.PosOrderLines.Where(Function(b) b.ClonePrinter <> "null").Select(Function(c) c.ClonePrinter).Distinct
        For Each oClonePrinter As String In OrderClonePrinters
            Debug.Print("ClonePrinter=" & oClonePrinter)

        Next

        End
    End Function

End Module
