Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If uname.Text = "" Or password.Text = "" Then
            MsgBox("Please Enter Username and Password")
        ElseIf uname.Text = "Admin" And password.Text = "password" Then
            Dim obj = New Items
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            uname.Text = ""
            password.Text = ""
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim obj = New Orders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class
