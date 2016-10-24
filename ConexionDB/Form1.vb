Imports mysql.Data.MySqlClient

Public Class Form1
    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Try
            Dim connstr As String
            connstr = "Database=utp231;Data Source=127.0.0.1;User Id=root;Password=;"
            Dim connection As New MySqlConnection(connstr)
            Dim query As String
            query = "Select * from cliente"
            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()

            While reader.Read()
                ltsCliente.Items.Add(reader.GetString("nombre") & " " & (reader.GetString("apellido")))
                ''MessageBox.Show(Environment.MachineName)

            End While

            reader.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error " + ex.ToString())
        End Try

    End Sub
End Class
