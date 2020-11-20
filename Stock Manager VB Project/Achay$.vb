Imports System.Data.SqlClient
Public Class Achat
    Dim Connexion As New SqlConnection("Data Source=localhost;Initial Catalog=projet_stocky;User Id=hajar;Password=Hajar123;")

    Dim cpt = 0


    Private Sub Achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim command As New SqlCommand("select * from produit", Connexion)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "nom_produit"
        ComboBox1.ValueMember = "id_produit"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim Command As New SqlCommand("select prix_unitaire from produit where nom_produit = @nom", Connexion)
        Command.Parameters.Add("@nom", SqlDbType.VarChar).Value = ComboBox1.Text

        Dim adapter As New SqlDataAdapter(Command)

        Dim table As New DataTable()

        adapter.Fill(table)

        Console.WriteLine("test")









        Command.Dispose()
        Connexion.Close()
        Me.DataGridView1.Rows.Add(ComboBox1.Text, table.Rows(0)(0).ToString, TextBox3.Text, (table.Rows(0)(0).ToString * TextBox3.Text))

        cpt += table.Rows(0)(0).ToString * TextBox3.Text

        TextBox2.Text = cpt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim requete1 As String = "insert into achats (id_achat,id_client,total) values (  102  ,104 , " & ComboBox1.Text & " )"

        Dim commande1 As New SqlCommand(requete1, Connexion)

        Connexion.Open()
        commande1.Dispose()
        Connexion.Close()


    End Sub
End Class
