Imports MySql.Data.MySqlClient

Public Class Gestão_Stock

    Private Sub Gestão_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Introdução das equipas no seletorStockEquipas

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Equipa FROM Equipas"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    seletorStockEquipa.Items.Add(reader.GetString("Equipa"))

                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            'Colocação em ordem alfabética

            Dim items As String() = seletorStockEquipa.Items.Cast(Of String)().ToArray()
            Array.Sort(items)
            seletorStockEquipa.Items.Clear()
            seletorStockEquipa.Items.AddRange(items)

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

    Private Sub seletorStockMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seletorMenu.SelectedIndexChanged

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

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        'Consulta dos Stocks

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim equipa As String = seletorStockEquipa.SelectedItem.ToString()
            Dim queryFerro As String = "SELECT SUM(ferro) FROM Stocks WHERE Equipa = @value1"
            Dim queryPrata As String = "SELECT SUM(prata) FROM Stocks WHERE Equipa = @value1"
            Dim queryCobre As String = "SELECT SUM(cobre) FROM Stocks WHERE Equipa = @value1"
            Dim queryVidro As String = "SELECT SUM(vidro) FROM Stocks WHERE Equipa = @value1"
            Dim queryPedra As String = "SELECT SUM(pedra) FROM `Venda de Materiais` WHERE Equipa = @value1"
            Dim queryAreia As String = "SELECT SUM(areia) FROM `Venda de Materiais` WHERE Equipa = @value1"
            Dim queryMinério As String = "SELECT SUM(minério) FROM `Venda de Materiais` WHERE Equipa = @value1"

            Using command As New MySqlCommand(queryFerro, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultFerro As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultFerro = Convert.ToInt32(result)
                Else
                    resultFerro = 0
                End If

                txtStockFerro.Text = resultFerro
            End Using

            Using command As New MySqlCommand(queryPrata, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultPrata As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultPrata = Convert.ToInt32(result)
                Else
                    resultPrata = 0
                End If

                txtStockPrata.Text = resultPrata
            End Using

            Using command As New MySqlCommand(queryCobre, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultCobre As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultCobre = Convert.ToInt32(result)
                Else
                    resultCobre = 0
                End If

                txtStockCobre.Text = resultCobre
            End Using

            Using command As New MySqlCommand(queryVidro, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultVidro As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultVidro = Convert.ToInt32(result)
                Else
                    resultVidro = 0
                End If

                txtStockVidro.Text = resultVidro
            End Using

            Using command As New MySqlCommand(queryPedra, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultPedra As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultPedra = Convert.ToInt32(result)
                Else
                    resultPedra = 0
                End If

                txtStockPedra.Text = resultPedra
            End Using

            Using command As New MySqlCommand(queryAreia, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultAreia As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultAreia = Convert.ToInt32(result)
                Else
                    resultAreia = 0
                End If

                txtStockAreia.Text = resultAreia
            End Using

            Using command As New MySqlCommand(queryMinério, connection)
                command.Parameters.AddWithValue("@value1", equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultMinério As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultMinério = Convert.ToInt32(result)
                Else
                    resultMinério = 0
                End If

                txtStockMinério.Text = resultMinério
            End Using

        End Using

    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click

        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("Identifica o cliente")
            Exit Sub
        End If

        Dim resultCheck As DialogResult = MessageBox.Show("Confirmas que está tudo correto?" & vbCrLf & "Passas-te a fatura?" & vbCrLf & "Lembra te do Scorpion!", "Confirmação", MessageBoxButtons.OKCancel)

        If resultCheck = DialogResult.OK Then
            MessageBox.Show("Operação Registada")
        Else
            Exit Sub
        End If

        Dim QuantidadeFerro As String = txtFerro.Text
        Dim QuantidadePrata As String = txtPrata.Text
        Dim QuantidadeCobre As String = txtCobre.Text
        Dim QuantidadeVidro As String = txtVidro.Text

        'Resgisto na database dos valores levantados do stock

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim quary As String = "INSERT INTO Stocks (Ferro, Prata, Cobre, Vidro, Equipa, Trabalhador, Cliente, Data) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
            Dim equipaSelecionada As String = seletorStockEquipa.SelectedItem.ToString()
            Dim data As String = DateAndTime.Now
            Dim Cliente As String = txtCliente.Text
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            If String.IsNullOrWhiteSpace(txtFerro.Text) Then
                QuantidadeFerro = 0
            End If

            If String.IsNullOrWhiteSpace(txtPrata.Text) Then
                QuantidadePrata = 0
            End If

            If String.IsNullOrWhiteSpace(txtCobre.Text) Then
                QuantidadeCobre = 0
            End If

            If String.IsNullOrWhiteSpace(txtVidro.Text) Then
                QuantidadeVidro = 0
            End If

            Using Command As New MySqlCommand(quary, connection)

                Dim queryFerro As String = "SELECT SUM(ferro) FROM Stocks WHERE Equipa = @value1"
                Dim queryPrata As String = "SELECT SUM(prata) FROM Stocks WHERE Equipa = @value1"
                Dim queryCobre As String = "SELECT SUM(cobre) FROM Stocks WHERE Equipa = @value1"
                Dim queryVidro As String = "SELECT SUM(vidro) FROM Stocks WHERE Equipa = @value1"

                Using commandstock As New MySqlCommand(queryFerro, connection)
                    If QuantidadeFerro >= 0 Then

                        commandstock.Parameters.AddWithValue("@value1", equipaSelecionada)
                        Dim result As Object = commandstock.ExecuteScalar()

                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                            Dim resultFerro As Integer = Convert.ToInt32(result)

                            If resultFerro < QuantidadeFerro Then

                                MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de FERRO em stock para ser retirada")
                                Exit Sub

                            Else

                                Command.Parameters.AddWithValue("@value1", -QuantidadeFerro)
                                Command.Parameters.AddWithValue("@value5", equipaSelecionada)

                            End If
                        Else

                            MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de FERRO em stock para ser retirada")
                            Exit Sub

                        End If
                    End If

                End Using

                Using commandstock As New MySqlCommand(queryPrata, connection)
                    If QuantidadePrata >= 0 Then

                        commandstock.Parameters.AddWithValue("@value1", equipaSelecionada)
                        Dim result As Object = commandstock.ExecuteScalar()

                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                            Dim resultPrata As Integer = Convert.ToInt32(result)

                            If resultPrata < QuantidadePrata Then

                                MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de PRATA em stock para ser retirada")
                                Exit Sub

                            Else

                                Command.Parameters.AddWithValue("@value2", -QuantidadePrata)

                            End If

                        Else

                            MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de PRATA em stock para ser retirada")
                            Exit Sub

                        End If

                    End If

                End Using

                Using commandstock As New MySqlCommand(queryCobre, connection)
                    If QuantidadeCobre >= 0 Then

                        commandstock.Parameters.AddWithValue("@value1", equipaSelecionada)
                        Dim result As Object = commandstock.ExecuteScalar()

                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                            Dim resultCobre As Integer = Convert.ToInt32(result)

                            If resultCobre < QuantidadeCobre Then

                                MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de COBRE em stock para ser retirada")
                                Exit Sub

                            Else

                                Command.Parameters.AddWithValue("@value3", -QuantidadeCobre)

                            End If

                        Else

                            MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de COBRE em stock para ser retirada")
                            Exit Sub

                        End If

                    End If

                End Using

                Using commandstock As New MySqlCommand(queryVidro, connection)

                    If QuantidadeVidro >= 0 Then

                        commandstock.Parameters.AddWithValue("@value1", equipaSelecionada)
                        Dim result As Object = commandstock.ExecuteScalar()

                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                            Dim resultvidro As Integer = Convert.ToInt32(result)

                            If resultvidro < QuantidadeVidro Then

                                MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de VIDRO em stock para ser retirada")
                                Exit Sub

                            Else

                                Command.Parameters.AddWithValue("@value4", -QuantidadeVidro)

                            End If

                        Else

                            MessageBox.Show("A equipa " & equipaSelecionada & " NÃO POSSUI essa quantidade de VIDRO em stock para ser retirada")
                            Exit Sub

                        End If
                    End If
                End Using

                Command.Parameters.AddWithValue("@value6", outputTrabalhador)
                Command.Parameters.AddWithValue("@value7", Cliente)
                Command.Parameters.AddWithValue("@value8", data)

                Command.ExecuteNonQuery()

            End Using

            Using commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)

                commandLogsRoloute.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value2", -QuantidadeFerro)
                commandLogsRoloute.Parameters.AddWithValue("@value4", -QuantidadeCobre)
                commandLogsRoloute.Parameters.AddWithValue("@value3", -QuantidadePrata)
                commandLogsRoloute.Parameters.AddWithValue("@value5", -QuantidadeVidro)
                commandLogsRoloute.Parameters.AddWithValue("@value6", "Roloute")
                commandLogsRoloute.Parameters.AddWithValue("@value7", data)
                commandLogsRoloute.ExecuteNonQuery()

            End Using

        End Using

            txtFerro.Clear()
        txtPrata.Clear()
        txtCobre.Clear()
        txtVidro.Clear()
        txtCliente.Clear()
        lblFatura.Text = ""
        btnConsultar.PerformClick()

    End Sub

    Private Sub txtFerro_TextChanged(sender As Object, e As EventArgs) Handles txtFerro.TextChanged

        If String.IsNullOrWhiteSpace(seletorStockEquipa.SelectedItem) Then
            MessageBox.Show("Seleciona a equipa primeiro")
            txtFerro.Clear()
            Exit Sub
        End If

        If txtStockFerro.Text = 0 Then
            MessageBox.Show("Não existe ferro para ser retirado")
            txtFerro.Clear()
            Exit Sub
        End If

        Dim QuantidadeFerro As String = txtFerro.Text
        Dim QuantidadePrata As String = txtPrata.Text
        Dim QuantidadeCobre As String = txtCobre.Text
        Dim QuantidadeVidro As String = txtVidro.Text

        If String.IsNullOrWhiteSpace(txtFerro.Text) Then
            QuantidadeFerro = 0
        End If

        If String.IsNullOrWhiteSpace(txtCobre.Text) Then
            QuantidadeCobre = 0
        End If

        If String.IsNullOrWhiteSpace(txtPrata.Text) Then
            QuantidadePrata = 0
        End If

        If String.IsNullOrWhiteSpace(txtVidro.Text) Then
            QuantidadeVidro = 0
        End If

        Dim equipaSelecionada As String = seletorStockEquipa.SelectedItem.ToString()

        Dim outputDinheiro As Integer = (QuantidadeFerro * 65 + QuantidadeCobre * 80 + QuantidadePrata * 100 + QuantidadeVidro * 60)

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try 'Parcerias (Pagam 0)

                Dim query As String = "SELECT COUNT(*) FROM Parcerias WHERE Equipas = @equipa"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@equipa", seletorStockEquipa.Text)

                Dim count As Integer = 0
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    count = Convert.ToInt32(result)
                End If

                If count > 0 Then
                    outputDinheiro = 0
                    lblFatura.Text = "Parceria"
                    lblFatura.ForeColor = Color.SteelBlue
                End If

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

        If outputDinheiro > 0 Then
            lblFatura.Text = "Passar Fatura"
            lblFatura.ForeColor = Color.Green
        End If

        txtFatura.Text = outputDinheiro

    End Sub

    Private Sub txtPrata_TextChanged(sender As Object, e As EventArgs) Handles txtPrata.TextChanged

        If String.IsNullOrWhiteSpace(seletorStockEquipa.SelectedItem) Then
            MessageBox.Show("Seleciona a equipa primeiro")
            txtPrata.Text = ""
            Exit Sub
        End If

        If txtStockPrata.Text = 0 Then
            MessageBox.Show("Não existe prata para ser retirado")
            txtPrata.Text = ""
            Exit Sub
        End If

        Dim QuantidadeFerro As String = txtFerro.Text
        Dim QuantidadePrata As String = txtPrata.Text
        Dim QuantidadeCobre As String = txtCobre.Text
        Dim QuantidadeVidro As String = txtVidro.Text

        If String.IsNullOrWhiteSpace(txtPrata.Text) Then
            QuantidadePrata = 0
        End If

        If String.IsNullOrWhiteSpace(txtFerro.Text) Then
            QuantidadeFerro = 0
        End If

        If String.IsNullOrWhiteSpace(txtCobre.Text) Then
            QuantidadeCobre = 0
        End If

        If String.IsNullOrWhiteSpace(txtVidro.Text) Then
            QuantidadeVidro = 0
        End If

        Dim equipaSelecionada As String = seletorStockEquipa.SelectedItem.ToString()

        Dim outputDinheiro As Integer = (QuantidadeFerro * 65 + QuantidadeCobre * 80 + QuantidadePrata * 100 + QuantidadeVidro * 60)

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try 'Parcerias (Pagam 0)

                Dim query As String = "SELECT COUNT(*) FROM Parcerias WHERE Equipas = @equipa"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@equipa", seletorStockEquipa.Text)

                Dim count As Integer = 0
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    count = Convert.ToInt32(result)
                End If

                If count > 0 Then
                    outputDinheiro = 0
                    lblFatura.Text = "Parceria"
                    lblFatura.ForeColor = Color.SteelBlue
                End If

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

        If outputDinheiro > 0 Then
            lblFatura.Text = "Passar Fatura"
            lblFatura.ForeColor = Color.Green
        End If

        txtFatura.Text = outputDinheiro

    End Sub

    Private Sub txtCobre_TextChanged(sender As Object, e As EventArgs) Handles txtCobre.TextChanged

        If String.IsNullOrWhiteSpace(seletorStockEquipa.SelectedItem) Then
            MessageBox.Show("Seleciona a equipa primeiro")
            txtCobre.Text = ""
            Exit Sub
        End If

        If txtStockCobre.Text = 0 Then
            MessageBox.Show("Não existe cobre para ser retirado")
            txtCobre.Text = ""
            Exit Sub
        End If

        Dim QuantidadeFerro As String = txtFerro.Text
        Dim QuantidadePrata As String = txtPrata.Text
        Dim QuantidadeCobre As String = txtCobre.Text
        Dim QuantidadeVidro As String = txtVidro.Text

        If String.IsNullOrWhiteSpace(txtCobre.Text) Then
            QuantidadeCobre = 0
        End If

        If String.IsNullOrWhiteSpace(txtFerro.Text) Then
            QuantidadeFerro = 0
        End If

        If String.IsNullOrWhiteSpace(txtPrata.Text) Then
            QuantidadePrata = 0
        End If

        If String.IsNullOrWhiteSpace(txtVidro.Text) Then
            QuantidadeVidro = 0
        End If

        Dim equipaSelecionada As String = seletorStockEquipa.SelectedItem.ToString()

        Dim outputDinheiro As Integer = (QuantidadeFerro * 65 + QuantidadeCobre * 80 + QuantidadePrata * 100 + QuantidadeVidro * 60)

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try 'Parcerias (Pagam 0)

                Dim query As String = "SELECT COUNT(*) FROM Parcerias WHERE Equipas = @equipa"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@equipa", seletorStockEquipa.Text)

                Dim count As Integer = 0
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    count = Convert.ToInt32(result)
                End If

                If count > 0 Then
                    outputDinheiro = 0
                    lblFatura.Text = "Parceria"
                    lblFatura.ForeColor = Color.SteelBlue
                End If

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

        If outputDinheiro > 0 Then
            lblFatura.Text = "Passar Fatura"
            lblFatura.ForeColor = Color.Green
        End If

        txtFatura.Text = outputDinheiro

    End Sub

    Private Sub txtVidro_TextChanged(sender As Object, e As EventArgs) Handles txtVidro.TextChanged

        If String.IsNullOrWhiteSpace(seletorStockEquipa.SelectedItem) Then
            MessageBox.Show("Seleciona a equipa primeiro")
            txtVidro.Text = ""
            Exit Sub
        End If

        If txtStockVidro.Text = 0 Then
            MessageBox.Show("Não existe vidro para ser retirado")
            txtVidro.Text = ""
            Exit Sub
        End If

        Dim QuantidadeFerro As String = txtFerro.Text
        Dim QuantidadePrata As String = txtPrata.Text
        Dim QuantidadeCobre As String = txtCobre.Text
        Dim QuantidadeVidro As String = txtVidro.Text

        If String.IsNullOrWhiteSpace(txtVidro.Text) Then
            QuantidadeVidro = 0
        End If

        If String.IsNullOrWhiteSpace(txtFerro.Text) Then
            QuantidadeFerro = 0
        End If

        If String.IsNullOrWhiteSpace(txtCobre.Text) Then
            QuantidadeCobre = 0
        End If

        If String.IsNullOrWhiteSpace(txtPrata.Text) Then
            QuantidadePrata = 0
        End If

        Dim equipaSelecionada As String = seletorStockEquipa.SelectedItem.ToString()

        Dim outputDinheiro As Integer = (QuantidadeFerro * 65 + QuantidadeCobre * 80 + QuantidadePrata * 100 + QuantidadeVidro * 60)

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try 'Parcerias (Pagam 0)

                Dim query As String = "SELECT COUNT(*) FROM Parcerias WHERE Equipas = @equipa"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@equipa", seletorStockEquipa.Text)

                Dim count As Integer = 0
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    count = Convert.ToInt32(result)
                End If

                If count > 0 Then
                    outputDinheiro = 0
                    lblFatura.Text = "Parceria"
                    lblFatura.ForeColor = Color.SteelBlue
                End If

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using

        If outputDinheiro > 0 Then
            lblFatura.Text = "Passar Fatura"
            lblFatura.ForeColor = Color.Green
        End If

        txtFatura.Text = outputDinheiro

    End Sub

    Private Sub Gestão_Stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class