Imports System.Data.SqlClient
Public Class AddWindow




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "") Then
            Label6.Visible = True
        Else

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
        End If
    End Sub

    Private Sub AddWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class