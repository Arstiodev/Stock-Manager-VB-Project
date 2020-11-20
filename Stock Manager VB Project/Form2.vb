
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 60
        Timer1.Start()

    End Sub

    Private Sub TableuDuBordButton_Click(sender As Object, e As EventArgs) Handles TableuDuBordButton.Click
        '==> Dashboard Button
        'View Managements
        Home1.Visible = True
        Achat1.Visible = False
        Stock1.Visible = False
        'label change
        Label2.Text = "Tableau de bord"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '==> Achat Button
        'View Managements
        Home1.Visible = False
        Achat1.Visible = True
        Stock1.Visible = False
        Label2.Text = "Nouvel achat"
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '==> Stock Button 
        'View Managements
        Home1.Visible = False
        Achat1.Visible = False
        Stock1.Visible = True
        Label2.Text = "Gestion de stock"








    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left -= 4
    End Sub

    Private Sub Label1_LocationChanged(sender As Object, e As EventArgs) Handles Label1.LocationChanged

        If Label1.Left <= -530 Then


            Label1.Left = 700
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Stock1_Load(sender As Object, e As EventArgs) Handles Stock1.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Clients"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class