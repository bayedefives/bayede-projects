Public Class Form1
    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        lblMessage.Text = "Hello, World! My name is Bayde Mthethwa" & vbCrLf & "This is my first Visual Basic program."
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to close the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = " "
        lblStatus.Text = "Message cleared."
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("This program was created by Bayde Mthethwa as a simple demonstration of Visual Basic programming.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
