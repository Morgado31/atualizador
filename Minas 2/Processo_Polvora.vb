﻿Imports MySql.Data.MySqlClient
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

        If seletorEquipas.SelectedItem.ToString() = "AIMF" Or seletorEquipas.SelectedItem.ToString() = "Yamaha" Or seletorEquipas.SelectedItem.ToString() = "Ronaldo" Or seletorEquipas.SelectedItem.ToString() = "The Garrison" Or seletorEquipas.SelectedItem.ToString() = "Peaky Blinder" Then
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

            Case "Consultar Stocks"
                Dim formA As New Gestão_Stock()
                formA.Show()
                Me.Hide()

            Case "Calculadora Mina Legal"
                Dim formB As New Processo_Legal()
                formB.Show()
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

        Dim result As DialogResult = MessageBox.Show("Confirmas que os valores que introduzis-te estão corretos?", "Confirmação", MessageBoxButtons.OKCancel)

        If result <> DialogResult.OK Then
            Exit Sub
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim Quantidade As Integer = txtQuantidade.Text
            Dim Trabalhador As String = MVariables.outputTrabalhador
            Dim Equipa As String = seletorEquipas.SelectedItem.ToString()
            Dim Cliente As String = txtCliente.Text
            Dim Entregue As Integer = txtEntregar.Text
            Dim Data As String = DateAndTime.Now

            Dim query As String = "INSERT INTO `Polvora` (`Quantidade`, `Trabalhador`, `Equipa`, `Cliente`, `Entregue`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", Quantidade)
                command.Parameters.AddWithValue("@value2", Trabalhador)
                command.Parameters.AddWithValue("@value3", Equipa)
                command.Parameters.AddWithValue("@value4", Cliente)
                command.Parameters.AddWithValue("@value5", Entregue)
                command.Parameters.AddWithValue("@value6", Data)

                command.ExecuteNonQuery()
            End Using

        End Using

        txtCliente.Text = ""
        txtEntregar.Text = ""
        txtQuantidade.Text = ""
        seletorEquipas.SelectedIndex = -1


    End Sub

    Private Sub Processo_Polvora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class