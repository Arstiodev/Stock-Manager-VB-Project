Imports System.Data.SqlClient
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky; User Id=hajar;Password=Hajar123;")
        Try
            Connexion.Open()
            Dim requete1 As String = "insert into produit (id_produit,nom_produit,prix_unitaire,quantite) values (" & Me.TextBox1.Text & " , '" & Me.TextBox2.Text & "' , " & Me.TextBox3.Text & "," & Me.TextBox4.Text & " )"
            Dim commande1 As New SqlCommand(requete1, Connexion)
            Try
                Console.WriteLine("Il y a eu " & commande1.ExecuteNonQuery() & "lignes mises à jour")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            commande1.Dispose()
            Connexion.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class