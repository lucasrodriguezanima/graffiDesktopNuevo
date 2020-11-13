<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_correoelectronico = New System.Windows.Forms.TextBox()
        Me.txt_nombre_artistico = New System.Windows.Forms.TextBox()
        Me.correo_electronico_lbl = New System.Windows.Forms.Label()
        Me.nombre_artistico_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(445, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "loguearse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_correoelectronico
        '
        Me.txt_correoelectronico.Location = New System.Drawing.Point(138, 168)
        Me.txt_correoelectronico.Name = "txt_correoelectronico"
        Me.txt_correoelectronico.Size = New System.Drawing.Size(246, 20)
        Me.txt_correoelectronico.TabIndex = 1
        '
        'txt_nombre_artistico
        '
        Me.txt_nombre_artistico.Location = New System.Drawing.Point(139, 203)
        Me.txt_nombre_artistico.Name = "txt_nombre_artistico"
        Me.txt_nombre_artistico.Size = New System.Drawing.Size(246, 20)
        Me.txt_nombre_artistico.TabIndex = 2
        '
        'correo_electronico_lbl
        '
        Me.correo_electronico_lbl.AutoSize = True
        Me.correo_electronico_lbl.Location = New System.Drawing.Point(39, 171)
        Me.correo_electronico_lbl.Name = "correo_electronico_lbl"
        Me.correo_electronico_lbl.Size = New System.Drawing.Size(94, 13)
        Me.correo_electronico_lbl.TabIndex = 4
        Me.correo_electronico_lbl.Text = "Correo Electronico"
        '
        'nombre_artistico_lbl
        '
        Me.nombre_artistico_lbl.AutoSize = True
        Me.nombre_artistico_lbl.Location = New System.Drawing.Point(39, 203)
        Me.nombre_artistico_lbl.Name = "nombre_artistico_lbl"
        Me.nombre_artistico_lbl.Size = New System.Drawing.Size(83, 13)
        Me.nombre_artistico_lbl.TabIndex = 5
        Me.nombre_artistico_lbl.Text = "Nombre artistico"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Graffi_2.My.Resources.Resources.home_page
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(804, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(332, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Bienvenidos a Graffi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(74, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password :"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(139, 117)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(245, 20)
        Me.txt_password.TabIndex = 13
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(140, 80)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(245, 20)
        Me.txt_username.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.ForeColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(284, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "________________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(72, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(316, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Iniciar Sesion"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(445, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 61)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Registrate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Graffi_2.My.Resources.Resources.home_page
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombre_artistico_lbl)
        Me.Controls.Add(Me.correo_electronico_lbl)
        Me.Controls.Add(Me.txt_nombre_artistico)
        Me.Controls.Add(Me.txt_correoelectronico)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "  "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt_correoelectronico As TextBox
    Friend WithEvents txt_nombre_artistico As TextBox
    Friend WithEvents correo_electronico_lbl As Label
    Friend WithEvents nombre_artistico_lbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
