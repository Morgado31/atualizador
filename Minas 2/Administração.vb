Imports MySql.Data.MySqlClient

Public Class Administração

    Private Sub AtualizarQuantidades()

        Using connection As New MySqlConnection(connString)

            Dim queryPedra As String = "SELECT SUM(Pedra) FROM Logs"
            Dim queryAreia As String = "SELECT SUM(Areia) FROM Logs"
            Dim queryCarvão As String = "SELECT SUM(Carvão) FROM Logs"
            Dim queryMinério As String = "SELECT SUM(Minério) FROM Logs"
            Dim queryNiquel As String = "SELECT SUM(Níquel) FROM Logs"
            Dim queryEnxofre As String = "SELECT SUM(Enxofre) FROM Logs"
            Dim queryFerro As String = "SELECT SUM(Ferro) FROM Logs"
            Dim queryPrata As String = "SELECT SUM(Prata) FROM Logs"
            Dim queryCobre As String = "SELECT SUM(Cobre) FROM Logs"
            Dim queryVidro As String = "SELECT SUM(Vidro) FROM Logs"
            Dim queryPolvora As String = "SELECT SUM(Polvora) FROM Logs"
            Dim queryBorracha As String = "SELECT SUM(Borracha) FROM Logs"
            Dim queryParafusos As String = "SELECT SUM(Parafusos) FROM Logs"

            connection.Open()

            Using Command As New MySqlCommand(queryPedra, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtPedra.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryAreia, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtAreia.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryCarvão, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtCarvão.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryMinério, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtMinério.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryNiquel, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtNiquel.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryEnxofre, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtEnxofre.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryFerro, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtFerro.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryPrata, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtPrata.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryCobre, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtCobre.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryVidro, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtVidro.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryPolvora, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtPolvora.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryBorracha, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtBorracha.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryParafusos, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtParafusos.Text = resultado

            End Using

        End Using

    End Sub

    Private Sub Administração_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarQuantidades()
        txtPedra.Enabled = False : txtAreia.Enabled = False : txtCarvão.Enabled = False : txtMinério.Enabled = False : txtNiquel.Enabled = False : txtEnxofre.Enabled = False : txtFerro.Enabled = False : txtPrata.Enabled = False : txtCobre.Enabled = False : txtVidro.Enabled = False : txtPolvora.Enabled = False : txtBorracha.Enabled = False : txtParafusos.Enabled = False
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        AtualizarQuantidades()
    End Sub

    Private Sub btnGravarEquipa_Click(sender As Object, e As EventArgs) Handles btnGravarEquipa.Click

        Dim equipa As String = txtEquipa.Text

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim query As String = "INSERT INTO `Equipas` (`Equipa`) VALUES (@value1)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", equipa)
                command.ExecuteNonQuery()

            End Using

        End Using

        txtEquipa.Text = ""

    End Sub

End Class