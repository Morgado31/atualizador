Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Processo_Pedra

    Private Sub Processo_Pedra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seletorMenu.SelectedIndexChanged

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

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        'Registos de processo e de logs

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Pedra As String = txtPedra.Text
            Dim Areia As String = txtAreia.Text
            Dim Trabalhador As String = MVariables.outputTrabalhador
            Dim Ferro As String = txtFerro.Text
            Dim Prata As String = txtPrata.Text
            Dim Cobre As String = txtCobre.Text
            Dim Vidro As String = txtVidro.Text
            Dim Data As String = DateAndTime.Now

            'Condições para deixar textboxs em branco

            If String.IsNullOrEmpty(txtPedra.Text) Then
                Pedra = 0
            End If

            If String.IsNullOrEmpty(txtAreia.Text) Then
                Areia = 0
            End If

            If String.IsNullOrEmpty(txtFerro.Text) Then
                Ferro = 0
            End If

            If String.IsNullOrEmpty(txtCobre.Text) Then
                Cobre = 0
            End If

            If String.IsNullOrEmpty(txtPrata.Text) Then
                Prata = 0
            End If

            If String.IsNullOrEmpty(txtVidro.Text) Then
                Vidro = 0
            End If

            'Condição para introduzir apenas numeros

            If IsNumeric(Pedra) = False Or IsNumeric(Areia) = False Or IsNumeric(Ferro) = False Or IsNumeric(Prata) = False Or IsNumeric(Cobre) = False Or IsNumeric(Vidro) = False Then
                MessageBox.Show("Introduzir só números")
                txtAreia.Text = ""
                txtPedra.Text = ""
                txtFerro.Text = ""
                txtPrata.Text = ""
                txtCobre.Text = ""
                txtVidro.Text = ""
                Exit Sub
            End If


            Dim query As String = "INSERT INTO `Processo Legal` (`Pedra`, `Areia`, `Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
            Dim quaryLogsContentor As String = "INSERT INTO `Logs` (`Pedra`, `Areia`, `Trabalhador`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5)"
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", Pedra)
                command.Parameters.AddWithValue("@value2", Areia)
                command.Parameters.AddWithValue("@value3", Trabalhador)
                command.Parameters.AddWithValue("@value4", Ferro)
                command.Parameters.AddWithValue("@value5", Prata)
                command.Parameters.AddWithValue("@value6", Cobre)
                command.Parameters.AddWithValue("@value7", Vidro)
                command.Parameters.AddWithValue("@value8", Data)

                command.ExecuteNonQuery()
            End Using

            Using CommandLogsContentor As New MySqlCommand(quaryLogsContentor, connection)

                CommandLogsContentor.Parameters.AddWithValue("@value1", -Pedra)
                CommandLogsContentor.Parameters.AddWithValue("@value2", -Areia)
                CommandLogsContentor.Parameters.AddWithValue("@value3", MVariables.outputTrabalhador)
                CommandLogsContentor.Parameters.AddWithValue("@value4", "Contentor")
                CommandLogsContentor.Parameters.AddWithValue("@value5", Data)

                CommandLogsContentor.ExecuteNonQuery()

            End Using

            Using CommandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)

                CommandLogsRoloute.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                CommandLogsRoloute.Parameters.AddWithValue("@value2", Ferro)
                CommandLogsRoloute.Parameters.AddWithValue("@value3", Prata)
                CommandLogsRoloute.Parameters.AddWithValue("@value4", Cobre)
                CommandLogsRoloute.Parameters.AddWithValue("@value5", Vidro)
                CommandLogsRoloute.Parameters.AddWithValue("@value6", "Roloute")
                CommandLogsRoloute.Parameters.AddWithValue("@value7", Data)

                CommandLogsRoloute.ExecuteNonQuery()

            End Using

            'Calculo de Salário

            Dim Salário As Integer
            Dim ValorPedra, ValorAreia As Double

            ValorPedra = 9 + (5 * Rnd())
            ValorAreia = 5 + (3 * Rnd())
            Salário = (Pedra * ValorPedra) + (Areia * ValorAreia)

            'Registo do Salário na tabela de pagamentos


            Dim quarySalários As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"
            Using command As New MySqlCommand(quarySalários, connection)

                command.Parameters.AddWithValue("@value1", MVariables.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", Salário)
                command.Parameters.AddWithValue("@value3", Data)

                command.ExecuteNonQuery()

            End Using
            'Reset da app

            txtAreia.Text = ""
            txtCobre.Text = ""
            txtFerro.Text = ""
            txtPedra.Text = ""
            txtPrata.Text = ""
            txtVidro.Text = ""
            MessageBox.Show("Operação registada")

        End Using

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class