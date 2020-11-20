Imports System.Data.SqlClient
Public Class DeleteWindow
    Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")



    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, Connexion)

        Connexion.Open()

        command.ExecuteNonQuery()

        Connexion.Close()

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New SqlCommand("select * from produit where id_produit = " & TextBox1.Text & "", Connexion)

        ' command.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text'

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        If table.Rows.Count() > 0 Then

            ' return only 1 row
            TextBox2.Text = table.Rows(0)(1).ToString()
            TextBox3.Text = table.Rows(0)(2).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()

        Else

            MessageBox.Show("Ce produit n'existe pas")

        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updateQuery As String = "Delete from produit where id_produit = " & TextBox1.Text
        ExecuteQuery(updateQuery)
        MessageBox.Show("Le produit est supprimé")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class