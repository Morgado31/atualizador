Imports MySql.Data.MySqlClient

Public Class Minning_Drill

    Dim mEquipa As Integer = 45000
    Dim mUsada As Integer
    Dim Fatura As Integer
    Dim QuantidadeVendida As Integer

    Private Sub Minning_Drill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFatura.Text = "Fatura : " & 45000

        AtualizarQuantidade()
    End Sub

    Private Sub checkEquipa_CheckedChanged(sender As Object, e As EventArgs) Handles checkEquipa.CheckedChanged

        If checkEquipa.Checked = True Then
            mEquipa = 35000
        Else
            mEquipa = 45000
        End If

        Fatura = mEquipa - mUsada
        lblFatura.Text = "Fatura : " & Fatura

        AtualizarQuantidade()
    End Sub

    Private Sub checkUsada_CheckedChanged(sender As Object, e As EventArgs) Handles checkUsada.CheckedChanged

        If checkUsada.Checked = True Then
            mUsada = 7500
        Else
            mUsada = 0
        End If

        Fatura = mEquipa - mUsada
        lblFatura.Text = "Fatura : " & Fatura

        AtualizarQuantidade()
    End Sub

    Private Sub VerificarDatas()

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM `Minning Drill` WHERE Data = @data"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("data", Date.Today)
                QuantidadeVendida = command.ExecuteScalar()

            End Using
        End Using
    End Sub

    Private Sub AtualizarQuantidade()

        VerificarDatas()
        lblQuantidade.Text = "Ainda se pode vender " & 10 - QuantidadeVendida & " Drill's"

        If QuantidadeVendida = 10 Then
            btnVender.Enabled = False
            lblQuantidade.Text = "Já não se pode vender Drill's"
        Else
            btnVender.Enabled = True
        End If

    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim query As String = "INSERT INTO `Minning Drill` (`Trabalhador`, `Data`) VALUES (@value1,@value2)"

            Using Command As New MySqlCommand(query, connection)

                Command.Parameters.AddWithValue("@value1", outputTrabalhador)
                Command.Parameters.AddWithValue("@value2", Date.Today)

                Command.ExecuteNonQuery()

            End Using

        End Using
        AtualizarQuantidade()
        checkEquipa.Checked = False
        checkUsada.Checked = False
        MessageBox.Show("Vendes-te uma Drill")
    End Sub
End Class