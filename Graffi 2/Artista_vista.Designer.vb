<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Artista_vista
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
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_correoelectronico
        '
        Me.txt_correoelectronico.Location = New System.Drawing.Point(146, 60)
        Me.txt_correoelectronico.Name = "txt_correoelectronico"
        Me.txt_correoelectronico.Size = New System.Drawing.Size(246, 20)
        Me.txt_correoelectronico.TabIndex = 1
        '
        'txt_nombre_artistico
        '
        Me.txt_nombre_artistico.Location = New System.Drawing.Point(146, 97)
        Me.txt_nombre_artistico.Name = "txt_nombre_artistico"
        Me.txt_nombre_artistico.Size = New System.Drawing.Size(246, 20)
        Me.txt_nombre_artistico.TabIndex = 2
        '
        'correo_electronico_lbl
        '
        Me.correo_electronico_lbl.AutoSize = True
        Me.correo_electronico_lbl.Location = New System.Drawing.Point(46, 63)
        Me.correo_electronico_lbl.Name = "correo_electronico_lbl"
        Me.correo_electronico_lbl.Size = New System.Drawing.Size(94, 13)
        Me.correo_electronico_lbl.TabIndex = 4
        Me.correo_electronico_lbl.Text = "Correo Electronico"
        '
        'nombre_artistico_lbl
        '
        Me.nombre_artistico_lbl.AutoSize = True
        Me.nombre_artistico_lbl.Location = New System.Drawing.Point(46, 97)
        Me.nombre_artistico_lbl.Name = "nombre_artistico_lbl"
        Me.nombre_artistico_lbl.Size = New System.Drawing.Size(83, 13)
        Me.nombre_artistico_lbl.TabIndex = 5
        Me.nombre_artistico_lbl.Text = "Nombre artistico"
        '
        'Artista_vista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nombre_artistico_lbl)
        Me.Controls.Add(Me.correo_electronico_lbl)
        Me.Controls.Add(Me.txt_nombre_artistico)
        Me.Controls.Add(Me.txt_correoelectronico)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Artista_vista"
        Me.Text = "Artista_vista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt_correoelectronico As TextBox
    Friend WithEvents txt_nombre_artistico As TextBox
    Friend WithEvents correo_electronico_lbl As Label
    Friend WithEvents nombre_artistico_lbl As Label
End Class
