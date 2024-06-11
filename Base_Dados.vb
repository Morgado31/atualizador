Imports System.Collections.ObjectModel
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging
Imports MySql
Imports MySql.Data.Authentication
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Utilities.Collections

Public Class Base_Dados
    Private Sub Base_Dados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seletorTabelas.SelectedIndex = 0
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Tabelas()

        If seletorTabelas.SelectedItem = "Venda de Materiais" Then

            Using connection As New MySqlConnection(connString)

                Dim QueryVendas As String = "SELECT * FROM `Venda de Materiais`"

                Using adapter As New MySqlDataAdapter(QueryVendas, connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable

                End Using

            End Using

        ElseIf seletorTabelas.SelectedItem = "Processo Legal" Then

            Using connection As New MySqlConnection(connString)

                Dim QueryVendas As String = "SELECT * FROM `Processo Legal`"

                Using adapter As New MySqlDataAdapter(QueryVendas, connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable

                End Using

            End Using

        ElseIf seletorTabelas.SelectedItem = "Processo Ilegal" Then

            Using connection As New MySqlConnection(connString)

                Dim QueryVendas As String = "SELECT * FROM `Processo Minério`"

                Using adapter As New MySqlDataAdapter(QueryVendas, connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable

                End Using

            End Using

        ElseIf seletorTabelas.SelectedItem = "Craft de Pólvora" Then

            Using connection As New MySqlConnection(connString)

                Dim QueryVendas As String = "SELECT * FROM `Polvora`"

                Using adapter As New MySqlDataAdapter(QueryVendas, connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable

                End Using

            End Using

        End If


    End Sub

    Private Sub seletorTabelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seletorTabelas.SelectedIndexChanged
        Tabelas()
    End Sub
End Class