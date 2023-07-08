Imports DevExpress.Xpo
Imports WaiterModel.Cmp300
Imports WindowsApplication1.Cmp300

Public Class FormLogon
    Dim ses As Session
    Dim AlternativeLoggon As Boolean = False
    Private _GetUser As MyUsers
    Public Event Logon(LogUser As MyUsers)
    Public Property GetUser() As MyUsers
        Get
            Return _GetUser
        End Get
        Set(ByVal value As MyUsers)
            _GetUser = value
        End Set
    End Property



    Public Sub New()
        InitializeComponent()
        ses = New Session(Kefdal)
        SubsIdCollection.Session = ses
        XpCollection1.Session = ses
        CmbCompany.EditValue = SubsIdCollection(0)
        Me.Text = Application.ProductVersion
    End Sub
    Public Sub New(_AlternativeLoggon As Boolean, odal As IDataLayer)
        InitializeComponent()
        ses = New Session(odal)
        SubsIdCollection.Session = ses
        XpCollection1.Session = ses
        CmbCompany.EditValue = SubsIdCollection(0)
        Me.Text = Application.ProductVersion
        AlternativeLoggon = _AlternativeLoggon
    End Sub



    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If AlternativeLoggon = True Then
            GetUser = Nothing
            Me.Close()
        Else
            End
            Me.Dispose()
        End If

    End Sub

    Private Sub TextEdit1_Click(sender As Object, e As EventArgs) Handles TextEdit1.Click
        'Try
        '    Dim f As MyNumPad = New MyNumPad
        '    If f.NumPadValue = vbNull Then
        '        TextEdit1.Text = ""
        '    Else
        '        TextEdit1.Text = f.NumPadValue
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim _user As MyUsers = TryCast(CmbUsers.EditValue, MyUsers)
            If _user.Pass = TextEdit1.Text Then
                Me.Visible = False
                If AlternativeLoggon = True Then
                    GetUser = _user
                Else
                    RaiseEvent Logon(_user)
                    'LogonData.LogonUser = _user
                    'LogonData.LogonCompany = CmbCompany.EditValue
                    Me.Close()
                End If
            Else
                MsgBox("Λάθος Κωδικός Πρόσβασης")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormLogon_Load(sender As Object, e As EventArgs) Handles Me.Load
        CmbUsers.EditValue = (From c In XpCollection1).FirstOrDefault
    End Sub



End Class