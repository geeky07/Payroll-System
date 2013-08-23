Public Class Loginform1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.CompareTo("administrator") = 0 And PasswordTextBox.Text.CompareTo("keerath123") = 0 Then
            MsgBox("Access Granted", 0, "Authentication Successful")
            Form1.Show()
        ElseIf UsernameTextBox.Text.CompareTo("user") = 0 And PasswordTextBox.Text.CompareTo("user") = 0 Then
            MsgBox("Access Granted", 0, "Authentication Successful")
            Form1.Show()
        Else
            MsgBox("Please Check your Username and Password")
        End If


        Me.Hide()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PasswordLabel_Click(sender As System.Object, e As System.EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
