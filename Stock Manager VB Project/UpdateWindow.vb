Imports System.Data.SqlClient
Public Class UpdateWindow
    Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, Connexion)

        Connexion.Open()

        command.ExecuteNonQuery()

        Connexion.Close()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If String.IsNullOrEmpty(TextBox2.Text) Or (TextBox3.Text) Or (TextBox4.Text) Then
        'Label6.Visible = True
        'Else
        If (TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "") Then
            Label6.Visible = True
        Else
            Dim updateQuery As String = "Update produit Set nom_produit = '" & TextBox2.Text & "' ,prix_unitaire = '" & TextBox3.Text & "',quantite = " & TextBox4.Text & " WHERE id_produit =" & TextBox1.Text & ""
            ExecuteQuery(updateQuery)
            '  MessageBox.Show("Les données du produit sont modifiées")
            Me.Close()
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class