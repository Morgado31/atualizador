Imports System.DirectoryServices.ActiveDirectory
Imports MySql.Data.MySqlClient

Public Class Craft_Armas
    Private Sub Craft_Armas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            Case "Craft de Armas e Acessorios"
                Dim formE As New Craft_Armas()
                formE.Show()
                Me.Hide()

        End Select

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnCraftArmas_Click(sender As Object, e As EventArgs) Handles btnCraftArmas.Click

        Dim QuantidadeArmas As String = txtQuantidadeArmas.Text : Dim Aluminio As Integer : Dim Aço As Integer : Dim Pedaços As Integer : Dim Borracha As Integer : Dim Bronze As Integer : Dim Polimero As Integer : Dim Molas As Integer : Dim Parafusos As Integer : Dim ABS As Integer : Dim BluePrints As Integer : Dim TipoBluePrints As String

        If seletorArma.SelectedItem.ToString = "Vintage" Then
            Aluminio = 14 : Pedaços = 35 : Borracha = 10 : Molas = 2 : Parafusos = 4 : ABS = 14 : BluePrints = 20 : TipoBluePrints = "Pistola"
        End If

        If seletorArma.SelectedItem.ToString = "Fajuta" Then
            Aluminio = 20 : Pedaços = 40 : Borracha = 15 : Molas = 5 : Parafusos = 7 : ABS = 20 : BluePrints = 20 : TipoBluePrints = "Pistola"
        End If

        If seletorArma.SelectedItem.ToString = "Revolver" Then
            Aluminio = 24 : Pedaços = 45 : Borracha = 20 : Molas = 6 : Parafusos = 8 : ABS = 24 : BluePrints = 25 : TipoBluePrints = "Pistola"
        End If

        If seletorArma.SelectedItem.ToString = "Tec-9" Then
            Aluminio = 30 : Pedaços = 50 : Borracha = 25 : Molas = 7 : Parafusos = 10 : ABS = 30 : BluePrints = 25 : TipoBluePrints = "Pistola"
        End If

        If seletorArma.SelectedItem.ToString = "Micro Uzi" Then
            Aço = 100 : Bronze = 50 : Polimero = 45 : Molas = 7 : Parafusos = 10 : BluePrints = 30 : TipoBluePrints = "SMG"
        End If



    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class