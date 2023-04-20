Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Input
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
            Dim querySafiras As String = "SELECT SUM(Safiras) FROM Logs"

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

            Using Command As New MySqlCommand(querySafiras, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                txtSafiras.Text = resultado

            End Using

        End Using

    End Sub

    Private Sub Trabalhadores()

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Username FROM Login"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    selectorTrabalhador.Items.Add(reader.GetString("Username"))

                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            Dim items As String() = selectorTrabalhador.Items.Cast(Of String)().ToArray()
            Array.Sort(items)
            selectorTrabalhador.Items.Clear()
            selectorTrabalhador.Items.AddRange(items)

        End Using

    End Sub

    Private Sub Administração_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarQuantidades()
        Trabalhadores()
        txtPedra.Enabled = False : txtAreia.Enabled = False : txtCarvão.Enabled = False : txtMinério.Enabled = False : txtNiquel.Enabled = False : txtEnxofre.Enabled = False : txtFerro.Enabled = False : txtPrata.Enabled = False : txtCobre.Enabled = False : txtVidro.Enabled = False : txtPolvora.Enabled = False : txtBorracha.Enabled = False : txtParafusos.Enabled = False : txtSafiras.Enabled = False
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

    Private Sub ObterMontantePagamento()

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim quary As String = "SELECT Pagamento FROM Pagamentos WHERE Trabalhador = @Nome"
            Dim Trabalhador As String = selectorTrabalhador.SelectedItem.ToString()

            Using Command As New MySqlCommand(quary, connection)

                Command.Parameters.AddWithValue("@Nome", Trabalhador)

                Dim reader As MySqlDataReader = Command.ExecuteReader()

                Dim soma As Double = 0

                While reader.Read()
                    soma += CDbl(reader("Pagamento"))
                End While

                Dim Montante As Double = soma

                txtPagamento.Text = Montante
            End Using
        End Using

    End Sub
    Private Sub selectorTrabalhador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectorTrabalhador.SelectedIndexChanged
        ObterMontantePagamento()
    End Sub
    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click

        Dim Trabalhador As String = selectorTrabalhador.SelectedItem.ToString()
        Dim Montante As String = txtPagamento.Text
        Dim data As String = DateAndTime.Now

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim query As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", Trabalhador)
                command.Parameters.AddWithValue("@value2", -Montante)
                command.Parameters.AddWithValue("@value3", data)

                command.ExecuteNonQuery()

            End Using

        End Using
        ObterMontantePagamento()
    End Sub
End Class