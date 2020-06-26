<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.grdAdmin = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.grbAdmin = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grdAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPass
        '
        Me.btnPass.Location = New System.Drawing.Point(374, 383)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(118, 23)
        Me.btnPass.TabIndex = 9
        Me.btnPass.Text = "Cambiar contraseña"
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(235, 342)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(118, 23)
        Me.btnActivar.TabIndex = 8
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seleccione un usuario"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(218, 316)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(150, 20)
        Me.txtUser.TabIndex = 6
        '
        'grdAdmin
        '
        Me.grdAdmin.AllowUserToOrderColumns = True
        Me.grdAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAdmin.Location = New System.Drawing.Point(3, 19)
        Me.grdAdmin.Name = "grdAdmin"
        Me.grdAdmin.Size = New System.Drawing.Size(623, 246)
        Me.grdAdmin.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Modificar Contraseña:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(218, 385)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(150, 20)
        Me.txtPass.TabIndex = 11
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblPass.Location = New System.Drawing.Point(205, 409)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(177, 13)
        Me.lblPass.TabIndex = 12
        Me.lblPass.Text = "Contraseña Cambiada Exitosamente"
        '
        'grbAdmin
        '
        Me.grbAdmin.Controls.Add(Me.grdAdmin)
        Me.grbAdmin.Controls.Add(Me.lblPass)
        Me.grbAdmin.Controls.Add(Me.btnPass)
        Me.grbAdmin.Controls.Add(Me.txtPass)
        Me.grbAdmin.Controls.Add(Me.txtUser)
        Me.grbAdmin.Controls.Add(Me.Label2)
        Me.grbAdmin.Controls.Add(Me.Label1)
        Me.grbAdmin.Controls.Add(Me.btnActivar)
        Me.grbAdmin.Location = New System.Drawing.Point(3, 2)
        Me.grbAdmin.Name = "grbAdmin"
        Me.grbAdmin.Size = New System.Drawing.Size(632, 429)
        Me.grbAdmin.TabIndex = 13
        Me.grbAdmin.TabStop = False
        Me.grbAdmin.Text = "Administrador"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 19)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Inicio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnActivar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 463)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grbAdmin)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.grdAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAdmin.ResumeLayout(False)
        Me.grbAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPass As Button
    Friend WithEvents btnActivar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents grdAdmin As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents grbAdmin As GroupBox
    Friend WithEvents Button1 As Button
End Class
