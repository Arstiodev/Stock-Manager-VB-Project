Imports System.Data.SqlClient
Public Class Stock
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connexion to sql
        Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")

        Connexion.Open()

        Dim Requete As String = "select * from produit"
        Dim Command As New SqlCommand(Requete, Connexion)
        Dim Adapter As New SqlDataAdapter(Command)
        Dim MondataSet As New DataSet

        Adapter.Fill(MondataSet, "produit")
        DataGridView1.DataSource = MondataSet.Tables("produit")
        Command.Dispose()
        Connexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddWindow.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdateWindow.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteWindow.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")

        Connexion.Open()

        Dim Requete As String = "select * from produit"
        Dim Command As New SqlCommand(Requete, Connexion)
        Dim Adapter As New SqlDataAdapter(Command)
        Dim MondataSet As New DataSet

        Adapter.Fill(MondataSet, "produit")
        DataGridView1.DataSource = MondataSet.Tables("produit")
        Command.Dispose()
        Connexion.Close()
    End Sub
End Class
