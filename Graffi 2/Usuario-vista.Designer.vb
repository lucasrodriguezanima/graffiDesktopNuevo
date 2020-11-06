<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_vista
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
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.txt_nombre_de_usuario = New System.Windows.Forms.TextBox()
        Me.txt_dir_nro = New System.Windows.Forms.TextBox()
        Me.txt_nombre_completo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.correo_electronico_lbl = New System.Windows.Forms.Label()
        Me.txt_correoelectronico = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(180, 301)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(246, 20)
        Me.txt_password.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nombre De Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Barrio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Calle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Dir_nro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre Completo"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(180, 186)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(150, 20)
        Me.txt_calle.TabIndex = 25
        '
        'txt_barrio
        '
        Me.txt_barrio.Location = New System.Drawing.Point(180, 222)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.Size = New System.Drawing.Size(246, 20)
        Me.txt_barrio.TabIndex = 24
        '
        'txt_nombre_de_usuario
        '
        Me.txt_nombre_de_usuario.Location = New System.Drawing.Point(180, 257)
        Me.txt_nombre_de_usuario.Name = "txt_nombre_de_usuario"
        Me.txt_nombre_de_usuario.Size = New System.Drawing.Size(246, 20)
        Me.txt_nombre_de_usuario.TabIndex = 23
        '
        'txt_dir_nro
        '
        Me.txt_dir_nro.Location = New System.Drawing.Point(180, 150)
        Me.txt_dir_nro.Name = "txt_dir_nro"
        Me.txt_dir_nro.Size = New System.Drawing.Size(150, 20)
        Me.txt_dir_nro.TabIndex = 22
        '
        'txt_nombre_completo
        '
        Me.txt_nombre_completo.Location = New System.Drawing.Point(180, 113)
        Me.txt_nombre_completo.Name = "txt_nombre_completo"
        Me.txt_nombre_completo.Size = New System.Drawing.Size(246, 20)
        Me.txt_nombre_completo.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 49)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'correo_electronico_lbl
        '
        Me.correo_electronico_lbl.AutoSize = True
        Me.correo_electronico_lbl.Location = New System.Drawing.Point(80, 81)
        Me.correo_electronico_lbl.Name = "correo_electronico_lbl"
        Me.correo_electronico_lbl.Size = New System.Drawing.Size(94, 13)
        Me.correo_electronico_lbl.TabIndex = 34
        Me.correo_electronico_lbl.Text = "Correo Electronico"
        '
        'txt_correoelectronico
        '
        Me.txt_correoelectronico.Location = New System.Drawing.Point(180, 78)
        Me.txt_correoelectronico.Name = "txt_correoelectronico"
        Me.txt_correoelectronico.Size = New System.Drawing.Size(246, 20)
        Me.txt_correoelectronico.TabIndex = 33
        '
        'Usuario_vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.correo_electronico_lbl)
        Me.Controls.Add(Me.txt_correoelectronico)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_barrio)
        Me.Controls.Add(Me.txt_nombre_de_usuario)
        Me.Controls.Add(Me.txt_dir_nro)
        Me.Controls.Add(Me.txt_nombre_completo)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Usuario_vista"
        Me.Text = "Usuario_vista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents txt_barrio As TextBox
    Friend WithEvents txt_nombre_de_usuario As TextBox
    Friend WithEvents txt_dir_nro As TextBox
    Friend WithEvents txt_nombre_completo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents correo_electronico_lbl As Label
    Friend WithEvents txt_correoelectronico As TextBox
End Class
