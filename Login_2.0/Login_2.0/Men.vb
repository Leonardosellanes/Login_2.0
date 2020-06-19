Public Class Men
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        frmLogin.Show()
        frmRegistro.Hide()
        Me.Hide()
    End Sub
End Class