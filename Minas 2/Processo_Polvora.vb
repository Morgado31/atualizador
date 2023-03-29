Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Processo_Polvora

    Private Sub Processo_Polvora_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Introdução das equipas no seletorStockEquipas

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Equipa FROM Equipas"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    seletorEquipas.Items.Add(reader.GetString("Equipa"))

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

                    seletorEquipas.Items.Add(reader2.GetString("Equipas"))

                End While

                reader2.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

            'Colocação em ordem alfabética

            Dim items As String() = seletorEquipas.Items.Cast(Of String)().ToArray()
            Array.Sort(items)
            seletorEquipas.Items.Clear()
            seletorEquipas.Items.AddRange(items)

        End Using

        'Introduzir menus no seletor de menus

        Using Connection As New MySqlConnection(connString)
            Connection.Open()
            Try

                Dim query As String = "SELECT Menus FROM Menus"
                Dim command As New MySqlCommand(query, Connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    SeletorMenu.Items.Add(reader.GetString("Menus"))

                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End Using

        'Colocação em ordem alfabética

        Dim itemsmenu As String() = SeletorMenu.Items.Cast(Of String)().ToArray()
        Array.Sort(itemsmenu)
        SeletorMenu.Items.Clear()
        SeletorMenu.Items.AddRange(itemsmenu)

    End Sub

    Private Sub btnCraft_Click(sender As Object, e As EventArgs) Handles btnCraft.Click

        If IsNumeric(txtQuantidade.Text) = False Then
            MessageBox.Show("Introduzir apenas números")
            txtQuantidade.Text = ""
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtQuantidade.Text) Then
            MessageBox.Show("Introduzir Quantidade de Polvora para Craftar")
            Exit Sub
        End If

        If String.IsNullOrEmpty(seletorEquipas.SelectedItem) Then
            MessageBox.Show("Introduzir equipa")
            Exit Sub
        End If

        Dim Quantidade As Integer = txtQuantidade.Text
        Dim Cliente As String = txtCliente.Text
        Dim quantidadeEntregar As Integer

        quantidadeEntregar = Quantidade * 0.85

        If seletorEquipas.SelectedItem.ToString() = "AIMF" Or seletorEquipas.SelectedItem.ToString() = "Yamaha" Or seletorEquipas.SelectedItem.ToString() = "Ronaldo" Or seletorEquipas.SelectedItem.ToString() = "The Garrison" Or seletorEquipas.SelectedItem.ToString() = "Peaky Blinder" Or seletorEquipas.SelectedItem.ToString() = "Penetra" Then
            quantidadeEntregar = Quantidade
        End If

        If seletorEquipas.SelectedItem.ToString() = "Lacerda" Then
            quantidadeEntregar = Quantidade * 0.95
        End If

        txtEntregar.Text = quantidadeEntregar

    End Sub

    Private Sub SeletorMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeletorMenu.SelectedIndexChanged

        ' Mudar menus

        Dim selectedMenu As String = SeletorMenu.SelectedItem.ToString()

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

        End Select

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrEmpty(txtCliente.Text) Then
            MessageBox.Show("Introduzir cliente")
            Exit Sub
        End If

        If String.IsNullOrEmpty(seletorEquipas.SelectedItem) Then
            MessageBox.Show("Introduzir equipa")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtTelemovel.Text) Then
            MessageBox.Show("Introduzir número de telemóvel")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Confirmas que os valores que introduzis-te estão corretos?", "Confirmação", MessageBoxButtons.OKCancel)

        If result <> DialogResult.OK Then
            Exit Sub
        End If

        Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Polvora`, `Trabalhador`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"

        Dim Quantidade As Integer = txtQuantidade.Text
        Dim Entregue As Integer = txtEntregar.Text
        Dim log As Integer = Quantidade - Entregue
        Dim Data As String = DateAndTime.Now

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Trabalhador As String = MVariables.outputTrabalhador
            Dim Equipa As String = seletorEquipas.SelectedItem.ToString()
            Dim Cliente As String = txtCliente.Text
            Dim Telemovel As String = txtTelemovel.Text

            Dim query As String = "INSERT INTO `Polvora` (`Quantidade`, `Trabalhador`, `Equipa`, `Cliente`, `Entregue`, `Data`, `Contacto`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", Quantidade)
                command.Parameters.AddWithValue("@value2", Trabalhador)
                command.Parameters.AddWithValue("@value3", Equipa)
                command.Parameters.AddWithValue("@value4", Cliente)
                command.Parameters.AddWithValue("@value5", Entregue)
                command.Parameters.AddWithValue("@value6", Data)
                command.Parameters.AddWithValue("@value7", Telemovel)

                command.ExecuteNonQuery()

            End Using

        End Using

        txtCliente.Text = ""
        txtEntregar.Text = ""
        txtTelemovel.Text = ""
        txtQuantidade.Text = ""
        seletorEquipas.SelectedIndex = -1

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)
            If log <> 0 Then
                commandLogsRoloute.Parameters.AddWithValue("@value1", log)
            Else
                Exit Sub
            End If
            commandLogsRoloute.Parameters.AddWithValue("@value2", MVariables.outputTrabalhador)
            commandLogsRoloute.Parameters.AddWithValue("@value3", "Roloute")
            commandLogsRoloute.Parameters.AddWithValue("@value4", Data)
            commandLogsRoloute.ExecuteNonQuery()
        End Using

    End Sub

    Private Sub Processo_Polvora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class