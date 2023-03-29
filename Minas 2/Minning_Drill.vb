Imports MySql.Data.MySqlClient

Public Class Minning_Drill

    Dim mEquipa As Integer = 45000
    Dim mUsada As Integer
    Dim Fatura As Integer
    Dim QuantidadeVendida As Integer
    Dim Pagar As Integer
    Dim QuantidadeComprada As String
    Dim QuantidadeUsadas As String

    Private Sub Minning_Drill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFatura.Text = "Fatura : " & 45000

        txtQuantidadeUsada.Enabled = False
        txtComprar.Enabled = False

        AtualizarQuantidade()
    End Sub

    Private Sub checkEquipa_CheckedChanged(sender As Object, e As EventArgs) Handles checkEquipa.CheckedChanged

        If checkEquipa.Checked = True Then
            mEquipa = 35000
        Else
            mEquipa = 45000
        End If

        CalcularFatura()
        AtualizarQuantidade()
    End Sub

    Private Sub checkUsada_CheckedChanged(sender As Object, e As EventArgs) Handles checkUsada.CheckedChanged

        If checkUsada.Checked = True Then

            txtQuantidadeUsada.Enabled = True

        Else

            txtQuantidadeUsada.Enabled = False

        End If

        txtQuantidadeUsada.Text = ""

        CalcularFatura()
        AtualizarQuantidade()
    End Sub

    Private Sub checkComprar_CheckedChanged(sender As Object, e As EventArgs) Handles checkComprar.CheckedChanged

        If checkComprar.Checked = True Then

            txtComprar.Enabled = True

        Else

            txtComprar.Enabled = False

        End If

        txtComprar.Text = ""

        CalcularFatura()
        AtualizarQuantidade()
    End Sub

    Private Sub CalcularFatura()

        QuantidadeUsadas = txtQuantidadeUsada.Text
        QuantidadeComprada = txtComprar.Text

        If String.IsNullOrWhiteSpace(txtQuantidadeUsada.Text) Then
            QuantidadeUsadas = 0
        End If

        If String.IsNullOrWhiteSpace(txtComprar.Text) Then
            QuantidadeComprada = 0
        End If

        If checkUsada.Checked = False Then
            QuantidadeUsadas = 0
        End If

        If checkComprar.Checked = False Then
            QuantidadeComprada = 0
        End If

        mUsada = 7500 * QuantidadeUsadas

        Fatura = mEquipa - mUsada

        lblFatura.Text = "Fatura : " & Fatura

        If checkComprar.Checked = True Then

            checkEquipa.Checked = False
            checkUsada.Checked = False

            Pagar = 7500 * QuantidadeComprada
            lblFatura.Text = "Tens de Pagar : " & Pagar

        End If

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

        If QuantidadeVendida = 10 Then
            Exit Sub
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Data As String = DateAndTime.Now
            Dim query As String = "INSERT INTO `Minning Drill` (`Trabalhador`, `Data`, `Drill's Usadas`) VALUES (@value1,@value2,@value3)"
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Borracha`, `Parafusos`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using Command As New MySqlCommand(query, connection)
                Dim commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)

                Command.Parameters.AddWithValue("@value1", outputTrabalhador)
                Command.Parameters.AddWithValue("@value2", Date.Today)
                Command.Parameters.AddWithValue("@value3", QuantidadeUsadas)

                Command.ExecuteNonQuery()

                commandLogsRoloute.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value2", -90)
                commandLogsRoloute.Parameters.AddWithValue("@value3", -15)
                commandLogsRoloute.Parameters.AddWithValue("@value4", -30)
                commandLogsRoloute.Parameters.AddWithValue("@value5", -5)
                commandLogsRoloute.Parameters.AddWithValue("@value6", "Roloute")
                commandLogsRoloute.Parameters.AddWithValue("@value7", Data)
                commandLogsRoloute.ExecuteNonQuery()

            End Using

        End Using
        AtualizarQuantidade()
        checkEquipa.Checked = False
        checkUsada.Checked = False
        MessageBox.Show("Vendes-te uma Drill")
    End Sub

    Private Sub txtQuantidadeUsada_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidadeUsada.TextChanged

        Dim Quantidade As String

        If String.IsNullOrWhiteSpace(txtQuantidadeUsada.Text) Then
            Quantidade = 0
        Else
            Quantidade = txtQuantidadeUsada.Text
        End If

        If checkEquipa.Checked = True Then

            If Quantidade > 4 Then

                MessageBox.Show("Só podes aceitar no máximo 4 Drill's")
                txtQuantidadeUsada.Text = ""
                Exit Sub

            End If

        Else

            If Quantidade > 6 Then

                MessageBox.Show("Só podes aceitar no máximo 6 Drill's")
                txtQuantidadeUsada.Text = ""
                Exit Sub

            End If

        End If

        CalcularFatura()
    End Sub

    Private Sub txtComprar_TextChanged(sender As Object, e As EventArgs) Handles txtComprar.TextChanged
        CalcularFatura()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        If checkComprar.Checked = False Then
            Exit Sub
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim query As String = "INSERT INTO `Minning Drill` (`Trabalhador`, `Data`, `Drill's Compradas`, `Pagamento`) VALUES (@value1,@value2,@value3,@value4)"

            Using Command As New MySqlCommand(query, connection)

                Command.Parameters.AddWithValue("@value1", outputTrabalhador)
                Command.Parameters.AddWithValue("@value2", DateAndTime.DateString)
                Command.Parameters.AddWithValue("@value3", QuantidadeComprada)
                Command.Parameters.AddWithValue("@value4", Pagar)

                Command.ExecuteNonQuery()

            End Using

        End Using
        AtualizarQuantidade()
        checkComprar.Checked = False
        MessageBox.Show("Compra registada!")

    End Sub
End Class