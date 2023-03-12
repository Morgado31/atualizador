Imports MySql.Data.MySqlClient
Imports System.Net

Public Class Login_Form

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Using connection As New MySqlConnection(connString)
            connection.Open()
            Try
                Dim query As String = "SELECT * From Login WHERE Username=@Username AND Password=@Password"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
                    connection.Close()
                    Processo_Legal.Show()
                Else
                    MessageBox.Show("Algo está errado")
                    Exit Try
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        MVariables.outputTrabalhador = txtUsername.Text

        Me.Hide()

    End Sub

End Class