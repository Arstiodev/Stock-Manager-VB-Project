Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.UseSystemPasswordChar = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Visible = False
    End Sub


    Private Sub Panel6_MouseEnter(sender As Object, e As EventArgs) Handles Panel6.MouseEnter
        Panel6.BackColor = Color.SteelBlue
    End Sub

    Private Sub Panel6_MouseLeave(sender As Object, e As EventArgs) Handles Panel6.MouseLeave
        Panel6.BackColor = Color.Transparent
    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        Close()
    End Sub
End Class
