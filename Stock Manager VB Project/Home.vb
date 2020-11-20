Imports System.Data.SqlClient
Public Class Home
    Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command1 As New SqlCommand("select count(id_produit) from produit", Connexion)

        Connexion.Open()

        Label1.Text = command1.ExecuteScalar().ToString()
        Console.WriteLine(command1.ExecuteScalar().ToString())
        Connexion.Close()

        'Dim command2 As New SqlCommand("select count(id_client) from client", Connexion)

        '  Connexion.Open()

        ' Label2.Text = command2.ExecuteScalar().ToString()
        ' Console.WriteLine(command2.ExecuteScalar().ToString())
        ' Connexion.Close()

        Dim command3 As New SqlCommand("select count(id_achat) from achats", Connexion)

        Connexion.Open()

        Label3.Text = command3.ExecuteScalar().ToString()
        Console.WriteLine(command3.ExecuteScalar().ToString())
        Connexion.Close()
    End Sub




End Class
