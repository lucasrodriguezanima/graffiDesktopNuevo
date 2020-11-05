<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HOME
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Like2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Home = New System.Windows.Forms.Panel()
        Me.Username = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Like1 = New System.Windows.Forms.PictureBox()
        Me.Like3 = New System.Windows.Forms.PictureBox()
        Me.Boton_panel = New System.Windows.Forms.Button()
        CType(Me.Like2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Home.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Like1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Like3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(383, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Like2
        '
        Me.Like2.BackColor = System.Drawing.Color.Gold
        Me.Like2.Enabled = False
        Me.Like2.Image = Global.Graffi_2.My.Resources.Resources._5f8a1ea9c90ceed8d92999bc824417eb_icono_del_coraz__n_de_instagram_by_vexels
        Me.Like2.Location = New System.Drawing.Point(439, 193)
        Me.Like2.Name = "Like2"
        Me.Like2.Size = New System.Drawing.Size(37, 23)
        Me.Like2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Like2.TabIndex = 3
        Me.Like2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Graffi_2.My.Resources.Resources._22_223848_businessman_vector_person_logo_png
        Me.PictureBox2.Location = New System.Drawing.Point(28, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(688, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel_Home
        '
        Me.Panel_Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Home.Controls.Add(Me.Username)
        Me.Panel_Home.Controls.Add(Me.PictureBox2)
        Me.Panel_Home.Enabled = False
        Me.Panel_Home.Location = New System.Drawing.Point(38, 1)
        Me.Panel_Home.Name = "Panel_Home"
        Me.Panel_Home.Size = New System.Drawing.Size(156, 454)
        Me.Panel_Home.TabIndex = 4
        Me.Panel_Home.Visible = False
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(25, 111)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(35, 13)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Graffi_2.My.Resources.Resources._22_223848_businessman_vector_person_logo_png
        Me.PictureBox4.Location = New System.Drawing.Point(383, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(147, 150)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Like1
        '
        Me.Like1.Image = Global.Graffi_2.My.Resources.Resources._5f8a1ea9c90ceed8d92999bc824417eb_icono_del_coraz__n_de_instagram_by_vexels
        Me.Like1.Location = New System.Drawing.Point(439, 193)
        Me.Like1.Name = "Like1"
        Me.Like1.Size = New System.Drawing.Size(37, 23)
        Me.Like1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Like1.TabIndex = 7
        Me.Like1.TabStop = False
        '
        'Like3
        '
        Me.Like3.Enabled = False
        Me.Like3.Image = Global.Graffi_2.My.Resources.Resources._5f8a1ea9c90ceed8d92999bc824417eb_icono_del_coraz__n_de_instagram_by_vexels
        Me.Like3.Location = New System.Drawing.Point(439, 193)
        Me.Like3.Name = "Like3"
        Me.Like3.Size = New System.Drawing.Size(37, 23)
        Me.Like3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Like3.TabIndex = 8
        Me.Like3.TabStop = False
        '
        'Boton_panel
        '
        Me.Boton_panel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Boton_panel.Location = New System.Drawing.Point(-1, 28)
        Me.Boton_panel.Name = "Boton_panel"
        Me.Boton_panel.Size = New System.Drawing.Size(33, 23)
        Me.Boton_panel.TabIndex = 9
        Me.Boton_panel.UseVisualStyleBackColor = False
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Boton_panel)
        Me.Controls.Add(Me.Like1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel_Home)
        Me.Controls.Add(Me.Like2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Like3)
        Me.Name = "HOME"
        Me.Text = "Home"
        CType(Me.Like2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Home.ResumeLayout(False)
        Me.Panel_Home.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Like1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Like3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Like2 As PictureBox
    Friend WithEvents Username As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Like1 As PictureBox
    Friend WithEvents Like3 As PictureBox
    Friend WithEvents Boton_panel As Button
    Public WithEvents Panel_Home As Panel
End Class
