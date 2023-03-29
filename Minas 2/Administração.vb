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

    Private Sub btnGravarLogs_Click(sender As Object, e As EventArgs) Handles btnGravarLogs.Click

        Dim Materias As String = seletorMaterial.SelectedItem.ToString
        Dim quantidade As String = txtQuantidade.Text
        Dim data As String = DateAndTime.Now

        Using connection As New MySqlConnection(connString)

            Dim query As String = "INSERT INTO `Logs` (`Trabalhador`, `" & Materias & "`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", quantidade)

                If Materias = "Pedra" Or Materias = "Areia" Or Materias = "Carvão" Or Materias = "Minério" Or Materias = "Níquel" Or Materias = "Enxofre" Then
                    command.Parameters.AddWithValue("@value3", "Contentor")
                Else
                    command.Parameters.AddWithValue("@value3", "Roloute")
                End If

                command.Parameters.AddWithValue("@value4", data)

                command.ExecuteNonQuery()
            End Using

        End Using

        txtQuantidade.Text = ""
        seletorMaterial.SelectedItem = -1

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