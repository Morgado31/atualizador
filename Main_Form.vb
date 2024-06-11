Imports System.Collections.ObjectModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports Microsoft.VisualBasic.Logging
Imports MySql
Imports MySql.Data.Authentication
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI
Imports Mysqlx.XDevAPI.Common
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Utilities.Collections

Public Class Main_Form
    Dim versaoapp As String = "2.2.2"
    Dim Telemovel As Integer
    Dim inputPedra, inputAreia, inputMinério, Equipa, Cliente, DrillsQuantidadeUsadas As String
    Dim outputCobre, outputFerro, outputPrata, outputVidro, outputNíquel, outputEnxofre, outputdinheiro, Salário, parcelaFerro, parcelaCobre, parcelaPrata, parcelaVidro As Integer
    Dim mUsada, DrillsFatura, DrillsQuantidadeVendida As Integer
    Dim JaAdquirida As Boolean
    Dim PercentagemFerro, PercentagemPrata, PercentagemCobre, PercentagemVidro, PercentagemEnxofre, PercentagemNiquel As String
    'Display da versão
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles picOffset.MouseHover
        ToolTip1.SetToolTip(picOffset, versaoapp)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim queryLogin As String = "Select * From Login WHERE Username=@Username And Password=@Password"
            Using commandLogin As New MySqlCommand(queryLogin, connection)

                commandLogin.Parameters.AddWithValue("@Username", txtUsername.Text)
                commandLogin.Parameters.AddWithValue("@Password", txtPassword.Text)
                Dim reader As MySqlDataReader = commandLogin.ExecuteReader()

                If reader.HasRows Then
                    OutStorage.outputTrabalhador = txtUsername.Text
                    reader.Close()

                    Dim queryInsertVersão As String = "UPDATE `Login` SET `Versão Atual` = @value1 WHERE `Username` = @value2"
                    Using CommandInsertVersão As New MySqlCommand(queryInsertVersão, connection)

                        CommandInsertVersão.Parameters.AddWithValue("@value1", versaoapp)
                        CommandInsertVersão.Parameters.AddWithValue("@value2", OutStorage.outputTrabalhador)

                        CommandInsertVersão.ExecuteNonQuery()

                    End Using

                    Dim queryInsertLastLogin As String = "UPDATE `Login` SET `Ultimo Login` = @value1 WHERE `Username` = @value2"
                    Using CommandInsertLogin As New MySqlCommand(queryInsertLastLogin, connection)
                        Dim Data As String = DateAndTime.Now

                        CommandInsertLogin.Parameters.AddWithValue("@value1", Data)
                        CommandInsertLogin.Parameters.AddWithValue("@value2", OutStorage.outputTrabalhador)

                        CommandInsertLogin.ExecuteNonQuery()

                    End Using

                    Dim QueryVersao As String = "Select `Versao` FROM `Parametros de Atendimento`"
                    Using commandVersao As New MySqlCommand(QueryVersao, connection)

                        Dim readerVersão As MySqlDataReader = commandVersao.ExecuteReader()

                        readerVersão.Read()

                        Dim versaoDB As String = readerVersão.GetString(readerVersão.GetOrdinal("Versao"))

                        If versaoapp <> versaoDB Then
                            MsgBox($"Tens a versão {versaoapp} e atualmente a app está na versão {versaoDB}. Se não te aparecer o menu para atualizar dentro de algum tempo desinstala a app e volta a instalar. O instalador está na sala de avisos da app no discord.", MsgBoxStyle.Critical, "Aviso")
                            Me.Close()
                        End If
                        readerVersão.Close()
                    End Using

                    Dim PermAdm As String
                    Dim QueryADM As String = "Select `Admin` FROM Login WHERE Username = @value1"
                    Using commandADM As New MySqlCommand(QueryADM, connection)

                        commandADM.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)

                        Dim readerAdm As MySqlDataReader = commandADM.ExecuteReader()

                        readerAdm.Read()

                        PermAdm = readerAdm.GetString(readerAdm.GetOrdinal("Admin"))


                        If PermAdm = 0 Then
                            btnAdministração.Enabled = False
                        Else
                            btnAdministração.Enabled = True
                        End If
                        readerAdm.Close()
                    End Using

                    Dim QueryFuncionamento As String = "Select `ON/OFF`, `Mensagem` FROM Funcionamento WHERE Tipo = @value1"
                    Using commandFuncionamento As New MySqlCommand(QueryFuncionamento, connection)

                        commandFuncionamento.Parameters.AddWithValue("@value1", "Geral")

                        Dim readerFunc As MySqlDataReader = commandFuncionamento.ExecuteReader()

                        readerFunc.Read()

                        Dim PermFuncionamento As String = readerFunc.GetString(readerFunc.GetOrdinal("ON/OFF"))
                        Dim Msg As String = readerFunc.GetString(readerFunc.GetOrdinal("Mensagem"))

                        If PermFuncionamento = "OFF" And PermAdm <> 1 Then
                            MsgBox(Msg, MsgBoxStyle.Critical, "Aviso")
                            Me.Close()
                        End If
                        readerFunc.Close()
                    End Using

                    Dim QueryCraft As String = "Select `Craft de Armas` FROM Login WHERE Username = @value1"
                    Using commandCraft As New MySqlCommand(QueryCraft, connection)

                        commandCraft.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)

                        Dim readerCraft As MySqlDataReader = commandCraft.ExecuteReader()

                        readerCraft.Read()

                        Dim Perm As String = readerCraft.GetString(readerCraft.GetOrdinal("Craft de Armas"))

                        If Perm = 0 Then
                            btnCraft.Enabled = False
                        Else
                            btnCraft.Enabled = True
                        End If
                        readerCraft.Close()
                    End Using

                    Dim QueryAEquipa As String = "Select `Alterar Equipa` FROM Login WHERE Username = @value1"
                    Using commandAEquipa As New MySqlCommand(QueryAEquipa, connection)

                        commandAEquipa.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)

                        Dim readerAEquipa As MySqlDataReader = commandAEquipa.ExecuteReader()

                        readerAEquipa.Read()

                        Dim Perm As String = readerAEquipa.GetString(readerAEquipa.GetOrdinal("Alterar Equipa"))

                        If Perm = 0 Then
                            EditarEquipaToolStripMenuItem.Enabled = False
                        Else
                            EditarEquipaToolStripMenuItem.Enabled = True
                        End If
                        readerAEquipa.Close()
                    End Using

                    LoginRight()
                Else
                    MsgBox("O Username ou a Password estão errados", MsgBoxStyle.Critical, "Aviso")
                    txtUsername.Clear() : txtPassword.Clear() : txtUsername.Focus()
                    Exit Sub
                End If

                reader.Close()
            End Using
        End Using

    End Sub

    'Load da app
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using connection As New MySqlConnection(connString)
            connection.Open()

        End Using

        'Paineis
        pnlOnButtonAtendimento.Visible = False
        pnlOnButtonProcessamento.Visible = False
        pnlOnButtonAdministração.Visible = False
        pnlOnButtonStock.Visible = False
        pnlOnButtonCraft.Visible = False
        pnlLogin.Visible = True
        pnlAtendimento.Visible = False
        pnlProcessamento.Visible = False
        pnlStock.Visible = False
        pnlAdministração.Visible = False
        pnlCliente.Visible = False
        pnlEditarEquipa.Visible = False
        pnlCraft.Visible = False
        'Botões
        btnAdministração.Enabled = False
        btnAtendimento.Enabled = False
        btnProcessamento.Enabled = False
        btnMenu.Enabled = False
        btnStock.Enabled = False
        btnCraft.Enabled = False

        lblArmas.Text = ""
        lblAcess.Text = ""
        lblColetes.Text = ""

    End Sub

    'Panel esquerdo nos botões
    Private Sub btnProcessamento_Click(sender As Object, e As EventArgs) Handles btnProcessamento.Click
        pnlOnButtonAtendimento.Visible = False
        pnlOnButtonProcessamento.Visible = True
        pnlOnButtonAdministração.Visible = False
        pnlOnButtonStock.Visible = False
        pnlOnButtonCraft.Visible = False
        pnlAtendimento.Visible = False
        pnlProcessamento.Visible = True
        pnlAdministração.Visible = False
        pnlStock.Visible = False
        pnlCliente.Visible = False
        pnlCraft.Visible = False
    End Sub

    Private Sub btnAdministração_Click(sender As Object, e As EventArgs) Handles btnAdministração.Click
        pnlOnButtonAtendimento.Visible = False
        pnlOnButtonProcessamento.Visible = False
        pnlOnButtonAdministração.Visible = True
        pnlOnButtonStock.Visible = False
        pnlOnButtonCraft.Visible = False
        pnlAtendimento.Visible = False
        pnlProcessamento.Visible = False
        pnlAdministração.Visible = True
        pnlStock.Visible = False
        pnlCliente.Visible = False
        pnlCraft.Visible = False

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim quaryTrabalhadores As String = "SELECT Username FROM Login"

            Using command As New MySqlCommand(quaryTrabalhadores, connection)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()

                    ListBoxTrabalhadores.Items.Add((reader("Username").ToString()))

                End While

            End Using

        End Using

    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click

        pnlOnButtonAtendimento.Visible = False
        pnlOnButtonProcessamento.Visible = False
        pnlOnButtonAdministração.Visible = False
        pnlOnButtonStock.Visible = True
        pnlOnButtonCraft.Visible = False
        pnlAdministração.Visible = False
        pnlAtendimento.Visible = False
        pnlProcessamento.Visible = False
        pnlStock.Visible = True
        pnlCliente.Visible = False
        pnlCraft.Visible = False

        AtualizarQuantidadesStock()

    End Sub

    'Botão para fechar a app
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Botão para minimizar a app
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    'Comands para mexer a app pela TopSidePanel
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub pnlTopSide_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pnlTopSide.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    ''Fechar e abrir o LeftSidePanel
    'Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
    '    If pnlLeftSize.Width = 178 Then
    '        pnlLeftSize.Width = 52
    '        lblMinas.Visible = False
    '    Else
    '        pnlLeftSize.Width = 178
    '        lblMinas.Visible = True
    '    End If
    'End Sub


    'Verificar o funcionamento do sidepanel


    'Sistema de Login
    '================================================================================================================================================================================
    Private Sub LoginRight()
        'Paineis
        pnlLogin.Visible = False
        'Botões
        btnAtendimento.Enabled = True
        btnProcessamento.Enabled = True
        btnStock.Enabled = True

        btnAtendimento.PerformClick()

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNúmero.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True ' Cancela o pressionamento da tecla de espaço
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelemovelCliente.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True ' Cancela o pressionamento da tecla de espaço
        End If
    End Sub

    'Sistema de Atendimento
    '============================================================================================================================================================================
    Private Sub btnAtendimento_Click(sender As Object, e As EventArgs) Handles btnAtendimento.Click
        pnlOnButtonAtendimento.Visible = True
        pnlOnButtonProcessamento.Visible = False
        pnlOnButtonAdministração.Visible = False
        pnlOnButtonStock.Visible = False
        pnlOnButtonCraft.Visible = False
        pnlAdministração.Visible = False
        pnlProcessamento.Visible = False
        pnlEditarEquipa.Visible = False
        pnlStock.Visible = False
        pnlCliente.Visible = False
        pnlCraft.Visible = False
        rdnComEquipa.Checked = True

        If Equipa = "" Then
            pnlCliente.Visible = True
            pnlAtendimento.Visible = False
        Else
            pnlCliente.Visible = False
            pnlAtendimento.Visible = True
        End If

        If seletorEquipas.Items.Count = 0 Then
            'Load das equipas
            Using Connection As New MySqlConnection(connString)
                Connection.Open()

                Dim queryEquipas As String = "Select Equipa FROM Equipas"
                Using commandEquipas As New MySqlCommand(queryEquipas, Connection)
                    Dim reader As MySqlDataReader = commandEquipas.ExecuteReader()

                    While reader.Read()

                        seletorEquipas.Items.Add(reader.GetString("Equipa"))

                    End While

                    reader.Close()

                    'Colocação em ordem alfabética

                    Dim items As String() = seletorEquipas.Items.Cast(Of String)().ToArray()
                    Array.Sort(items)
                    seletorEquipas.Items.Clear()
                    seletorEquipas.Items.AddRange(items)

                End Using

                Dim queryPercentagem As String = "Select `% Ferro`, `% Prata`, `% Cobre`, `% Vidro`, `% Enxofre`, `% Niquel` FROM `Parametros de Atendimento`"

                Using Command As New MySqlCommand(queryPercentagem, Connection)
                    Dim reader As MySqlDataReader = Command.ExecuteReader()

                    reader.Read()

                    PercentagemFerro = reader.GetString(reader.GetOrdinal("% Ferro")) / 100
                    PercentagemPrata = reader.GetString(reader.GetOrdinal("% Prata")) / 100
                    PercentagemCobre = reader.GetString(reader.GetOrdinal("% Cobre")) / 100
                    PercentagemVidro = reader.GetString(reader.GetOrdinal("% Vidro")) / 100
                    PercentagemEnxofre = reader.GetString(reader.GetOrdinal("% Enxofre")) / 100
                    PercentagemNiquel = reader.GetString(reader.GetOrdinal("% Niquel")) / 100

                End Using

            End Using
        End If

        Dim nome As Object = Handle.ToString()

        'Cenas para as drills
        lblDrillFaturas.Text = 0
        lblDrillFaturas.ForeColor = Color.Gray

        txtDrillsUsadas.Visible = False
        DrillsQuantidadeUsadas = 0

        VerificarCompraDrill()



    End Sub

    'Calculo dos valores para venda de Materiais

    'Permitir apenas numeros nas textboxs
    Private Sub txtPedra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPedra.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAreia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreia.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinério_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinério.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNúmero_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetirarFerro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetirarFerro.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetirarPrata_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetirarPrata.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetirarCobre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetirarCobre.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetirarVidro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetirarVidro.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Calculos de materiais
    Private Sub txtPedra_TextChanged(sender As Object, e As EventArgs) Handles txtPedra.TextChanged
        If txtPedra.Text = "" Then
            inputPedra = 0
        Else
            inputPedra = txtPedra.Text
        End If

        outputFerro = inputPedra * PercentagemFerro : outputCobre = inputPedra * PercentagemCobre : outputPrata = inputPedra * PercentagemPrata

        'Display dos valores
        lblFerro.Text = outputFerro : lblPrata.Text = outputPrata : lblCobre.Text = outputCobre
        CalcularFatura()
    End Sub

    Private Sub txtAreia_TextChanged(sender As Object, e As EventArgs) Handles txtAreia.TextChanged
        If txtAreia.Text = "" Then
            inputAreia = 0
        Else
            inputAreia = txtAreia.Text
        End If

        outputVidro = inputAreia * PercentagemVidro

        lblVidro.Text = outputVidro
        CalcularFatura()
    End Sub

    Private Sub txtMinério_TextChanged(sender As Object, e As EventArgs) Handles txtMinério.TextChanged
        If txtMinério.Text = "" Then
            inputMinério = 0
        Else
            inputMinério = txtMinério.Text
        End If

        outputEnxofre = inputMinério * PercentagemEnxofre : outputNíquel = inputMinério * PercentagemNiquel

        lblEnxofre.Text = outputEnxofre : lblNiquel.Text = outputNíquel
    End Sub

    Private Sub CalcularFatura()

        If checkFerro.Checked = True Then
            parcelaFerro = 0
            lblFerro.Text = "0"
        Else
            parcelaFerro = outputFerro
            lblFerro.Text = outputFerro
        End If

        If checkPrata.Checked = True Then
            parcelaPrata = 0
            lblPrata.Text = "0"
        Else
            parcelaPrata = outputPrata
            lblPrata.Text = outputPrata
        End If

        If checkCobre.Checked = True Then
            parcelaCobre = 0
            lblCobre.Text = "0"
        Else
            parcelaCobre = outputCobre
            lblCobre.Text = outputCobre
        End If

        If checkVidro.Checked = True Then
            parcelaVidro = 0
            lblVidro.Text = "0"
        Else
            parcelaVidro = outputVidro
            lblVidro.Text = outputVidro
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim Query As String = "Select `Valor Pedra`, `Valor Areia`, `Valor Ferro`, `Valor Prata`, `Valor Cobre`, `Valor Vidro` FROM Equipas WHERE Equipa = @value1"

            Using Command As New MySqlCommand(Query, connection)

                Command.Parameters.AddWithValue("@value1", Equipa)
                Dim reader As MySqlDataReader = Command.ExecuteReader()

                reader.Read()

                Dim ValorPedra, ValorAreia, ValorFerro, ValorPrata, ValorCobre, ValorVidro As String

                ValorPedra = reader.GetString(reader.GetOrdinal("Valor Pedra"))
                ValorAreia = reader.GetString(reader.GetOrdinal("Valor Areia"))
                ValorFerro = reader.GetString(reader.GetOrdinal("Valor Ferro"))
                ValorPrata = reader.GetString(reader.GetOrdinal("Valor Prata"))
                ValorCobre = reader.GetString(reader.GetOrdinal("Valor Cobre"))
                ValorVidro = reader.GetString(reader.GetOrdinal("Valor Vidro"))

                outputdinheiro = parcelaFerro * ValorFerro + parcelaCobre * ValorCobre + parcelaPrata * ValorPrata + parcelaVidro * ValorVidro - ((inputPedra * ValorPedra) + (inputAreia * ValorAreia))

            End Using
        End Using

        lblFatura.Text = outputdinheiro

        If outputdinheiro > 0 Then
            lblFatura.ForeColor = Color.Green
        Else
            lblFatura.ForeColor = Color.Red
        End If

        If inputAreia = 0 AndAlso inputPedra = 0 Then
            lblFatura.Text = "0"
            lblFatura.ForeColor = Color.Gray
        End If

    End Sub

    Private Sub CalcularSalário()
        Dim Percentagem As Double
        If Equipa = "Minas" Then

            If OutStorage.outputTrabalhador = "morgado" Then
                Percentagem = 0.35 + (0.05 * Rnd())
                Salário = Math.Abs(outputdinheiro) * Percentagem
            Else
                Percentagem = 0.2 + (0.2 * Rnd())
                Salário = Math.Abs(outputdinheiro) * Percentagem
            End If

        Else

            If OutStorage.outputTrabalhador = "morgado" Then
                Percentagem = 0.4
                Salário = Math.Abs(outputdinheiro) * Percentagem
            Else
                Percentagem = 0.3 + (0.1 * Rnd())
                Salário = Math.Abs(outputdinheiro) * Percentagem
            End If

        End If

    End Sub

    'Registos na base de dados
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CalcularSalário()
        If Cliente = "" Or Equipa = "" Then
            MsgBox("Insere o número de telemóvel", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPedra.Text) Then
            inputPedra = 0
        End If

        If String.IsNullOrEmpty(txtAreia.Text) Then
            inputAreia = 0
        End If

        If String.IsNullOrEmpty(txtMinério.Text) Then
            inputMinério = 0
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim inputCliente As String = Cliente
            Dim inputEquipa As String = Equipa
            Dim outputPagamento As Integer = Math.Abs(outputdinheiro)
            Dim data As String = DateAndTime.Now

            Dim quary As String = "INSERT INTO `Venda de Materiais` (`Pedra`, `Areia`, `Trabalhador`, `Equipa`, `Cliente`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Pagamento`, `Data`, `Minério`, `Níquel`, `Enxofre`, `Contacto`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13,@value14,@value15)"
            Dim quaryStock As String = "INSERT INTO `Stocks` (`Equipa`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Cliente`, `Data`, `Trabalhador`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
            Dim quaryLogsContentor As String = "INSERT INTO `Logs` (`Pedra`, `Areia`, `Trabalhador`, `Minério`, `Níquel`, `Enxofre`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"
            Dim quaryPagamentos As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"
            Dim quarySalários As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"

            Using command As New MySqlCommand(quary, connection)
                Dim commandStock As New MySqlCommand(quaryStock, connection)
                Dim commandLogsContentor As New MySqlCommand(quaryLogsContentor, connection)
                Dim commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)
                Dim commandPagamentos As New MySqlCommand(quaryPagamentos, connection)

                command.Parameters.AddWithValue("@value1", inputPedra)
                commandLogsContentor.Parameters.AddWithValue("@value1", inputPedra)

                command.Parameters.AddWithValue("@value2", inputAreia)
                commandLogsContentor.Parameters.AddWithValue("@value2", inputAreia)

                command.Parameters.AddWithValue("@value3", OutStorage.outputTrabalhador)
                commandLogsContentor.Parameters.AddWithValue("@value3", OutStorage.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)

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

                If outputdinheiro >= 0 Then
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
                    commandStock.Parameters.AddWithValue("@value8", OutStorage.outputTrabalhador)
                    commandStock.ExecuteNonQuery()
                End If

                If commandLogsRoloute.Parameters("@value2").Value <> 0 OrElse commandLogsRoloute.Parameters("@value3").Value <> 0 OrElse commandLogsRoloute.Parameters("@value4").Value <> 0 OrElse commandLogsRoloute.Parameters("@value5").Value <> 0 Then
                    commandLogsRoloute.ExecuteNonQuery()
                End If

                commandPagamentos.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                commandPagamentos.Parameters.AddWithValue("@value2", outputPagamento)
                commandPagamentos.Parameters.AddWithValue("@value3", data)

                If outputdinheiro < 0 Then
                    commandPagamentos.ExecuteNonQuery()
                End If

            End Using

            Using command As New MySqlCommand(quarySalários, connection)

                command.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", Salário)
                command.Parameters.AddWithValue("@value3", data)

                If checkFerro.Checked = False AndAlso checkCobre.Checked = False AndAlso checkPrata.Checked = False AndAlso checkVidro.Checked = False Then
                    command.ExecuteNonQuery()
                End If

            End Using

        End Using

        'Reset da app

        txtPedra.Text = "" : txtAreia.Text = "" : txtMinério.Text = "" : checkCobre.Checked = False : checkFerro.Checked = False : checkPrata.Checked = False
        checkVidro.Checked = False : lblCobre.Text = "" : lblFatura.Text = "" : lblEnxofre.Text = "" : lblFerro.Text = "" : lblNiquel.Text = "" : lblPrata.Text = ""
        lblVidro.Text = ""
        MsgBox("Venda de materiais registada!", MsgBoxStyle.Information, "Aviso")

    End Sub

    'Checkbox para meter em stock
    Private Sub checkFerro_CheckedChanged(sender As Object, e As EventArgs) Handles checkFerro.CheckedChanged
        CalcularFatura()
    End Sub

    Private Sub checkPrata_CheckedChanged(sender As Object, e As EventArgs) Handles checkPrata.CheckedChanged
        CalcularFatura()
    End Sub

    Private Sub checkCobre_CheckedChanged(sender As Object, e As EventArgs) Handles checkCobre.CheckedChanged
        CalcularFatura()
    End Sub

    Private Sub checkVidro_CheckedChanged(sender As Object, e As EventArgs) Handles checkVidro.CheckedChanged
        CalcularFatura()
    End Sub

    'Registo de Cliente
    Private Sub btnGuardarCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCliente.Click

        If txtNomeCliente.Text = "" Or txtTelemovelCliente.Text = "" Or seletorEquipas.SelectedIndex = -1 Then
            MsgBox("Preenche todos os campos", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        ElseIf Len(txtTelemovelCliente.Text) <> 9 Then
            MsgBox("Um número de telemovel tem que conter 9 digitos!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim queryRegistarCliente As String = "INSERT INTO `Clientes` (`Nome`, `Número`, `Equipa`, `Efetuado Por`) VALUES (@value1,@value2,@value3,@value4)"
            Using command As New MySqlCommand(queryRegistarCliente, connection)

                Dim Nome As String = txtNomeCliente.Text
                Dim Equipa As String = seletorEquipas.SelectedItem.ToString()
                Dim Número As Integer = txtTelemovelCliente.Text

                command.Parameters.AddWithValue("@value1", Nome)
                command.Parameters.AddWithValue("@value2", Número)
                command.Parameters.AddWithValue("@value3", Equipa)
                command.Parameters.AddWithValue("@value4", OutStorage.outputTrabalhador)

                Dim queryVerificarRepetoçãoNumero As String = "Select * FROM Clientes WHERE Número = @value1"
                Using comandVerificarNumeroRepetido As New MySqlCommand(queryVerificarRepetoçãoNumero, connection)

                    comandVerificarNumeroRepetido.Parameters.AddWithValue("@value1", Número)

                    Dim reader As MySqlDataReader = comandVerificarNumeroRepetido.ExecuteReader()

                    If reader.HasRows Then
                        reader.Close()
                        MsgBox("O cliente já se encontra registado", MsgBoxStyle.Critical, "Aviso")
                    Else
                        reader.Close()
                        command.ExecuteNonQuery()
                        txtNomeCliente.Clear() : txtTelemovelCliente.Clear() : seletorEquipas.SelectedIndex = -1
                        MsgBox("Registo de cliente efetuado", MsgBoxStyle.Information, "Aviso")
                    End If
                End Using
            End Using
        End Using

    End Sub

    'Pesquisa do número do cliente
    Private Sub SearchNumber()
        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim querySearchNumber As String = "Select `Nome`, `Equipa` FROM Clientes WHERE Número = @value1"
            Using commmandSearchNumber As New MySqlCommand(querySearchNumber, connection)

                commmandSearchNumber.Parameters.AddWithValue("@value1", Telemovel)
                Dim reader As MySqlDataReader = commmandSearchNumber.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Equipa = reader.GetString(reader.GetOrdinal("Equipa")) : Cliente = reader.GetString(reader.GetOrdinal("Nome"))
                    VerificarCompraDrill()
                    pnlCliente.Visible = False : pnlAtendimento.Visible = True
                    lblCliente.Text = Cliente : lblEquipa.Text = Equipa
                Else
                    MsgBox("O cliente não está registado, efetua o registo", MsgBoxStyle.Critical, "Aviso")
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    'Craft de polvora
    Private Sub txtQuantidadePolvora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidadePolvora.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalcularPolvora()
        Dim QuantidadeAEntregar As Integer

        If txtQuantidadePolvora.Text = "" Then
            QuantidadeAEntregar = 0
        Else
            Using connection As New MySqlConnection(connString)

                connection.Open()
                Dim Query As String = "Select `% Polvora` FROM Equipas WHERE Equipa = @value1"

                Using Command As New MySqlCommand(Query, connection)

                    Command.Parameters.AddWithValue("@value1", Equipa)
                    Dim reader As MySqlDataReader = Command.ExecuteReader()

                    reader.Read()

                    Dim PercPolvora As String

                    PercPolvora = reader.GetString(reader.GetOrdinal("% Polvora"))

                    QuantidadeAEntregar = txtQuantidadePolvora.Text * (100 - PercPolvora) / 100

                End Using

            End Using
        End If


        lblQuantidadePolvora.Text = QuantidadeAEntregar
    End Sub

    Private Sub txtQuantidadePolvora_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidadePolvora.TextChanged
        CalcularPolvora()
    End Sub

    Private Sub btnGuardarPolvora_Click(sender As Object, e As EventArgs) Handles btnGuardarPolvora.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Polvora`, `Trabalhador`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"
            Dim query As String = "INSERT INTO `Polvora` (`Quantidade`, `Trabalhador`, `Equipa`, `Cliente`, `Entregue`, `Data`, `Contacto`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"
            Dim Data As String = DateAndTime.Now

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", txtQuantidadePolvora.Text)
                command.Parameters.AddWithValue("@value2", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value3", Equipa)
                command.Parameters.AddWithValue("@value4", Cliente)
                command.Parameters.AddWithValue("@value5", lblQuantidadePolvora.Text)
                command.Parameters.AddWithValue("@value6", Data)
                command.Parameters.AddWithValue("@value7", Telemovel)

                command.ExecuteNonQuery()

            End Using

            Dim log As Integer = txtQuantidadePolvora.Text - lblQuantidadePolvora.Text
            Using commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)
                If log <> 0 Then
                    commandLogsRoloute.Parameters.AddWithValue("@value1", log)
                Else
                    MsgBox("Craft de polvora registado!", MsgBoxStyle.Information, "Aviso")
                    txtQuantidadePolvora.Clear() : lblQuantidadePolvora.Text = ""
                    Exit Sub
                End If
                commandLogsRoloute.Parameters.AddWithValue("@value2", OutStorage.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value3", "Roloute")
                commandLogsRoloute.Parameters.AddWithValue("@value4", Data)
                commandLogsRoloute.ExecuteNonQuery()

            End Using

            txtQuantidadePolvora.Clear() : lblQuantidadePolvora.Text = ""
            MsgBox("Craft de polvora registado!", MsgBoxStyle.Information, "Aviso")

        End Using
    End Sub

    Private Sub VerificarDatas()

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim query As String = "Select COUNT(*) FROM `Minning Drill` WHERE Data = @data AND Classe = @value1"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@data", Date.Today)
                command.Parameters.AddWithValue("@value1", "VENDA")
                DrillsQuantidadeVendida = command.ExecuteScalar()

            End Using
        End Using
    End Sub

    Private Sub CalcularFaturaDrills()
        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim Query As String = "Select `Valor Drill` FROM Equipas WHERE Equipa = @value1"

            Using Command As New MySqlCommand(Query, connection)

                Command.Parameters.AddWithValue("@value1", Equipa)
                Dim reader As MySqlDataReader = Command.ExecuteReader()

                Dim ValorDrill As String
                reader.Read()

                ValorDrill = reader.GetString(reader.GetOrdinal("Valor Drill"))
                DrillsQuantidadeUsadas = txtDrillsUsadas.Text

                If String.IsNullOrWhiteSpace(txtDrillsUsadas.Text) Then
                    DrillsQuantidadeUsadas = 0
                End If

                If checkDrillsUsadas.Checked = False Then
                    DrillsQuantidadeUsadas = 0
                End If

                mUsada = 7500 * DrillsQuantidadeUsadas

                DrillsFatura = ValorDrill - mUsada
                If DrillsQuantidadeVendida = DrillsDiarias Or JaAdquirida = True Then
                    lblDrillFaturas.Text = 0
                    lblDrillFaturas.ForeColor = Color.Gray
                Else
                    lblDrillFaturas.Text = DrillsFatura
                    lblDrillFaturas.ForeColor = Color.Green
                End If

            End Using
        End Using
    End Sub

    Private Sub checkDrillsUsadas_CheckedChanged(sender As Object, e As EventArgs) Handles checkDrillsUsadas.CheckedChanged
        If checkDrillsUsadas.Checked = True Then
            txtDrillsUsadas.Visible = True
        Else
            txtDrillsUsadas.Visible = False
        End If

        txtDrillsUsadas.Text = ""
        CalcularFaturaDrills()
        VerificarCompraDrill()
    End Sub



    Private Sub txtDrillsUsadas_TextChanged(sender As Object, e As EventArgs) Handles txtDrillsUsadas.TextChanged

        Dim Quantidade As String

        If String.IsNullOrWhiteSpace(txtDrillsUsadas.Text) Then
            Quantidade = 0
        Else
            Quantidade = txtDrillsUsadas.Text
        End If

        If Equipa <> "Minas" Then
            If Quantidade > 8 Then
                MsgBox("Só podes aceitar no máximo 8 Drill's", MsgBoxStyle.Critical, "Aviso")
                txtDrillsUsadas.Text = ""
                Exit Sub
            End If

        Else
            If Quantidade > 10 Then
                MsgBox("Só podes aceitar no máximo 10 Drill's", MsgBoxStyle.Critical, "Aviso")
                txtDrillsUsadas.Text = ""
                Exit Sub
            End If
        End If
        CalcularFaturaDrills()
    End Sub

    Private Sub btnVenderDrills_Click(sender As Object, e As EventArgs) Handles btnVenderDrills.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Data As String = DateAndTime.Now
            Dim query As String = "INSERT INTO `Minning Drill` (`Trabalhador`, `Data`, `Drill's Usadas`, `Telémovel`, `Classe`) VALUES (@value1,@value2,@value3,@value4,@value5)"
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Borracha`, `Parafusos`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using Command As New MySqlCommand(query, connection)
                Dim commandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)

                Command.Parameters.AddWithValue("@value1", outputTrabalhador)
                Command.Parameters.AddWithValue("@value2", Date.Today)
                Command.Parameters.AddWithValue("@value3", DrillsQuantidadeUsadas)
                Command.Parameters.AddWithValue("@value4", Telemovel)
                Command.Parameters.AddWithValue("@value5", "VENDA")

                Command.ExecuteNonQuery()

                commandLogsRoloute.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                commandLogsRoloute.Parameters.AddWithValue("@value2", -90)
                commandLogsRoloute.Parameters.AddWithValue("@value3", -15)
                commandLogsRoloute.Parameters.AddWithValue("@value4", -30)
                commandLogsRoloute.Parameters.AddWithValue("@value5", -5)
                commandLogsRoloute.Parameters.AddWithValue("@value6", "Roloute")
                commandLogsRoloute.Parameters.AddWithValue("@value7", Data)
                commandLogsRoloute.ExecuteNonQuery()

            End Using

        End Using
        VerificarCompraDrill()
        lblDrillFaturas.ForeColor = Color.Gray : lblDrillFaturas.Text = 0 : checkDrillsUsadas.Checked = False
        MsgBox("Venda de Drill Registada!", MsgBoxStyle.Information, "Aviso")
    End Sub

    'Sistema de stock das stashes
    '=================================================================================================================================================================================

    Private Sub AtualizarQuantidadesStock()

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
                lblStockPedra.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryAreia, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockAreia.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryCarvão, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockCarvão.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryMinério, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockMinério.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryNiquel, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockNíquel.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryEnxofre, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockEnxofre.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryFerro, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockFerro.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryPrata, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockPrata.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryCobre, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockCobre.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryVidro, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockVidro.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryPolvora, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockPolvora.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryBorracha, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockBorracha.Text = resultado

            End Using

            Using Command As New MySqlCommand(queryParafusos, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockParafusos.Text = resultado

            End Using

            Using Command As New MySqlCommand(querySafiras, connection)

                Dim resultado As Integer = Convert.ToInt32(Command.ExecuteScalar())
                lblStockSafiras.Text = resultado

            End Using
        End Using
    End Sub

    Private Sub btnRetirarStashes_Click(sender As Object, e As EventArgs) Handles btnRetirarStashes.Click

        Using connection As New MySqlConnection(connString)
            Dim Materias As String = seletorMateriais.SelectedItem.ToString
            Dim quantidade As String = txtQuantidadeStashes.Text
            Dim data As String = DateAndTime.Now
            Dim query As String = "INSERT INTO `Logs` (`Trabalhador`, `" & Materias & "`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", -quantidade)

                If Materias = "Pedra" Or Materias = "Areia" Or Materias = "Carvão" Or Materias = "Minério" Or Materias = "Níquel" Or Materias = "Enxofre" Then
                    command.Parameters.AddWithValue("@value3", "Contentor")
                Else
                    command.Parameters.AddWithValue("@value3", "Roloute")
                End If

                command.Parameters.AddWithValue("@value4", data)

                command.ExecuteNonQuery()

                MsgBox("Registo efetuado com sucesso", MsgBoxStyle.Information, "Aviso")

            End Using

        End Using
        txtQuantidadeStashes.Text = ""
        seletorMateriais.SelectedIndex = -1
        AtualizarQuantidadesStock()
    End Sub

    Private Sub btnAdicionarStashes_Click(sender As Object, e As EventArgs) Handles btnAdicionarStashes.Click

        Using connection As New MySqlConnection(connString)
            Dim Materias As String = seletorMateriais.SelectedItem.ToString
            Dim quantidade As String = txtQuantidadeStashes.Text
            Dim data As String = DateAndTime.Now
            Dim query As String = "INSERT INTO `Logs` (`Trabalhador`, `" & Materias & "`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4)"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                command.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", quantidade)

                If Materias = "Pedra" Or Materias = "Areia" Or Materias = "Carvão" Or Materias = "Minério" Or Materias = "Níquel" Or Materias = "Enxofre" Then
                    command.Parameters.AddWithValue("@value3", "Contentor")
                Else
                    command.Parameters.AddWithValue("@value3", "Roloute")
                End If

                command.Parameters.AddWithValue("@value4", data)

                command.ExecuteNonQuery()

                MsgBox("Registo efetuado com sucesso", MsgBoxStyle.Information, "Aviso")

            End Using

        End Using

        txtQuantidadeStashes.Text = ""
        seletorMateriais.SelectedIndex = -1
        AtualizarQuantidadesStock()
    End Sub

    'Sistema Processos
    '================================================================================================================================================================================
    Private Sub btnGuardarProcessoLegal_Click(sender As Object, e As EventArgs)

        'Registos de processo e de logs

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Pedra As String = txtProcessoPedra.Text
            Dim Areia As String = txtProcessoAreia.Text
            Dim Trabalhador As String = OutStorage.outputTrabalhador
            Dim Ferro As String = txtProcessoFerro.Text
            Dim Prata As String = txtProcessoPrata.Text
            Dim Cobre As String = txtProcessoCobre.Text
            Dim Vidro As String = txtProcessoVidro.Text
            Dim Data As String = DateAndTime.Now

            'Condições para deixar textboxs em branco

            If String.IsNullOrEmpty(txtProcessoPedra.Text) Then
                Pedra = 0
            End If

            If String.IsNullOrEmpty(txtProcessoAreia.Text) Then
                Areia = 0
            End If

            If String.IsNullOrEmpty(txtProcessoFerro.Text) Then
                Ferro = 0
            End If

            If String.IsNullOrEmpty(txtProcessoCobre.Text) Then
                Cobre = 0
            End If

            If String.IsNullOrEmpty(txtProcessoPrata.Text) Then
                Prata = 0
            End If

            If String.IsNullOrEmpty(txtProcessoVidro.Text) Then
                Vidro = 0
            End If

            'Condição para introduzir apenas numeros

            If IsNumeric(Pedra) = False Or IsNumeric(Areia) = False Or IsNumeric(Ferro) = False Or IsNumeric(Prata) = False Or IsNumeric(Cobre) = False Or IsNumeric(Vidro) = False Then
                MsgBox("Introduzir apenas números!", MsgBoxStyle.Critical, "Aviso")
                txtProcessoAreia.Text = ""
                txtProcessoPedra.Text = ""
                txtProcessoFerro.Text = ""
                txtProcessoPrata.Text = ""
                txtProcessoCobre.Text = ""
                txtProcessoVidro.Text = ""
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
                CommandLogsContentor.Parameters.AddWithValue("@value3", OutStorage.outputTrabalhador)
                CommandLogsContentor.Parameters.AddWithValue("@value4", "Contentor")
                CommandLogsContentor.Parameters.AddWithValue("@value5", Data)

                CommandLogsContentor.ExecuteNonQuery()

            End Using

            Using CommandLogsRoloute As New MySqlCommand(quaryLogsRoloute, connection)

                CommandLogsRoloute.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
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

            If OutStorage.outputTrabalhador = "morgado" Then
                ValorPedra = 12 + (2 * Rnd())
                ValorAreia = 7 + (1 * Rnd())
                Salário = (Pedra * ValorPedra) + (Areia * ValorAreia)
            End If

            'Registo do Salário na tabela de pagamentos

            Dim quarySalários As String = "INSERT INTO `Pagamentos` (`Trabalhador`, `Pagamento`, `Data`) VALUES (@value1,@value2,@value3)"
            Using command As New MySqlCommand(quarySalários, connection)

                command.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value2", Salário)
                command.Parameters.AddWithValue("@value3", Data)

                command.ExecuteNonQuery()

            End Using
            'Reset da app

            txtProcessoAreia.Text = ""
            txtProcessoCobre.Text = ""
            txtProcessoFerro.Text = ""
            txtProcessoPedra.Text = ""
            txtProcessoPrata.Text = ""
            txtProcessoVidro.Text = ""
            MsgBox("Registo efetuado com sucesso", MsgBoxStyle.Information, "Aviso")

        End Using
    End Sub

    Private Sub btnGuardarProcessoMinerio_Click(sender As Object, e As EventArgs) Handles btnGuardarProcessoMinerio.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            If txtProcessoMinério.Text = "" Or txtProcessoNíquel.Text = "" Or txtProcessoEnxofre.Text = "" Or txtProcessoSafiras.Text = "" Then
                MsgBox("Insere os valores todos!", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If

            Dim Minério As Integer = txtProcessoMinério.Text
            Dim Níquel As Integer = txtProcessoNíquel.Text
            Dim Trabalhador As String = OutStorage.outputTrabalhador
            Dim Enxofre As Integer = txtProcessoEnxofre.Text
            Dim Safiras As Integer = txtProcessoSafiras.Text
            Dim Data As String = DateAndTime.Now
            Dim descrição As String = txtDescrição.Text

            Dim QueryProcesso As String = "INSERT INTO `Processo Minério` (`Minério`, `Níquel`, `Enxofre`, `Safíras`, `Trabalhador`, `Data`, `Descrição`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"
            Dim QuaryLogs As String = "INSERT INTO `Logs` (`Minério`, `Níquel`, `Enxofre`, `Safiras`, `Trabalhador`, `Data`, `Stash`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using command As New MySqlCommand(QueryProcesso, connection)

                command.Parameters.AddWithValue("@value1", Minério)
                command.Parameters.AddWithValue("@value2", Níquel)
                command.Parameters.AddWithValue("@value3", Enxofre)
                command.Parameters.AddWithValue("@value4", Safiras)
                command.Parameters.AddWithValue("@value5", Trabalhador)
                command.Parameters.AddWithValue("@value6", Data)
                command.Parameters.AddWithValue("@value7", descrição)

                command.ExecuteNonQuery()

            End Using

            If txtDescrição.Text = "" Then
                Using command As New MySqlCommand(QuaryLogs, connection)

                    command.Parameters.AddWithValue("@value1", -Minério)
                    command.Parameters.AddWithValue("@value2", Níquel)
                    command.Parameters.AddWithValue("@value3", Enxofre)
                    command.Parameters.AddWithValue("@value4", Safiras)
                    command.Parameters.AddWithValue("@value5", Trabalhador)
                    command.Parameters.AddWithValue("@value6", Data)
                    command.Parameters.AddWithValue("@value7", "Contentor")

                    command.ExecuteNonQuery()

                End Using

            End If

            MsgBox("Registo efetuado com sucesso", MsgBoxStyle.Information, "Aviso")
            txtProcessoMinério.Clear()
            txtProcessoNíquel.Clear()
            txtProcessoEnxofre.Clear()
            txtProcessoSafiras.Clear()
            txtDescrição.Clear()

        End Using
    End Sub

    Private Sub btnAtualizarStock_Click(sender As Object, e As EventArgs) Handles btnAtualizarStock.Click
        AtualizarQuantidadesStock()
    End Sub



    'Sistema de getão de stocks de equipas
    '================================================================================================================================================================================

    Private Sub btnSearchTeams_Click(sender As Object, e As EventArgs) Handles gamalheu.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim queryFerro As String = "SELECT SUM(ferro) FROM Stocks WHERE Equipa = @value1"
            Dim queryPrata As String = "SELECT SUM(prata) FROM Stocks WHERE Equipa = @value1"
            Dim queryCobre As String = "SELECT SUM(cobre) FROM Stocks WHERE Equipa = @value1"
            Dim queryVidro As String = "SELECT SUM(vidro) FROM Stocks WHERE Equipa = @value1"
            Dim queryPedra As String = "SELECT SUM(pedra) FROM `Venda de Materiais` WHERE Equipa = @value1"
            Dim queryAreia As String = "SELECT SUM(areia) FROM `Venda de Materiais` WHERE Equipa = @value1"
            Dim queryMinério As String = "SELECT SUM(minério) FROM `Venda de Materiais` WHERE Equipa = @value1"

            Using command As New MySqlCommand(queryFerro, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultFerro As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultFerro = Convert.ToInt32(result)
                Else
                    resultFerro = 0
                End If

                lblEquipaFerro.Text = resultFerro
            End Using

            Using command As New MySqlCommand(queryPrata, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultPrata As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultPrata = Convert.ToInt32(result)
                Else
                    resultPrata = 0
                End If

                lblEquipaPrata.Text = resultPrata
            End Using

            Using command As New MySqlCommand(queryCobre, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultCobre As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultCobre = Convert.ToInt32(result)
                Else
                    resultCobre = 0
                End If

                lblEquipaCobre.Text = resultCobre
            End Using

            Using command As New MySqlCommand(queryVidro, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultVidro As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultVidro = Convert.ToInt32(result)
                Else
                    resultVidro = 0
                End If

                lblEquipaVidro.Text = resultVidro
            End Using

            Using command As New MySqlCommand(queryPedra, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultPedra As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultPedra = Convert.ToInt32(result)
                Else
                    resultPedra = 0
                End If

                lblEquipaPedra.Text = resultPedra
            End Using

            Using command As New MySqlCommand(queryAreia, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultAreia As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultAreia = Convert.ToInt32(result)
                Else
                    resultAreia = 0
                End If

                lblEquipaAreia.Text = resultAreia
            End Using

            Using command As New MySqlCommand(queryMinério, connection)
                command.Parameters.AddWithValue("@value1", Equipa)

                Dim result As Object = command.ExecuteScalar()
                Dim resultMinério As Integer = 0
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultMinério = Convert.ToInt32(result)
                Else
                    resultMinério = 0
                End If

                lblEquipaMinério.Text = resultMinério
            End Using
        End Using

    End Sub

    Private Sub CalcularFaturaStocks()

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim Query As String = "SELECT `Valor Pedra`, `Valor Areia`, `Valor Ferro`, `Valor Prata`, `Valor Cobre`, `Valor Vidro` FROM Equipas WHERE Equipa = @value1"

            Using Command As New MySqlCommand(Query, connection)

                Command.Parameters.AddWithValue("@value1", Equipa)
                Dim reader As MySqlDataReader = Command.ExecuteReader()

                reader.Read()

                Dim ValorPedraStocks, ValorAreiaStocks, ValorFerroStocks, ValorPrataStocks, ValorCobreStocks, ValorVidroStocks, FaturaEquipas As Integer
                Dim ParcelaEquipasFerro, ParcelaEquipasPrata, ParcelaEquipasCobre, ParcelaEquipasVidro As String

                If txtRetirarFerro.Text = "" Then
                    ParcelaEquipasFerro = 0
                Else
                    ParcelaEquipasFerro = txtRetirarFerro.Text
                End If

                If txtRetirarPrata.Text = "" Then
                    ParcelaEquipasPrata = 0
                Else
                    ParcelaEquipasPrata = txtRetirarPrata.Text
                End If

                If txtRetirarCobre.Text = "" Then
                    ParcelaEquipasCobre = 0
                Else
                    ParcelaEquipasCobre = txtRetirarCobre.Text
                End If

                If txtRetirarVidro.Text = "" Then
                    ParcelaEquipasVidro = 0
                Else
                    ParcelaEquipasVidro = txtRetirarVidro.Text
                End If

                ValorPedraStocks = reader.GetString(reader.GetOrdinal("Valor Pedra"))
                ValorAreiaStocks = reader.GetString(reader.GetOrdinal("Valor Areia"))
                ValorFerroStocks = reader.GetString(reader.GetOrdinal("Valor Ferro"))
                ValorPrataStocks = reader.GetString(reader.GetOrdinal("Valor Prata"))
                ValorCobreStocks = reader.GetString(reader.GetOrdinal("Valor Cobre"))
                ValorVidroStocks = reader.GetString(reader.GetOrdinal("Valor Vidro"))

                FaturaEquipas = ParcelaEquipasFerro * ValorFerroStocks + ParcelaEquipasCobre * ValorCobreStocks + ParcelaEquipasPrata * ValorPrataStocks + ParcelaEquipasVidro * ValorVidroStocks

                lblFaturaEquipas.Text = FaturaEquipas

                If FaturaEquipas > 0 Then
                    lblFaturaEquipas.ForeColor = Color.Green
                Else
                    lblFaturaEquipas.ForeColor = Color.Gray
                End If

            End Using
        End Using
    End Sub

    Private Sub txtRetirarFerro_TextChanged(sender As Object, e As EventArgs) Handles txtRetirarFerro.TextChanged

        If txtRetirarFerro.Text <> "" Then
            CalcularFaturaStocks()
        End If

    End Sub

    Private Sub txtRetirarPrata_TextChanged(sender As Object, e As EventArgs) Handles txtRetirarPrata.TextChanged

        If txtRetirarPrata.Text <> "" Then
            CalcularFaturaStocks()
        End If

    End Sub

    Private Sub btnGuardarProcessoPessoal_Click(sender As Object, e As EventArgs)

        'Registos de processo e de logs

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Pedra As String = txtPedraPessoal.Text
            Dim Areia As String = txtAreiaPessoal.Text
            Dim Trabalhador As String = OutStorage.outputTrabalhador
            Dim Ferro As String = txtFerroPessoal.Text
            Dim Prata As String = txtPrataPessoal.Text
            Dim Cobre As String = txtCobrePessoal.Text
            Dim Vidro As String = txtVidroPessoal.Text
            Dim Minerio As String = txtMinerioPessoal.Text
            Dim Niquel As String = txtNiquelPessoal.Text
            Dim Enxofre As String = txtEnxofrePessoal.Text
            Dim Polvora As String = txtPolvoraPessoal.Text
            Dim Safiras As String = txtSafirasPessoal.Text
            Dim Data As String = DateAndTime.Now

            'Condições para deixar textboxs em branco

            If String.IsNullOrEmpty(txtPedraPessoal.Text) Then
                Pedra = 0
            End If

            If String.IsNullOrEmpty(txtAreiaPessoal.Text) Then
                Areia = 0
            End If

            If String.IsNullOrEmpty(txtFerroPessoal.Text) Then
                Ferro = 0
            End If

            If String.IsNullOrEmpty(txtCobrePessoal.Text) Then
                Cobre = 0
            End If

            If String.IsNullOrEmpty(txtPrataPessoal.Text) Then
                Prata = 0
            End If

            If String.IsNullOrEmpty(txtVidroPessoal.Text) Then
                Vidro = 0
            End If

            If String.IsNullOrEmpty(txtMinerioPessoal.Text) Then
                Minerio = 0
            End If

            If String.IsNullOrEmpty(txtNiquelPessoal.Text) Then
                Niquel = 0
            End If

            If String.IsNullOrEmpty(txtEnxofrePessoal.Text) Then
                Enxofre = 0
            End If

            If String.IsNullOrEmpty(txtSafirasPessoal.Text) Then
                Safiras = 0
            End If

            If String.IsNullOrEmpty(txtPolvoraPessoal.Text) Then
                Polvora = 0
            End If

            'Condição para introduzir apenas numeros

            If IsNumeric(Pedra) = False Or IsNumeric(Areia) = False Or IsNumeric(Ferro) = False Or IsNumeric(Prata) = False Or IsNumeric(Cobre) = False Or IsNumeric(Vidro) = False Or IsNumeric(Minerio) = False Or IsNumeric(Niquel) = False Or IsNumeric(Enxofre) = False Or IsNumeric(Safiras) = False Or IsNumeric(Polvora) = False Then
                MsgBox("Introduzir apenas números!", MsgBoxStyle.Critical, "Aviso")
                txtAreiaPessoal.Text = ""
                txtPedraPessoal.Text = ""
                txtFerroPessoal.Text = ""
                txtPrataPessoal.Text = ""
                txtCobrePessoal.Text = ""
                txtVidroPessoal.Text = ""
                txtMinerioPessoal.Text = ""
                txtNiquelPessoal.Text = ""
                txtEnxofrePessoal.Text = ""
                txtSafirasPessoal.Text = ""
                txtPolvoraPessoal.Text = ""
                Exit Sub
            End If


            Dim query As String = "INSERT INTO `Processo Pessoal` (`Pedra`, `Areia`, `Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Data`, `Polvora`, `Minério`, `Níquel`, `Enxofre`, `Safíras`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12,@value13)"

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@value1", Pedra)
                command.Parameters.AddWithValue("@value2", Areia)
                command.Parameters.AddWithValue("@value3", Trabalhador)
                command.Parameters.AddWithValue("@value4", Ferro)
                command.Parameters.AddWithValue("@value5", Prata)
                command.Parameters.AddWithValue("@value6", Cobre)
                command.Parameters.AddWithValue("@value7", Vidro)
                command.Parameters.AddWithValue("@value8", Data)
                command.Parameters.AddWithValue("@value9", Polvora)
                command.Parameters.AddWithValue("@value10", Minerio)
                command.Parameters.AddWithValue("@value11", Niquel)
                command.Parameters.AddWithValue("@value12", Enxofre)
                command.Parameters.AddWithValue("@value13", Safiras)

                command.ExecuteNonQuery()
            End Using

            'Reset da app

            txtAreiaPessoal.Text = ""
            txtCobrePessoal.Text = ""
            txtFerroPessoal.Text = ""
            txtPedraPessoal.Text = ""
            txtPrataPessoal.Text = ""
            txtVidroPessoal.Text = ""
            txtMinerioPessoal.Text = ""
            txtNiquelPessoal.Text = ""
            txtEnxofrePessoal.Text = ""
            txtSafirasPessoal.Text = ""
            txtPolvoraPessoal.Text = ""
            MsgBox("Registo efetuado com sucesso", MsgBoxStyle.Information, "Aviso")

        End Using
    End Sub

    Private Sub txtRetirarCobre_TextChanged(sender As Object, e As EventArgs) Handles txtRetirarCobre.TextChanged

        If txtRetirarCobre.Text <> "" Then
            CalcularFaturaStocks()
        End If

    End Sub

    Private Sub txtRetirarVidro_TextChanged(sender As Object, e As EventArgs) Handles txtRetirarVidro.TextChanged

        If txtRetirarVidro.Text <> "" Then
            CalcularFaturaStocks()
        End If

    End Sub

    Private Sub btnGuardarStockEquipas_Click(sender As Object, e As EventArgs) Handles btnGuardarStockEquipas.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim QuantidadeFerro, QuantidadePrata, QuantidadeCobre, QuantidadeVidro, Data As String
            Data = DateAndTime.Now

            If txtRetirarFerro.Text = "" Then
                QuantidadeFerro = 0
            Else
                QuantidadeFerro = txtRetirarFerro.Text
            End If

            If txtRetirarPrata.Text = "" Then
                QuantidadePrata = 0
            Else
                QuantidadePrata = txtRetirarPrata.Text
            End If

            If txtRetirarCobre.Text = "" Then
                QuantidadeCobre = 0
            Else
                QuantidadeCobre = txtRetirarCobre.Text
            End If

            If txtRetirarVidro.Text = "" Then
                QuantidadeVidro = 0
            Else
                QuantidadeVidro = txtRetirarVidro.Text
            End If

            Dim quary As String = "INSERT INTO Stocks (Ferro, Prata, Cobre, Vidro, Equipa, Trabalhador, Cliente, Data) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)"
            Dim quaryLogsRoloute As String = "INSERT INTO `Logs` (`Trabalhador`, `Ferro`, `Prata`, `Cobre`, `Vidro`, `Stash`, `Data`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7)"

            Using command As New MySqlCommand(quary, connection)

                command.Parameters.AddWithValue("@value1", -QuantidadeFerro)
                command.Parameters.AddWithValue("@value2", -QuantidadePrata)
                command.Parameters.AddWithValue("@value3", -QuantidadeCobre)
                command.Parameters.AddWithValue("@value4", -QuantidadeVidro)
                command.Parameters.AddWithValue("@value5", Equipa)
                command.Parameters.AddWithValue("@value6", OutStorage.outputTrabalhador)
                command.Parameters.AddWithValue("@value7", Cliente)
                command.Parameters.AddWithValue("@value8", Data)

                command.ExecuteNonQuery()

            End Using

            Using CommandLogs As New MySqlCommand(quaryLogsRoloute, connection)

                CommandLogs.Parameters.AddWithValue("@value1", OutStorage.outputTrabalhador)
                CommandLogs.Parameters.AddWithValue("@value2", -QuantidadeFerro)
                CommandLogs.Parameters.AddWithValue("@value3", -QuantidadePrata)
                CommandLogs.Parameters.AddWithValue("@value4", -QuantidadeCobre)
                CommandLogs.Parameters.AddWithValue("@value5", -QuantidadeVidro)
                CommandLogs.Parameters.AddWithValue("@value6", "Roloute")
                CommandLogs.Parameters.AddWithValue("@value7", Data)

                CommandLogs.ExecuteNonQuery()

            End Using

            MsgBox("Registo efetuado!", MsgBoxStyle.Information, "Aviso")
            txtRetirarFerro.Clear()
            txtRetirarPrata.Clear()
            txtRetirarCobre.Clear()
            txtRetirarVidro.Clear()
            lblFaturaEquipas.Text = "0"
            lblFaturaEquipas.ForeColor = Color.Gray
            gamalheu.PerformClick()

        End Using

    End Sub
    'Sistema Administração
    '=============================================================================================================================================================================================================

    Private Sub checkValorDefault_CheckedChanged(sender As Object, e As EventArgs) Handles checkValorDefault.CheckedChanged

        If checkValorDefault.Checked = True Then
            txtValorPedra.Text = 80
            txtValorAreia.Text = 15
            txtValorFerro.Text = 185
            txtValorPrata.Text = 135
            txtValorCobre.Text = 235
            txtValorVidro.Text = 110
            txtValorPolvora.Text = 15
            txtValorDrill.Text = 80000

            txtValorPedra.Enabled = False
            txtValorAreia.Enabled = False
            txtValorFerro.Enabled = False
            txtValorPrata.Enabled = False
            txtValorCobre.Enabled = False
            txtValorVidro.Enabled = False
            txtValorPolvora.Enabled = False
            txtValorDrill.Enabled = False
        Else

            txtValorPedra.Enabled = True
            txtValorAreia.Enabled = True
            txtValorFerro.Enabled = True
            txtValorPrata.Enabled = True
            txtValorCobre.Enabled = True
            txtValorVidro.Enabled = True
            txtValorPolvora.Enabled = True
            txtValorDrill.Enabled = True

            txtValorPedra.Clear()
            txtValorAreia.Clear()
            txtValorFerro.Clear()
            txtValorPrata.Clear()
            txtValorCobre.Clear()
            txtValorVidro.Clear()
            txtValorPolvora.Clear()
            txtValorDrill.Clear()
        End If

    End Sub

    Private Sub btnRegistarEquipa_Click(sender As Object, e As EventArgs) Handles btnRegistarEquipa.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Query As String = "INSERT INTO `Equipas` (`Equipa`, `Valor Pedra`, `Valor Areia`, `Valor Ferro`, `Valor Prata`, `Valor Cobre`, `Valor Vidro`, `% Polvora`, `Valor Drill`) VALUES (@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9)"
            Using command As New MySqlCommand(Query, connection)

                command.Parameters.AddWithValue("@value1", txtRegistarEquipa.Text)
                command.Parameters.AddWithValue("@value2", txtValorPedra.Text)
                command.Parameters.AddWithValue("@value3", txtValorAreia.Text)
                command.Parameters.AddWithValue("@value4", txtValorFerro.Text)
                command.Parameters.AddWithValue("@value5", txtValorPrata.Text)
                command.Parameters.AddWithValue("@value6", txtValorCobre.Text)
                command.Parameters.AddWithValue("@value7", txtValorVidro.Text)
                command.Parameters.AddWithValue("@value8", txtValorPolvora.Text)
                command.Parameters.AddWithValue("@value9", txtValorDrill.Text)

                command.ExecuteNonQuery()

                MsgBox("Equipa registada!", MsgBoxStyle.Information, "Aviso")

                txtRegistarEquipa.Clear()
                txtValorPedra.Clear()
                txtValorAreia.Clear()
                txtValorFerro.Clear()
                txtValorPrata.Clear()
                txtValorCobre.Clear()
                txtValorVidro.Clear()
                txtValorPolvora.Clear()
                txtValorDrill.Clear()
                checkValorDefault.Checked = False

            End Using
        End Using

    End Sub

    'Sistema de login do cliente e Simulador
    '===================================================================================================================================================================================
    Private Sub btnLoginCliente_Click(sender As Object, e As EventArgs) Handles btnLoginCliente.Click
        If txtNúmero.Text = "" Then
            MsgBox("Insere o número de telemóvel", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        ElseIf Len(txtNúmero.Text) <> 9 Then
            MsgBox("Um número de telemovel tem que conter 9 digitos!", MsgBoxStyle.Critical, "Aviso")
            Exit Sub
        End If

        btnGuardar.Visible = True
        btnGuardarPolvora.Visible = True
        pnlSimulador.Visible = True
        EditarEquipaToolStripMenuItem.Visible = True
        Telemovel = txtNúmero.Text
        SearchNumber()
    End Sub

    Dim DrillsDiarias As String
    Private Sub VerificarCompraDrill()


        Dim QuantidadeDisponivel As Integer
        Dim JaCraftada As Boolean

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim Query As String = "SELECT `Drills Diarias` FROM `Parametros de Atendimento`"

            Using Command As New MySqlCommand(Query, connection)

                Dim reader As MySqlDataReader = Command.ExecuteReader()

                reader.Read()

                DrillsDiarias = reader.GetString(reader.GetOrdinal("Drills Diarias"))

            End Using
        End Using

        VerificarDatas()
        QuantidadeDisponivel = DrillsDiarias - DrillsQuantidadeVendida
        lblDrillsOutside.Text = QuantidadeDisponivel

        If txtNúmero.Text = "" Then
            Exit Sub
        Else

            Using connection As New MySqlConnection(connString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM `Minning Drill` WHERE Telémovel = @value1 AND Data = @value2 AND Classe = @value3"
                Dim query2 As String = "SELECT COUNT(*) FROM `Minning Drill` WHERE Telémovel = @value1 AND Data = @value2 AND Classe = @value3"
                Using commmand As New MySqlCommand(query, connection)

                    commmand.Parameters.AddWithValue("@value1", Telemovel)
                    commmand.Parameters.AddWithValue("@value2", Date.Today)
                    commmand.Parameters.AddWithValue("@value3", "VENDA")
                    Dim count As Integer = CInt(commmand.ExecuteScalar())

                    If count > 0 Then
                        JaAdquirida = True
                        btnVenderDrills.Enabled = False
                    Else
                        JaAdquirida = False
                        CalcularFaturaDrills()
                        btnVenderDrills.Enabled = True
                    End If

                    If DrillsQuantidadeVendida = DrillsDiarias Then
                        btnVenderDrills.Enabled = False
                    End If

                    Using command2 As New MySqlCommand(query2, connection)

                        command2.Parameters.AddWithValue("@value1", Telemovel)
                        command2.Parameters.AddWithValue("@value2", Date.Today)
                        command2.Parameters.AddWithValue("@value3", "CRAFT")
                        Dim count2 As Integer = CInt(command2.ExecuteScalar())

                        If count2 > 0 Then
                            JaCraftada = True
                            btnCraftDrills.Enabled = False
                        Else
                            JaCraftada = False
                            btnCraftDrills.Enabled = True
                        End If

                        If JaCraftada = True AndAlso JaAdquirida = True Then
                            lblDrills.Text = "Já Adquirida / Já Craftada"
                        ElseIf JaCraftada = True AndAlso JaAdquirida = False Then
                            lblDrills.Text = QuantidadeDisponivel & " / Já Craftada"
                        ElseIf JaCraftada = False AndAlso JaAdquirida = True Then
                            lblDrills.Text = "Já Adquirida / Por Craftar"
                        ElseIf JaCraftada = False AndAlso JaAdquirida = False Then
                            lblDrills.Text = QuantidadeDisponivel & " / Por Craftar"
                        End If

                    End Using
                End Using
            End Using

        End If

    End Sub

    Private Sub TerminarAtendimento(sender As Object, e As EventArgs) Handles TerminarToolStripMenuItem.Click

        Equipa = "" : Cliente = ""
        txtPedra.Text = ""
        txtAreia.Text = ""
        txtMinério.Text = ""
        txtQuantidadePolvora.Text = ""

        txtNúmero.Clear()
        btnAtendimento.PerformClick()
        txtNúmero.Focus()

    End Sub

    Private Sub btnSimulador_Click(sender As Object, e As EventArgs) Handles btnSimulador.Click

        If rdnComEquipa.Checked = True Then
            Telemovel = 123456789
        Else
            Telemovel = 987654321
        End If

        btnGuardar.Visible = False
        btnGuardarPolvora.Visible = False
        pnlSimulador.Visible = False
        EditarEquipaToolStripMenuItem.Visible = False

        SearchNumber()
    End Sub

    Private Sub txtNúmero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNúmero.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLoginCliente.PerformClick()
        End If
    End Sub

    Private Sub btnConsultarPagamentos_Click(sender As Object, e As EventArgs) Handles btnConsultarPagamentos.Click

        'Dim query As String = "Select COUNT(Username) FROM Login"
        'Dim queryNomes As String = "SELECT Username FROM Login"
        'Dim querySalário As String = "SELECT SUM(Pagamento) FROM Pagamentos WHERE Trabalhador = @value1"



    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim resposta As DialogResult = MessageBox.Show("Tens a certeza? Isto apagará todos os registos de salários!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Using connection As New MySqlConnection(connString)
                connection.Open()
                Dim query As String = "DELETE FROM Pagamentos"

                Using command As New MySqlCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using

            End Using
        End If
    End Sub

    Private Sub btnCraftDrills_Click(sender As Object, e As EventArgs) Handles btnCraftDrills.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim Data As String = DateAndTime.Now
            Dim query As String = "INSERT INTO `Minning Drill` (`Trabalhador`, `Data`, `Drill's Usadas`, `Telémovel`, `Classe`) VALUES (@value1,@value2,@value3,@value4,@value5)"

            Using Command As New MySqlCommand(query, connection)

                Command.Parameters.AddWithValue("@value1", outputTrabalhador)
                Command.Parameters.AddWithValue("@value2", Date.Today)
                Command.Parameters.AddWithValue("@value3", 0)
                Command.Parameters.AddWithValue("@value4", Telemovel)
                Command.Parameters.AddWithValue("@value5", "CRAFT")

                Command.ExecuteNonQuery()

            End Using

        End Using

        VerificarCompraDrill()
        MsgBox("Craft de Drill Registado!", MsgBoxStyle.Information, "Aviso")

    End Sub

    Private Sub btnTabelas_Click(sender As Object, e As EventArgs) Handles btnTabelas.Click
        Base_Dados.Show()
    End Sub

    Private Sub btnAlterarEquipa_Click(sender As Object, e As EventArgs) Handles EditarEquipaToolStripMenuItem.Click

        pnlAtendimento.Visible = False
        pnlEditarEquipa.Visible = True

        lblEquipaAtual.Text = Equipa

        'Inserção das equipas na combobox

        If seletorAEquipa.Items.Count = 0 Then
            'Load das equipas
            Using Connection As New MySqlConnection(connString)
                Connection.Open()

                Dim queryEquipas As String = "Select Equipa FROM Equipas"
                Using commandEquipas As New MySqlCommand(queryEquipas, Connection)
                    Dim reader As MySqlDataReader = commandEquipas.ExecuteReader()

                    While reader.Read()

                        seletorAEquipa.Items.Add(reader.GetString("Equipa"))

                    End While

                    reader.Close()

                    'Colocação em ordem alfabética

                    Dim items As String() = seletorAEquipa.Items.Cast(Of String)().ToArray()
                    Array.Sort(items)
                    seletorAEquipa.Items.Clear()
                    seletorAEquipa.Items.AddRange(items)

                End Using
            End Using
        End If

    End Sub

    Private Sub ListBoxTrabalhadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTrabalhadores.SelectedIndexChanged

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim quarySalários As String = "SELECT SUM(Pagamento) FROM Pagamentos WHERE Trabalhador = @value1"
            'Dim quaryOff As String = 

            Using commandSalário As New MySqlCommand(quarySalários, connection)

                commandSalário.Parameters.AddWithValue("@value1", ListBoxTrabalhadores.SelectedItem.ToString())

                Dim sal As String = commandSalário.ExecuteNonQuery()
                lblValorSalario.Text = sal

            End Using

        End Using

    End Sub

    Private Sub btnGuardarAlteração_Click(sender As Object, e As EventArgs) Handles btnGuardarAlteração.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()

            Dim query As String = "UPDATE `Clientes` SET `Equipa` = @value1 WHERE `Número` = @value2"

            Using Command As New MySqlCommand(query, connection)

                Command.Parameters.AddWithValue("@value1", seletorAEquipa.SelectedItem.ToString())
                Command.Parameters.AddWithValue("@value2", Telemovel)

                Command.ExecuteNonQuery()

            End Using
        End Using

        MsgBox("Alteração de equipa registada!", MsgBoxStyle.Information, "Aviso")

        btnFecharAEquipa.PerformClick()
        TerminarToolStripMenuItem.PerformClick()
        txtNúmero.Text = Telemovel
        btnLoginCliente.PerformClick()

    End Sub

    Private Sub btnFecharAEquipa_Click(sender As Object, e As EventArgs) Handles btnFecharAEquipa.Click
        pnlEditarEquipa.Visible = False
        pnlAtendimento.Visible = True
        seletorAEquipa.SelectedIndex = -1
    End Sub

    Dim tabelaCraft As New DataTable()
    Private Sub Craft(sender As Object, e As EventArgs) Handles btnCraft.Click

        'Paineis
        pnlOnButtonAtendimento.Visible = False
        pnlOnButtonProcessamento.Visible = False
        pnlOnButtonAdministração.Visible = False
        pnlOnButtonStock.Visible = False
        pnlOnButtonCraft.Visible = True
        pnlLogin.Visible = False
        pnlAtendimento.Visible = False
        pnlProcessamento.Visible = False
        pnlStock.Visible = False
        pnlAdministração.Visible = False
        pnlCliente.Visible = False
        pnlEditarEquipa.Visible = False
        pnlCraft.Visible = True

        tabelaCraft.Clear()
        Using connection As New MySqlConnection(connString)
            connection.Open()
            Dim query As String = "SELECT * FROM `Craft Armas`"

            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    tabelaCraft.Load(reader)
                End Using
            End Using

        End Using

        seletorArma.Items.Clear()
        seletorColete.Items.Clear()
        For Each row As DataRow In tabelaCraft.Rows

            If row("Categoria").ToString() = "Arma" Then
                Dim armas As String = row("Item").ToString()
                seletorArma.Items.Add(armas)
            End If

            If row("Categoria").ToString() = "Colete" Then
                Dim Colete As String = row("Item").ToString()
                seletorColete.Items.Add(Colete)
            End If

        Next

    End Sub

    Private Sub AdicionarAcess(sender As Object, e As EventArgs) Handles seletorArma.SelectedIndexChanged

        seletorAcessorio.Items.Clear()
        Dim arma As String = seletorArma.SelectedItem.ToString()

        For Each row As DataRow In tabelaCraft.Rows

            If row("Categoria").ToString() = arma Then
                Dim Acess As String = row("Item").ToString()
                seletorAcessorio.Items.Add(Acess)
            End If

        Next

    End Sub


    Dim contadorarmas As Integer = 0
    Dim armasencomenda(contadorarmas) As String
    Dim quantidadearmas(contadorarmas) As Integer
    Private Sub CraftAddArmas(sender As Object, e As EventArgs) Handles btnAddArmas.Click
        If seletorArma.SelectedIndex = -1 Then
            MsgBox("Seleciona uma arma!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        ElseIf txtQntArmas.Text = "" Then
            MsgBox("Insere a quantidade desejada!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Dim arma As String = seletorArma.SelectedItem.ToString()
        Dim quantidade As Integer = CInt(txtQntArmas.Text)
        Dim JaExiste As Boolean

        If contadorarmas <> 0 Then
            For i = 1 To armasencomenda.Length() - 1

                If armasencomenda(i) = arma Then
                    quantidadearmas(i) += quantidade
                    JaExiste = True
                End If

            Next
        End If

        lblArmas.Text = ""
        If JaExiste = True Then

            For i = 1 To armasencomenda.Length() - 1

                lblArmas.Text = lblArmas.Text & $"{quantidadearmas(i)}x {armasencomenda(i)}" & vbCrLf

            Next

        Else

            contadorarmas += 1
            ReDim Preserve armasencomenda(contadorarmas)
            ReDim Preserve quantidadearmas(contadorarmas)

            armasencomenda(contadorarmas) = arma
            quantidadearmas(contadorarmas) = quantidade

            For i = 1 To armasencomenda.Length() - 1
                lblArmas.Text = lblArmas.Text & $"{quantidadearmas(i)}x {armasencomenda(i)}" & vbCrLf
            Next

        End If

        AddMateriais(arma, quantidade, "Arma")
        txtQntArmas.Clear()
    End Sub

    Dim contadoracess As Integer = 0
    Dim encomendaacess(contadoracess) As String
    Dim quantidadeacess(contadoracess) As Integer
    Private Sub btnAddAcess_Click(sender As Object, e As EventArgs) Handles btnAddAcess.Click

        If seletorAcessorio.SelectedIndex = -1 Then
            MsgBox("Seleciona um acessório!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        ElseIf txtQntAcess.Text = "" Then
            MsgBox("Insere a quantidade desejada!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Dim acess As String = seletorAcessorio.SelectedItem.ToString()
        Dim arma As String = seletorArma.SelectedItem.ToString
        Dim quantidade As Integer = CInt(txtQntAcess.Text)
        Dim JaExiste As Boolean

        If contadoracess <> 0 Then
            For i = 1 To encomendaacess.Length() - 1

                If encomendaacess(i) = $"{acess} [{arma}]" Then
                    quantidadeacess(i) += quantidade
                    JaExiste = True
                End If

            Next
        End If

        lblAcess.Text = ""
        If JaExiste = True Then

            For i = 1 To encomendaacess.Length() - 1
                lblAcess.Text = lblAcess.Text & $"{quantidadeacess(i)}x {encomendaacess(i)}" & vbCrLf
            Next

        Else

            contadoracess += 1
            ReDim Preserve encomendaacess(contadoracess)
            ReDim Preserve quantidadeacess(contadoracess)

            encomendaacess(contadoracess) = $"{acess} [{arma}]"
            quantidadeacess(contadoracess) = quantidade

            For i = 1 To encomendaacess.Length() - 1
                lblAcess.Text = lblAcess.Text & $"{quantidadeacess(i)}x {encomendaacess(i)}" & vbCrLf
            Next

        End If

        AddMateriais(acess, quantidade, arma)
        seletorAcessorio.SelectedIndex = -1
        txtQntAcess.Clear()
    End Sub

    Dim contadorcoletes As Integer = 0
    Dim encomendacoletes(contadorcoletes) As String
    Dim quantidadecoletes(contadorcoletes) As Integer
    Private Sub btnAddColetes_Click(sender As Object, e As EventArgs) Handles btnAddColetes.Click


        If seletorColete.SelectedIndex = -1 Then
            MsgBox("Seleciona um colete!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        ElseIf txtQntColetes.Text = "" Then
            MsgBox("Insere a quantidade desejada!", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Dim colete As String = seletorColete.SelectedItem.ToString()
        Dim quantidade As Integer = CInt(txtQntColetes.Text)
        Dim JaExiste As Boolean

        If contadorcoletes <> 0 Then
            For i = 1 To encomendacoletes.Length() - 1

                If encomendacoletes(i) = colete Then
                    quantidadecoletes(i) += quantidade
                    JaExiste = True
                End If

            Next
        End If

        lblColetes.Text = ""
        If JaExiste = True Then

            For i = 1 To encomendacoletes.Length() - 1
                lblColetes.Text = lblColetes.Text & $"{quantidadecoletes(i)}x {encomendacoletes(i)}" & vbCrLf
            Next

        Else

            contadorcoletes += 1
            ReDim Preserve encomendacoletes(contadorcoletes)
            ReDim Preserve quantidadecoletes(contadorcoletes)

            encomendacoletes(contadorcoletes) = colete
            quantidadecoletes(contadorcoletes) = quantidade

            For i = 1 To encomendacoletes.Length() - 1
                lblColetes.Text = lblColetes.Text & $"{quantidadecoletes(i)}x {encomendacoletes(i)}" & vbCrLf
            Next

        End If

        AddMateriais(colete, quantidade, "Colete")
        seletorColete.SelectedIndex = -1
        txtQntColetes.Clear()

    End Sub

    Private Sub AddMateriais(item As String, quantidade As Integer, arma As String)

        Dim linhasFiltradas() As DataRow = tabelaCraft.Select($"item = '{item}' AND categoria = '{arma}'")

        If linhasFiltradas.Length > 0 Then

            Dim aço As Integer = linhasFiltradas(0)("Aço")
            Dim borracha As Integer = linhasFiltradas(0)("Borracha")
            Dim parafusos As Integer = linhasFiltradas(0)("Parafusos")
            Dim abs As Integer = linhasFiltradas(0)("ABS")
            Dim bronze As Integer = linhasFiltradas(0)("Bronze")
            Dim pmetal As Integer = linhasFiltradas(0)("Pdç. de Metal")
            Dim aluminio As Integer = linhasFiltradas(0)("Aluminio")
            Dim molas As Integer = linhasFiltradas(0)("Molas")
            Dim polimero As Integer = linhasFiltradas(0)("Polimero")
            Dim BPpistol As Integer = linhasFiltradas(0)("BP Pistol")
            Dim BPsmg As Integer = linhasFiltradas(0)("BP SMG")
            Dim BPrifle As Integer = linhasFiltradas(0)("BP Rifle")
            Dim nylon As Integer = linhasFiltradas(0)("Nylon")
            Dim couro As Integer = linhasFiltradas(0)("Couro")
            Dim tecido As Integer = linhasFiltradas(0)("Tecido")
            Dim prata As Integer = linhasFiltradas(0)("Prata")
            Dim vidro As Integer = linhasFiltradas(0)("Vidro")
            Dim restoseletro As Integer = linhasFiltradas(0)("Resto Electr.")
            Dim cobre As Integer = linhasFiltradas(0)("Cobre")
            Dim fibra As Integer = linhasFiltradas(0)("Fibra")
            Dim pele As Integer = linhasFiltradas(0)("Pele")
            Dim chifres As Integer = linhasFiltradas(0)("Chifres")

            txtAço.Text += aço * quantidade
            txtBorracha.Text += borracha * quantidade
            txtParafusos.Text += parafusos * quantidade
            txtABS.Text += abs * quantidade
            txtBronze.Text += bronze * quantidade
            txtPMetal.Text += pmetal * quantidade
            txtAluminio.Text += aluminio * quantidade
            txtMolas.Text += molas * quantidade
            txtPolimero.Text += polimero * quantidade
            txtbpPistol.Text += BPpistol * quantidade
            txtBPSMG.Text += BPsmg * quantidade
            txtBPRifle.Text += BPrifle * quantidade
            txtNylon.Text += nylon * quantidade
            txtCouro.Text += couro * quantidade
            txtTecido.Text += tecido * quantidade
            txtPrata.Text += prata * quantidade
            txtVidro.Text += vidro * quantidade
            txtRestos.Text += restoseletro * quantidade
            txtCobre.Text += cobre * quantidade
            txtFibra.Text += fibra * quantidade
            txtPele.Text += pele * quantidade
            txtChifres.Text += chifres * quantidade

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtAço.Text = 0
        txtBorracha.Text = 0
        txtParafusos.Text = 0
        txtABS.Text = 0
        txtBronze.Text = 0
        txtPMetal.Text = 0
        txtAluminio.Text = 0
        txtMolas.Text = 0
        txtPolimero.Text = 0
        txtbpPistol.Text = 0
        txtBPSMG.Text = 0
        txtBPRifle.Text = 0
        txtNylon.Text = 0
        txtCouro.Text = 0
        txtTecido.Text = 0
        txtPrata.Text = 0
        txtVidro.Text = 0
        txtRestos.Text = 0
        txtCobre.Text = 0
        txtFibra.Text = 0
        txtPele.Text = 0
        txtChifres.Text = 0

        lblArmas.Text = ""
        lblAcess.Text = ""
        lblColetes.Text = ""

        contadoracess = 0
        contadorarmas = 0
        contadorcoletes = 0

        ReDim encomendaacess(contadoracess)
        ReDim encomendacoletes(contadorcoletes)
        ReDim armasencomenda(contadorarmas)
        ReDim quantidadeacess(contadoracess)
        ReDim quantidadearmas(contadorarmas)
        ReDim quantidadecoletes(contadorcoletes)

    End Sub

    Private Sub txtacess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQntAcess.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtarmas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQntArmas.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcoletes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQntColetes.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEncomendar_Click(sender As Object, e As EventArgs) Handles btnEncomendar.Click

        Dim dbarmas As String = ""

        For i = 1 To armasencomenda.Length - 1

            dbarmas += quantidadearmas(i) & " " & armasencomenda(i) & ","

        Next

    End Sub
End Class