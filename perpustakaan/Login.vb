Public Class Login

    Public Shared Perpustakaan As Perpustakaan
    Public Shared Users As Users
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Perpustakaan = New Perpustakaan()
        Users = New Users()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = txtUsername.Text
        Dim plainPassword As String = txtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSUname = data_user(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

        'Tanpa Database
        'Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)

        'If AuthStatus Then
        '    Perpustakaan.Show()
        'End If

        'Try
        '    If AuthStatus = False Then
        '        Throw New System.Exception()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Username atau Password Salah")
        'End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Register.Show()

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        txtPassword.PasswordChar = "*"c
    End Sub
End Class