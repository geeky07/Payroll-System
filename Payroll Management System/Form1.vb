Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val As Integer
        val = ComboBox1.Text.CompareTo("Run Payroll")
        If val = 0 Then
            Form4.Show()
            Me.Hide()
        End If
        val = ComboBox1.Text.CompareTo("Employee Details")
        If val = 0 Then
            Form3.show()
            Me.Hide()
        End If
        val = ComboBox1.Text.CompareTo("Database View")
        If val = 0 Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
