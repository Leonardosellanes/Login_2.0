Imports MySql.Data.MySqlClient
Public Class frmRegistro
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ds As DataSet = New DataSet
    Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Server=localhost; database=usuarios_roles; Uid=root; pwd=;"
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try
            If (txtRegistroNom.Text <> "") And (txtRegistroPass.Text <> "") Then
                conexion.Open()
                cmd.Connection = conexion

                cmd.CommandText = "SELECT Nombre from usuarios where Nombre = @nombre AND Pass = @Pass"
                cmd.Prepare()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", txtRegistroNom.Text)
                cmd.Parameters.AddWithValue("@pass", txtRegistroPass.Text)
                Dim r As MySqlDataReader = cmd.ExecuteReader()
                If r.HasRows Then
                    MessageBox.Show("Usuario existente")
                Else
                    r.Close()
                    cmd.CommandText = "INSERT INTO `usuarios` (`IdUsuario`, `Nombre`, `Pass`, `IdRol`, `Activo`) VALUES (NULL, @nombre, @pass, 3, 0)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@nombre", txtRegistroNom.Text)
                    cmd.Parameters.AddWithValue("@pass", txtRegistroPass.Text)
                    Men.Show()
                    cmd.ExecuteNonQuery()

                End If
            Else
                MsgBox("Debe ingresar un Nombre y una Contraseña para poder Registrase")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub
    Private Sub frmRegistro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Close()
        Men.Close()
        frmMain.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class