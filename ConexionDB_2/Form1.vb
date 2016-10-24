
Imports MySql.Data.MySqlClient



Public Class Clientes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim connstr As String
            connstr = "Database=utp231;Data Source=127.0.0.1;User Id=root;Password=;"

            Dim connection As New MySqlConnection(connstr)
            Dim query As String
            query = "select * from cliente where cedula ='" & txtCedula.Text & "'"

            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()

            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                txtNombre.Text = reader.GetString("nombre")
                txtApellido.Text = reader.GetString("apellido")
            Else
                MessageBox.Show("Cedula no existe")
            End If

            connection.Close()



        Catch ex As Exception


            MessageBox.Show("Error " + ex.ToString)


        End Try




    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Try
            Dim connstr As String
            connstr = "Database=utp231;Data Source=127.0.0.1;User Id=root;Password=;"
            Dim connection As New MySqlConnection(connstr)
            Dim query As String
            'query = "insert into cliente(cedula,nombre,apellido) values('8-7','Maria','Castillo')"
            query = "insert into cliente(cedula,nombre,apellido) values('" & txtCedula.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "')"

            Dim cmd As New MySqlCommand(query, connection)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception

        End Try



    End Sub
End Class
