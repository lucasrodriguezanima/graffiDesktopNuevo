<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarGraffitii
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
        Me.Agregar_Graffiti = New System.Windows.Forms.Button()
        Me.Eliminar_Graffiti = New System.Windows.Forms.Button()
        Me.txt_id_Graffiti = New System.Windows.Forms.TextBox()
        Me.txt_Diseño = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.listar_Graffiti = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.List_listar_graffiti = New System.Windows.Forms.ListView()
        Me.id_Graffiti = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diseño = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Agregar_Graffiti
        '
        Me.Agregar_Graffiti.Location = New System.Drawing.Point(123, 298)
        Me.Agregar_Graffiti.Name = "Agregar_Graffiti"
        Me.Agregar_Graffiti.Size = New System.Drawing.Size(75, 23)
        Me.Agregar_Graffiti.TabIndex = 0
        Me.Agregar_Graffiti.Text = "Agregar"
        Me.Agregar_Graffiti.UseVisualStyleBackColor = True
        '
        'Eliminar_Graffiti
        '
        Me.Eliminar_Graffiti.Location = New System.Drawing.Point(349, 298)
        Me.Eliminar_Graffiti.Name = "Eliminar_Graffiti"
        Me.Eliminar_Graffiti.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar_Graffiti.TabIndex = 1
        Me.Eliminar_Graffiti.Text = "Eliminar"
        Me.Eliminar_Graffiti.UseVisualStyleBackColor = True
        '
        'txt_id_Graffiti
        '
        Me.txt_id_Graffiti.Location = New System.Drawing.Point(257, 94)
        Me.txt_id_Graffiti.Name = "txt_id_Graffiti"
        Me.txt_id_Graffiti.Size = New System.Drawing.Size(291, 20)
        Me.txt_id_Graffiti.TabIndex = 2
        '
        'txt_Diseño
        '
        Me.txt_Diseño.Location = New System.Drawing.Point(257, 214)
        Me.txt_Diseño.Name = "txt_Diseño"
        Me.txt_Diseño.Size = New System.Drawing.Size(291, 20)
        Me.txt_Diseño.TabIndex = 3
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(257, 156)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(291, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'listar_Graffiti
        '
        Me.listar_Graffiti.Location = New System.Drawing.Point(574, 298)
        Me.listar_Graffiti.Name = "listar_Graffiti"
        Me.listar_Graffiti.Size = New System.Drawing.Size(75, 23)
        Me.listar_Graffiti.TabIndex = 5
        Me.listar_Graffiti.Text = "listar"
        Me.listar_Graffiti.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id_graffiti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Diseño"
        '
        'List_listar_graffiti
        '
        Me.List_listar_graffiti.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_Graffiti, Me.nombre, Me.diseño})
        Me.List_listar_graffiti.HideSelection = False
        Me.List_listar_graffiti.Location = New System.Drawing.Point(573, 65)
        Me.List_listar_graffiti.Name = "List_listar_graffiti"
        Me.List_listar_graffiti.Size = New System.Drawing.Size(215, 227)
        Me.List_listar_graffiti.TabIndex = 9
        Me.List_listar_graffiti.UseCompatibleStateImageBehavior = False
        '
        'id_Graffiti
        '
        Me.id_Graffiti.Text = "id_graffiti"
        '
        'nombre
        '
        Me.nombre.Text = "nombre"
        '
        'diseño
        '
        Me.diseño.Text = "diseño"
        '
        'ModificarGraffitii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.List_listar_graffiti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listar_Graffiti)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_Diseño)
        Me.Controls.Add(Me.txt_id_Graffiti)
        Me.Controls.Add(Me.Eliminar_Graffiti)
        Me.Controls.Add(Me.Agregar_Graffiti)
        Me.Name = "ModificarGraffitii"
        Me.Text = "ModificarGraffitii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agregar_Graffiti As Button
    Friend WithEvents Eliminar_Graffiti As Button
    Friend WithEvents txt_id_Graffiti As TextBox
    Friend WithEvents txt_Diseño As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents listar_Graffiti As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents List_listar_graffiti As ListView
    Friend WithEvents id_Graffiti As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents diseño As ColumnHeader
End Class
