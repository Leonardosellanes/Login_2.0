Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim ds As DataSet = New DataSet
    Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Server=localhost; database=usuarios_roles; Uid=root; pwd=;"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmMain.grbAdmin.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT Nombre from usuarios where Nombre = @nombre AND Pass = @pass AND Activo = 1"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", txtUser.Text)
            cmd.Parameters.AddWithValue("@pass", txtPass.Text)
            Dim r As MySqlDataReader = cmd.ExecuteReader()

            If r.HasRows Then
                If (txtUser.Text = "Admin") And (txtPass.Text = "123") Then
                    frmMain.Show()
                    frmMain.grbAdmin.Show()
                    Me.Hide()
                Else
                    frmMain.Show()
                    Me.Hide()
                End If
            Else
                    MessageBox.Show("Usuario o Contraseña incorrectos")
            End If

            r.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub
End Class
