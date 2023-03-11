
Imports MySql.Data.MySqlClient


Public Class Form1

    'Definição das variaveis para todos os Private Subs

    Private outputDinheiro, outputCobre, outputFerro, outputPrata, outputVidro, outputNíquel, outputEnxofre As Integer
    Private inputPedra, inputAreia, inputMinério As String
    Public Property Equipas As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Introdução das equipas no seletorEquipas

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Equipa FROM Equipas"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    SeletorEquipas.Items.Add(reader.GetString("Equipa"))

                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            Try

                Dim query2 As String = "SELECT Equipas FROM Parcerias"
                Dim command2 As New MySqlCommand(query2, Connection)
                Dim reader2 As MySqlDataReader = command2.ExecuteReader()

                While reader2.Read()

                    SeletorEquipas.Items.Add(reader2.GetString("Equipas"))

                End While

                reader2.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            'Colocação em ordem alfabética

            Dim items As String() = SeletorEquipas.Items.Cast(Of String)().ToArray()
            Array.Sort(items)
            SeletorEquipas.Items.Clear()
            SeletorEquipas.Items.AddRange(items)

        End Using

    End Sub

    Private Sub btnProcessar_Click(sender As Object, e As EventArgs) Handles btnProcessar.Click

        'Definição dos valores de Pedra e Areia

        inputPedra = txtPedra.Text
        inputAreia = txtAreia.Text
        inputMinério = txtMinério.Text

        'Condição para não dar input na pedra ou areia

        If String.IsNullOrEmpty(txtPedra.Text) Then
            inputPedra = 0
        End If

        If String.IsNullOrEmpty(txtAreia.Text) Then
            inputAreia = 0
        End If

        If String.IsNullOrEmpty(txtMinério.Text) Then
            inputMinério = 0
        End If

        If String.IsNullOrEmpty(SeletorEquipas.SelectedItem) Then
            MessageBox.Show("Introduzir equipa")
            Exit Sub
        End If

        'Condição para só dar input de números

        If IsNumeric(inputAreia) = False Or IsNumeric(inputPedra) = False Or IsNumeric(inputMinério) = False Then
            MessageBox.Show("Introduzir só números")
            txtPedra.Text = 0
            txtAreia.Text = 0
            txtMinério.Text = 0
            Exit Sub
        End If

        'Calculo dos materiais 

        outputFerro = inputPedra '/ 3.12
        outputCobre = inputPedra / 5.72
        outputPrata = inputPedra / 8.3
        outputVidro = inputAreia / 3.2
        outputEnxofre = inputMinério * 0.67
        outputNíquel = inputMinério * 0.63

        'Condições das checkboxs para não levantar (True)

        Dim parcelaFerro, parcelaCobre, parcelaPrata, parcelaVidro As Integer

        If checkFerro.Checked = True Then
            parcelaFerro = 0
        Else
            parcelaFerro = outputFerro
        End If

        If checkCobre.Checked = True Then
            parcelaCobre = 0
        Else
            parcelaCobre = outputCobre
        End If

        If checkPrata.Checked = True Then
            parcelaPrata = 0
        Else
            parcelaPrata = outputPrata
        End If

        If checkVidro.Checked = True Then
            parcelaVidro = 0
        Else
            parcelaVidro = outputVidro
        End If

        'Calculo do dinheiro

        If SeletorEquipas.SelectedItem = "Minas" Then 'Sem equipa
            outputDinheiro = parcelaFerro * 70 + parcelaCobre * 90 + parcelaPrata * 120 + parcelaVidro * 85 - ((inputPedra * 40) + (inputAreia * 5))
        Else 'Com equipa
            outputDinheiro = parcelaFerro * 65 + parcelaCobre * 80 + parcelaPrata * 100 + parcelaVidro * 60 - ((inputPedra * 40) + (inputAreia * 5))
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try 'Parcerias (Pagam 0)

                Dim query As String = "SELECT COUNT(*) FROM Parcerias WHERE Equipas = @equipa"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@equipa", SeletorEquipas.Text)

                Dim count As Integer = 0
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    count = Convert.ToInt32(result)
                End If

                If count > 0 Then
                    outputDinheiro = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        'Cor do display do dinheiro

        If outputDinheiro > 0 Then
            txtAvisoValor.Text = "Passar Fatura"
            txtAvisoValor.ForeColor = Color.Green
        Else
            txtAvisoValor.Text = "Pagar"
            txtAvisoValor.ForeColor = Color.Red
        End If

        If outputDinheiro = 0 Then
            txtAvisoValor.Text = "Parceria"
            txtAvisoValor.ForeColor = Color.SteelBlue
        End If

        If inputAreia = 0 AndAlso inputPedra = 0 Then
            txtAvisoValor.Text = ""
        End If

        'Display dos valores

        txtCobre.Text = outputCobre
        txtFerro.Text = outputFerro
        txtPrata.Text = outputPrata
        txtVidro.Text = outputVidro
        txtNíquel.Text = outputNíquel
        txtEnxofre.Text = outputEnxofre
        txtDinheiro.Text = Math.Abs(outputDinheiro)


    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        'Condição para ser obrigatorio defenir o cliente e equipa

        If String.IsNullOrEmpty(txtCliente.Text) Then
            MessageBox.Show("Introduzir cliente")
            Exit Sub
        End If

        If String.IsNullOrEmpty(SeletorEquipas.SelectedItem) Then
            MessageBox.Show("Introduzir equipa")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Confirmas que está tudo correto e entregas-te os materiais?" & vbCrLf & "Olha que o Scorpion vai atrás de ti!", "Confirmação", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            MessageBox.Show("Operação Registada")
        Else
            Exit Sub
        End If

        'Defenição das variaveis para serem introduzidas na database

        Dim inputCliente As String = txtCliente.Text
        Dim inputEquipa As String = SeletorEquipas.SelectedItem.ToString()
        Dim outputPagamento As Integer
        Dim data As String = DateAndTime.Now

        'Conexão á database

        Dim quary As String = "INSERT INTO `Processo Pedra e Areia` (`Pedra`, `Areia`, `Trabalhador`, `Equipa`, `Cliente`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Pagamento`, `Data`, `Minério`, `Níquel`, `Enxofre`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13,@value14)"
        Dim quaryStock As String = "INSERT INTO `Stocks` (`Equipa`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Cliente`, `Data`, `Trabalhador`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"

        'Registo dos valores na tabela de Processo Legal

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Using command As New MySqlCommand(quary, connection)
                Dim commandStock As New MySqlCommand(quaryStock, connection)

                command.Parameters.AddWithValue("@value1", inputPedra)
                command.Parameters.AddWithValue("@value2", inputAreia)
                command.Parameters.AddWithValue("@value3", MVariables.outputTrabalhador)
                command.Parameters.AddWithValue("@value4", inputEquipa)
                command.Parameters.AddWithValue("@value5", inputCliente)
                commandStock.Parameters.AddWithValue("@value1", inputEquipa)

                If checkFerro.Checked Then
                    command.Parameters.AddWithValue("@value6", -outputFerro)
                    commandStock.Parameters.AddWithValue("@value2", outputFerro)
                Else
                    command.Parameters.AddWithValue("@value6", outputFerro)
                    commandStock.Parameters.AddWithValue("@value2", 0)
                End If

                If checkPrata.Checked Then
                    command.Parameters.AddWithValue("@value7", -outputPrata)
                    commandStock.Parameters.AddWithValue("@value3", outputPrata)
                Else
                    command.Parameters.AddWithValue("@value7", outputPrata)
                    commandStock.Parameters.AddWithValue("@value3", 0)
                End If

                If checkCobre.Checked Then
                    command.Parameters.AddWithValue("@value8", -outputCobre)
                    commandStock.Parameters.AddWithValue("@value4", outputCobre)
                Else
                    command.Parameters.AddWithValue("@value8", outputCobre)
                    commandStock.Parameters.AddWithValue("@value4", 0)
                End If

                If checkVidro.Checked Then
                    command.Parameters.AddWithValue("@value9", -outputVidro)
                    commandStock.Parameters.AddWithValue("@value5", outputVidro)
                Else
                    command.Parameters.AddWithValue("@value9", outputVidro)
                    commandStock.Parameters.AddWithValue("@value5", 0)
                End If

                If outputDinheiro >= 0 Then
                    command.Parameters.AddWithValue("@value10", 0)
                Else
                    outputPagamento = Math.Abs(outputDinheiro)
                    command.Parameters.AddWithValue("@value10", outputPagamento)
                End If

                command.Parameters.AddWithValue("@value11", data)
                command.Parameters.AddWithValue("@value12", inputMinério)
                command.Parameters.AddWithValue("@value13", outputNíquel)
                command.Parameters.AddWithValue("@value14", outputEnxofre)

                command.ExecuteNonQuery()

                If commandStock.Parameters("@value2").Value <> 0 OrElse commandStock.Parameters("@value3").Value <> 0 OrElse commandStock.Parameters("@value4").Value <> 0 OrElse commandStock.Parameters("@value5").Value <> 0 Then
                    commandStock.Parameters.AddWithValue("@value6", inputCliente)
                    commandStock.Parameters.AddWithValue("@value7", data)
                    commandStock.Parameters.AddWithValue("@value8", MVariables.outputTrabalhador)
                    commandStock.ExecuteNonQuery()
                End If

            End Using

        End Using

        'Reset da app

        txtPedra.Text = ""
        txtAreia.Text = ""
        txtMinério.Text = ""
        txtCliente.Text = ""
        checkCobre.Checked = False
        checkFerro.Checked = False
        checkPrata.Checked = False
        checkVidro.Checked = False
        btnProcessar.PerformClick()
        SeletorEquipas.SelectedIndex = -1
        txtAvisoValor.Text = ""

    End Sub

    Private Sub seletorMenus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seletorMenus.SelectedIndexChanged

        ' Mudar menus

        Dim selectedMenu As String = seletorMenus.SelectedItem.ToString()

        Select Case selectedMenu

            Case "Consultar Stocks"
                Dim formA As New Gestão_Stock()
                formA.Show()
                Me.Hide()
        End Select

    End Sub

    Private Sub checkFerro_CheckedChanged(sender As Object, e As EventArgs) Handles checkFerro.CheckedChanged
        btnProcessar.PerformClick()
    End Sub

    Private Sub checkPrata_CheckedChanged(sender As Object, e As EventArgs) Handles checkPrata.CheckedChanged
        btnProcessar.PerformClick()
    End Sub

    Private Sub checkCobre_CheckedChanged(sender As Object, e As EventArgs) Handles checkCobre.CheckedChanged
        btnProcessar.PerformClick()
    End Sub

    Private Sub checkVidro_CheckedChanged(sender As Object, e As EventArgs) Handles checkVidro.CheckedChanged
        btnProcessar.PerformClick()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class