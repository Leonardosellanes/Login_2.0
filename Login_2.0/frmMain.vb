Imports MySql.Data.MySqlClient

Public Class frmMain
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand


    Public Sub ActualizarSelect()
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        Try
            conexion.ConnectionString = "Server=localhost; database=usuarios_roles; Uid=root; pwd=;"

            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT * FROM usuarios "
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdAdmin.DataSource = ds
            grdAdmin.DataMember = "Tabla"
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Close()
        frmRegistro.Close()
        Men.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSelect()
        conexion.ConnectionString = "Server=localhost; database=usuarios_roles; Uid=root; pwd=;"
        lblPass.Hide()
    End Sub

    Private Sub grdAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdAdmin.CellContentClick

    End Sub
    Private Sub grdMascotas_SelectionChanged(sender As Object, e As EventArgs) Handles grdAdmin.SelectionChanged
        If (grdAdmin.SelectedRows.Count > 0) Then
            txtUser.Text = grdAdmin.Item("Nombre", grdAdmin.SelectedRows(0).Index).Value
        End If
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If (txtUser.Text <> "") Then
            cmd.Parameters.Clear()
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT Nombre from Usuarios where Activo=1 And Nombre=@Nombre"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Nombre", txtUser.Text)

            Dim G As MySqlDataReader = cmd.ExecuteReader()

            If G.HasRows Then
                MsgBox("El usuario ha sido activado previamente")
                G.Close()
            Else
                cmd.CommandText = "UPDATE usuarios SET Activo=1 where Nombre=@Nombre"
                cmd.Prepare()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nombre", txtUser.Text)
                G.Close()
                cmd.ExecuteNonQuery()
                MsgBox("Usuario Activado Con Exito")
                txtUser.Clear()
            End If
            G.Close()
            conexion.Close()
            ActualizarSelect()
        Else
            MsgBox("Seleccione un Usuario para poder Activarlo")
        End If
        conexion.Close()

    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click

        conexion.Open()
        cmd.Connection = conexion
        If (txtUser.Text <> "") Then
            If (txtPass.Text <> "") Then
                cmd.CommandText = "UPDATE usuarios SET Pass=@Pass where Nombre=@Nombre"
                cmd.Prepare()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Pass", txtPass.Text)
                cmd.Parameters.AddWithValue("@Nombre", txtUser.Text)
                cmd.ExecuteNonQuery()
                lblPass.Show()
                conexion.Close()
                ActualizarSelect()
                txtUser.Clear()
                txtPass.Clear()
            Else
                MsgBox("¡Ingrese una contraseña por favor!")

                ActualizarSelect()
            End If
        Else
            MsgBox("¡No Ha seleccionado a ningun usuario!")
        End If
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class