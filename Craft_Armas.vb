Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient

Public Class Craft_Armas
    Public Aluminio, Aço, Pedaços, Borracha, Bronze, Polimero, Molas, Parafusos, ABS, BPPistol, BPSMG, BPRifle As Integer

    Private Sub Craft_Armas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Introduzir menus no seletor de menus

        'Using Connection As New MySqlConnection(connString)
        '    Connection.Open()
        '    Try

        '        Dim query As String = "SELECT Menus FROM Menus"
        '        Dim command As New MySqlCommand(query, Connection)
        '        Dim reader As MySqlDataReader = command.ExecuteReader()

        '        While reader.Read()

        '            SeletorMenu.Items.Add(reader.GetString("Menus"))

        '        End While

        '        reader.Close()

        '    Catch ex As Exception
        '        MessageBox.Show("Error: " & ex.Message)

        '    End Try

        'End Using

        'Colocação em ordem alfabética

        'Dim itemsmenu As String() = SeletorMenu.Items.Cast(Of String)().ToArray()
        'Array.Sort(itemsmenu)
        'SeletorMenu.Items.Clear()
        'SeletorMenu.Items.AddRange(itemsmenu)

    End Sub

    'Private Sub SeletorMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SeletorMenu.SelectedIndexChanged

    '    ' Mudar menus

    '    Dim selectedMenu As String = SeletorMenu.SelectedItem.ToString()

    '    Select Case selectedMenu

    '        Case "Gestão de Stocks"
    '            Dim formA As New Gestão_Stock()
    '            formA.Show()
    '            Me.Hide()

    '        Case "Craft de Polvora"
    '            Dim formB As New Processo_Polvora()
    '            formB.Show()
    '            Me.Hide()

    '        Case "Processo de Pedra"
    '            Dim formC As New Processo_Pedra()
    '            formC.Show()
    '            Me.Hide()

    '        Case "Venda de Materiais"
    '            Dim formD As New Processo_Legal()
    '            formD.Show()
    '            Me.Hide()

    '        Case "Craft de Armas e Acessorios"
    '            Dim formE As New Craft_Armas()
    '            formE.Show()
    '            Me.Hide()

    '    End Select

    'End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Private Sub btnCraftArmas_Click(sender As Object, e As EventArgs) Handles btnCraftArmas.Click

        Dim QuantidadeArmas As Integer = txtQuantidadeArmas.Text

        If seletorArma.SelectedItem.ToString = "Fajuta" Then
            ABS = ABS + 20 * QuantidadeArmas : Aluminio = Aluminio + 20 * QuantidadeArmas : Borracha = Borracha + 15 * QuantidadeArmas : Molas = Molas + 5 * QuantidadeArmas : Parafusos = Parafusos + 7 * QuantidadeArmas : Pedaços = Pedaços + 40 * QuantidadeArmas : BPPistol = BPPistol + 20 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Vintage" Then
            ABS = ABS + 14 * QuantidadeArmas : Aluminio = Aluminio + 14 * QuantidadeArmas : Borracha = Borracha + 10 * QuantidadeArmas : Molas = Molas + 2 * QuantidadeArmas : Parafusos = Parafusos + 4 * QuantidadeArmas : Pedaços = Pedaços + 35 * QuantidadeArmas : BPPistol = BPPistol + 20 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Revolver" Then
            ABS = ABS + 24 * QuantidadeArmas : Aluminio = Aluminio + 24 * QuantidadeArmas : Borracha = Borracha + 20 * QuantidadeArmas : Molas = Molas + 6 * QuantidadeArmas : Parafusos = Parafusos + 8 * QuantidadeArmas : Pedaços = Pedaços + 45 * QuantidadeArmas : BPPistol = BPPistol + 25 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Tec-9" Then
            ABS = ABS + 30 * QuantidadeArmas : Aluminio = Aluminio + 30 * QuantidadeArmas : Borracha = Borracha + 25 * QuantidadeArmas : Molas = Molas + 7 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Pedaços = Pedaços + 50 * QuantidadeArmas : BPSMG = BPSMG + 25 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString() = "Deagle" Then
            ABS = ABS + 35 * QuantidadeArmas : Aluminio = Aluminio + 35 * QuantidadeArmas : Borracha = Borracha + 30 * QuantidadeArmas : Molas = Molas + 7 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Pedaços = Pedaços + 55 * QuantidadeArmas : BPPistol = BPPistol + 30 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Double Barrel" Then
            ABS = ABS + 24 * QuantidadeArmas : Aluminio = Aluminio + 18 * QuantidadeArmas : Borracha = Borracha + 25 * QuantidadeArmas : Molas = Molas + 6 * QuantidadeArmas : Parafusos = Parafusos + 9 * QuantidadeArmas : Pedaços = Pedaços + 51 * QuantidadeArmas : BPPistol = BPPistol + 25 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Micro" Then
            Aço = Aço + 100 * QuantidadeArmas : Bronze = Bronze + 50 * QuantidadeArmas : Molas = Molas + 7 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Polimero = Polimero + 45 * QuantidadeArmas : BPSMG = BPSMG + 30 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Thompson" Then
            Aço = Aço + 110 * QuantidadeArmas : Bronze = Bronze + 60 * QuantidadeArmas : Molas = Molas + 7 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Polimero = Polimero + 60 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Draco" Then
            Aço = Aço + 120 * QuantidadeArmas : Aluminio = Aluminio + 22 * QuantidadeArmas : Borracha = Borracha + 30 * QuantidadeArmas : Bronze = Bronze + 75 * QuantidadeArmas : Molas = Molas + 17 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Polimero = Polimero + 110 * QuantidadeArmas : BPRifle = BPRifle + 45 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "PDW" Then
            Aço = Aço + 120 * QuantidadeArmas : Bronze = Bronze + 70 * QuantidadeArmas : Molas = Molas + 7 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Polimero = Polimero + 70 * QuantidadeArmas : BPSMG = BPSMG + 40 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "AK" Then
            Aço = Aço + 140 * QuantidadeArmas : Aluminio = Aluminio + 24 * QuantidadeArmas : Borracha = Borracha + 35 * QuantidadeArmas : Bronze = Bronze + 95 * QuantidadeArmas : Molas = Molas + 20 * QuantidadeArmas : Parafusos = Parafusos + 10 * QuantidadeArmas : Polimero = Polimero + 130 * QuantidadeArmas : BPRifle = BPRifle + 55 * QuantidadeArmas
        End If

        If seletorArma.SelectedItem.ToString = "Famas" Then
            Aço = Aço + 150 * QuantidadeArmas : Aluminio = Aluminio + 30 * QuantidadeArmas : Bronze = Bronze + 100 * QuantidadeArmas : Molas = Molas + 22 * QuantidadeArmas : Parafusos = Parafusos + 12 * QuantidadeArmas : Polimero = Polimero + 140 * QuantidadeArmas : BPRifle = BPRifle + 65 * QuantidadeArmas
        End If

        lblEncomenda.Text = lblEncomenda.Text & vbCrLf & QuantidadeArmas & "x " & seletorArma.SelectedItem.ToString()

        Mostrador()
        seletorArma.SelectedIndex = -1 : txtQuantidadeArmas.Text = ""
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Aluminio = 0 : Aço = 0 : Pedaços = 0 : Borracha = 0 : Bronze = 0 : Polimero = 0 : Molas = 0 : Parafusos = 0 : ABS = 0 : BPPistol = 0 : BPSMG = 0 : BPRifle = 0
        lblEncomenda.Text = "Encomenda:"
        Mostrador()
    End Sub

    Private Sub Mostrador()
        txtAluminio.Text = Aluminio : txtBronze.Text = Bronze : txtAço.Text = Aço : txtPMetal.Text = Pedaços : txtBorracha.Text = Borracha : txtBronze.Text = Bronze : txtPolimero.Text = Polimero : txtMolas.Text = Molas : txtParafusos.Text = Parafusos : txtABS.Text = ABS : txtbpPistol.Text = BPPistol : txtBPSMG.Text = BPSMG : txtBPRifle.Text = BPRifle
    End Sub

End Class