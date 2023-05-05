
Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Processo_Legal

    'Definição das variaveis para todos os Private Subs

    Private outputDinheiro, outputCobre, outputFerro, outputPrata, outputVidro, outputNíquel, outputEnxofre, Salário As Integer
    Private Percentagem As Double
    Private inputPedra, inputAreia, inputMinério As String

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

            'Colocação em ordem alfabética

            Dim items As String() = SeletorEquipas.Items.Cast(Of String)().ToArray()
            Array.Sort(items)
            SeletorEquipas.Items.Clear()
            SeletorEquipas.Items.AddRange(items)

        End Using

        'Introduzir menus no seletor de menus

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Menus FROM Menus"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    seletorMenu.Items.Add(reader.GetString("Menus"))

                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End Using

        'Colocação em ordem alfabética

        Dim itemsmenu As String() = seletorMenu.Items.Cast(Of String)().ToArray()
        Array.Sort(itemsmenu)
        seletorMenu.Items.Clear()
        seletorMenu.Items.AddRange(itemsmenu)

    End Sub

    Private Sub btnDrill_Click(sender As Object, e As EventArgs) Handles btnDrill.Click

        If MVariables.outputTrabalhador = "morgado" Or MVariables.outputTrabalhador = "Jack" Or MVariables.outputTrabalhador = "Nilson" Or MVariables.outputTrabalhador = "marques" Or MVariables.outputTrabalhador = "techno" Then
            btnAdm.Visible = True
        Else
            btnAdm.Visible = False
        End If

        Dim formE As New Minning_Drill()
        formE.Show()

    End Sub

    Private Sub btnAdm_Click(sender As Object, e As EventArgs) Handles btnAdm.Click

        Dim formX As New Administração()
        formX.Show()

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
            txtPedra.Text = ""
            txtAreia.Text = ""
            txtMinério.Text = ""
            Exit Sub
        End If

        'Calculo dos materiais 

        outputFerro = inputPedra / 3.12
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
            outputDinheiro = parcelaFerro * 235 + parcelaCobre * 285 + parcelaPrata * 185 + parcelaVidro * 135 - ((inputPedra * 65) + (inputAreia * 10))
        Else 'Com equipa
            outputDinheiro = parcelaFerro * 185 + parcelaCobre * 235 + parcelaPrata * 135 + parcelaVidro * 110 - ((inputPedra * 80) + (inputAreia * 15))
        End If

        'Parcerias

        If SeletorEquipas.SelectedItem = "Sumiyoshi" Or SeletorEquipas.SelectedItem = "Yamaha" Then
            outputDinheiro = parcelaFerro * 155 + parcelaCobre * 205 + parcelaPrata * 105 + parcelaVidro * 80 - ((inputPedra * 80) + (inputAreia * 15))
        End If

        If SeletorEquipas.SelectedItem = "The Garrison" Or SeletorEquipas.SelectedItem = "AIMF" Then
            outputDinheiro = 0
        End If

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
    Private Sub CalcularSalário()

        If SeletorEquipas.SelectedItem = "Minas" Then
            Percentagem = 0.2 + (0.2 * Rnd())
            Salário = Math.Abs(outputDinheiro) * Percentagem
        Else
            Percentagem = 0.3 + (0.1 * Rnd())
            Salário = Math.Abs(outputDinheiro) * Percentagem
        End If

    End Sub
    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        CalcularSalário()

        'Condição para ser obrigatorio defenir o cliente e equipa

        If String.IsNullOrEmpty(txtCliente.Text) Then
            MessageBox.Show("Introduzir cliente")
            Exit Sub
        End If

        If String.IsNullOrEmpty(SeletorEquipas.SelectedItem) Then
            MessageBox.Show("Introduzir equipa")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtMinério.Text) = False Then
            If String.IsNullOrEmpty(txtTelemovel.Text) Then
                MessageBox.Show("Introduzir número de telemóvel")
                Exit Sub
            Else
                If IsNumeric(txtTelemovel.Text) = False Then
                    MessageBox.Show("Introduzir apenas números")
                    Exit Sub
                End If
            End If
        End If

        Dim result As DialogResult = MessageBox.Show("Confirmas que está tudo correto e entregas-te os materiais?" & vbCrLf & "Olha que o Scorpion vai atrás de ti!", "Confirmação", MessageBoxButtons.OKCancel)

        If result <> DialogResult.OK Then
            Exit Sub
        End If

        'Defenição das variaveis para serem introduzidas na database

        Dim inputCliente As String = txtCliente.Text
        Dim inputEquipa As String = SeletorEquipas.SelectedItem.ToString()
        Dim outputPagamento As Integer = Math.Abs(outputDinheiro)
        Dim data As String = DateAndTime.Now
        Dim Telemovel As String = txtTelemovel.Text

        'Conexão á database

        Dim quary As String = "INSERT INTO `Venda de Materiais` (`Pedra`, `Areia`, `Trabalhador`, `Equipa`, `Cliente`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Pagamento`, `Data`, `Minério`, `Níquel`, `Enxofre`, `Contacto`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13,@value14,@value15)"
        Dim quaryStock As String = "INSERT INTO `Stocks` (`Equipa`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Cliente`, `Data`, `Trabalhador`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
        Dim quaryLogsContentor As String = "INSERT INTO `Logs` (`Pedra`, `Areia`, `Trabalhador`, `Minério`, `Níquel`, `Enxofre`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
        Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"
        Dim quaryPagamentos As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"
        Dim quarySalários As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"

        'Registo dos valores na tabela de Venda de Materiais

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Using command As New MySqlCommand(quary, connection)
                Dim commandStock As New MySqlCommand(quaryStock, connection)
                Dim commandLogsContentor As New MySqlCommand(quaryLogsContentor, connection)
                Dim commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)
                Dim commandPagamentos As New MySqlCommand(quaryPagamentos, connection)

                command.Parameters.AddWithValue("@value1", inputPedra)
                commandLogsContentor.Parameters.AddWithValue("@value1", inputPedra)

                command.Parameters.AddWithValue("@value2", inputAreia)
                commandLogsContentor.Parameters.AddWithValue("@value2", inputAreia)

                command.Parameters.AddWithValue("@value3", MVariables.outputTrabalhador)
                commandLogsContentor.Parameters.AddWithValue("@value3", MVariables.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)

                command.Parameters.AddWithValue("@value4", inputEquipa)
                command.Parameters.AddWithValue("@value5", inputCliente)
                commandStock.Parameters.AddWithValue("@value1", inputEquipa)

                If checkFerro.Checked Then
                    command.Parameters.AddWithValue("@value6", -outputFerro)
                    commandStock.Parameters.AddWithValue("@value2", outputFerro)
                    commandLogsRoloute.Parameters.AddWithValue("@value2", 0)
                Else
                    command.Parameters.AddWithValue("@value6", outputFerro)
                    commandStock.Parameters.AddWithValue("@value2", 0)
                    commandLogsRoloute.Parameters.AddWithValue("@value2", -outputFerro)
                End If

                If checkPrata.Checked Then
                    command.Parameters.AddWithValue("@value7", -outputPrata)
                    commandStock.Parameters.AddWithValue("@value3", outputPrata)
                    commandLogsRoloute.Parameters.AddWithValue("@value3", 0)
                Else
                    command.Parameters.AddWithValue("@value7", outputPrata)
                    commandStock.Parameters.AddWithValue("@value3", 0)
                    commandLogsRoloute.Parameters.AddWithValue("@value3", -outputPrata)
                End If

                If checkCobre.Checked Then
                    command.Parameters.AddWithValue("@value8", -outputCobre)
                    commandStock.Parameters.AddWithValue("@value4", outputCobre)
                    commandLogsRoloute.Parameters.AddWithValue("@value4", 0)
                Else
                    command.Parameters.AddWithValue("@value8", outputCobre)
                    commandStock.Parameters.AddWithValue("@value4", 0)
                    commandLogsRoloute.Parameters.AddWithValue("@value4", -outputCobre)
                End If

                If checkVidro.Checked Then
                    command.Parameters.AddWithValue("@value9", -outputVidro)
                    commandStock.Parameters.AddWithValue("@value5", outputVidro)
                    commandLogsRoloute.Parameters.AddWithValue("@value5", 0)
                Else
                    command.Parameters.AddWithValue("@value9", outputVidro)
                    commandStock.Parameters.AddWithValue("@value5", 0)
                    commandLogsRoloute.Parameters.AddWithValue("@value5", -outputVidro)
                End If

                If outputDinheiro >= 0 Then
                    command.Parameters.AddWithValue("@value10", 0)
                Else
                    command.Parameters.AddWithValue("@value10", outputPagamento)
                End If

                command.Parameters.AddWithValue("@value11", data)

                command.Parameters.AddWithValue("@value12", inputMinério)
                commandLogsContentor.Parameters.AddWithValue("@value4", inputMinério)

                command.Parameters.AddWithValue("@value13", outputNíquel)
                commandLogsContentor.Parameters.AddWithValue("@value5", -outputNíquel)

                command.Parameters.AddWithValue("@value14", outputEnxofre)
                commandLogsContentor.Parameters.AddWithValue("@value6", -outputEnxofre)

                commandLogsContentor.Parameters.AddWithValue("value7", "Contentor")
                commandLogsContentor.Parameters.AddWithValue("@value8", data)
                commandLogsContentor.ExecuteNonQuery()

                commandLogsRoloute.Parameters.AddWithValue("@value6", "Roloute")
                commandLogsRoloute.Parameters.AddWithValue("@value7", data)

                command.Parameters.AddWithValue("@value15", Telemovel)

                command.ExecuteNonQuery()

                If commandStock.Parameters("@value2").Value <> 0 OrElse commandStock.Parameters("@value3").Value <> 0 OrElse commandStock.Parameters("@value4").Value <> 0 OrElse commandStock.Parameters("@value5").Value <> 0 Then
                    commandStock.Parameters.AddWithValue("@value6", inputCliente)
                    commandStock.Parameters.AddWithValue("@value7", data)
                    commandStock.Parameters.AddWithValue("@value8", MVariables.outputTrabalhador)
                    commandStock.ExecuteNonQuery()
                End If

                If commandLogsRoloute.Parameters("@value2").Value <> 0 OrElse commandLogsRoloute.Parameters("@value3").Value <> 0 OrElse commandLogsRoloute.Parameters("@value4").Value <> 0 OrElse commandLogsRoloute.Parameters("@value5").Value <> 0 Then
                    commandLogsRoloute.ExecuteNonQuery()
                End If

                commandPagamentos.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                commandPagamentos.Parameters.AddWithValue("@value2", outputPagamento)
                commandPagamentos.Parameters.AddWithValue("@value3", data)

                If outputDinheiro < 0 Then
                    commandPagamentos.ExecuteNonQuery()
                End If

            End Using
            'Registo do salário na tabela pagamentos 

            Using command As New MySqlCommand(quarySalários, connection)

                command.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", Salário)
                command.Parameters.AddWithValue("@value3", data)

                If checkFerro.Checked = False AndAlso checkCobre.Checked = False AndAlso checkPrata.Checked = False AndAlso checkVidro.Checked = False Then
                    command.ExecuteNonQuery()
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
        txtCobre.Text = ""
        txtDinheiro.Text = ""
        txtEnxofre.Text = ""
        txtFerro.Text = ""
        txtNíquel.Text = ""
        txtPrata.Text = ""
        txtVidro.Text = ""
        txtTelemovel.Text = ""
        SeletorEquipas.SelectedIndex = -1
        txtAvisoValor.Text = ""

    End Sub

    Private Sub seletorMenus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seletorMenu.SelectedIndexChanged

        ' Mudar menus

        Dim selectedMenu As String = seletorMenu.SelectedItem.ToString()

        Select Case selectedMenu

            Case "Gestão de Stocks"
                Dim formA As New Gestão_Stock()
                formA.Show()
                Me.Hide()

            Case "Craft de Polvora"
                Dim formB As New Processo_Polvora()
                formB.Show()
                Me.Hide()

            Case "Processo de Pedra"
                Dim formC As New Processo_Pedra()
                formC.Show()
                Me.Hide()

            Case "Venda de Materiais"
                Dim formD As New Processo_Legal()
                formD.Show()
                Me.Hide()

            Case "Craft de Armas e Acessorios"
                Dim formE As New Craft_Armas()
                formE.Show()
                Me.Hide()

        End Select

    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

        Dim Materias As String = seletorMaterial.SelectedItem.ToString
        Dim quantidade As String = txtQuantidade.Text
        Dim data As String = DateAndTime.Now

        Using connection As New MySqlConnection(connString)

            Dim query As String = "INSERT INTO `Logs` (`Trabalhador`, `" & Materias & "`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", -quantidade)

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
        seletorMaterial.SelectedIndex = -1

    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

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
        seletorMaterial.SelectedIndex = -1

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