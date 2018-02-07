Public Class LoginForm
    Dim userName As String
    Dim passWord As String

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

        If userName = "admin" And passWord = "password" Then
            Dim MainForm As New Form2
            Me.Hide()
            MainForm.ShowDialog()
        Else
            MessageBox.Show("WRONG CREDENTIALS..!")
        End If

    End Sub

    Private Sub Got_Input(sender As Object, e As EventArgs) Handles UsrNameTxtBox.TextChanged, PswdTxtBox.TextChanged
        userName = UsrNameTxtBox.Text
        passWord = PswdTxtBox.Text
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
