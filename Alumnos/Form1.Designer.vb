<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nombretxt = New System.Windows.Forms.TextBox()
        Me.apellidotxt = New System.Windows.Forms.TextBox()
        Me.mat1txt = New System.Windows.Forms.TextBox()
        Me.mat2txt = New System.Windows.Forms.TextBox()
        Me.mat3txt = New System.Windows.Forms.TextBox()
        Me.mat4txt = New System.Windows.Forms.TextBox()
        Me.mat5txt = New System.Windows.Forms.TextBox()
        Me.mat6txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.limpiarbtn = New System.Windows.Forms.Button()
        Me.guardarbtn = New System.Windows.Forms.Button()
        Me.datos = New System.Windows.Forms.DataGridView()
        Me.eliminarbtn = New System.Windows.Forms.Button()
        Me.clavetxt = New System.Windows.Forms.TextBox()
        Me.modificarbtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Materia 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Materia 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Materia 3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Materia 6:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(182, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Materia 5:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(182, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Materia 4:"
        '
        'nombretxt
        '
        Me.nombretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombretxt.Location = New System.Drawing.Point(73, 19)
        Me.nombretxt.Name = "nombretxt"
        Me.nombretxt.Size = New System.Drawing.Size(216, 23)
        Me.nombretxt.TabIndex = 9
        '
        'apellidotxt
        '
        Me.apellidotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidotxt.Location = New System.Drawing.Point(73, 60)
        Me.apellidotxt.Name = "apellidotxt"
        Me.apellidotxt.Size = New System.Drawing.Size(295, 23)
        Me.apellidotxt.TabIndex = 10
        '
        'mat1txt
        '
        Me.mat1txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat1txt.Location = New System.Drawing.Point(81, 21)
        Me.mat1txt.Name = "mat1txt"
        Me.mat1txt.Size = New System.Drawing.Size(69, 23)
        Me.mat1txt.TabIndex = 11
        '
        'mat2txt
        '
        Me.mat2txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat2txt.Location = New System.Drawing.Point(81, 61)
        Me.mat2txt.Name = "mat2txt"
        Me.mat2txt.Size = New System.Drawing.Size(69, 23)
        Me.mat2txt.TabIndex = 12
        '
        'mat3txt
        '
        Me.mat3txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat3txt.Location = New System.Drawing.Point(81, 101)
        Me.mat3txt.Name = "mat3txt"
        Me.mat3txt.Size = New System.Drawing.Size(69, 23)
        Me.mat3txt.TabIndex = 13
        '
        'mat4txt
        '
        Me.mat4txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat4txt.Location = New System.Drawing.Point(248, 20)
        Me.mat4txt.Name = "mat4txt"
        Me.mat4txt.Size = New System.Drawing.Size(66, 23)
        Me.mat4txt.TabIndex = 14
        '
        'mat5txt
        '
        Me.mat5txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat5txt.Location = New System.Drawing.Point(248, 60)
        Me.mat5txt.Name = "mat5txt"
        Me.mat5txt.Size = New System.Drawing.Size(66, 23)
        Me.mat5txt.TabIndex = 15
        '
        'mat6txt
        '
        Me.mat6txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mat6txt.Location = New System.Drawing.Point(248, 100)
        Me.mat6txt.Name = "mat6txt"
        Me.mat6txt.Size = New System.Drawing.Size(66, 23)
        Me.mat6txt.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.apellidotxt)
        Me.GroupBox1.Controls.Add(Me.nombretxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 97)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mat6txt)
        Me.GroupBox2.Controls.Add(Me.mat5txt)
        Me.GroupBox2.Controls.Add(Me.mat4txt)
        Me.GroupBox2.Controls.Add(Me.mat3txt)
        Me.GroupBox2.Controls.Add(Me.mat2txt)
        Me.GroupBox2.Controls.Add(Me.mat1txt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 137)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calificaciones"
        '
        'limpiarbtn
        '
        Me.limpiarbtn.Location = New System.Drawing.Point(188, 155)
        Me.limpiarbtn.Name = "limpiarbtn"
        Me.limpiarbtn.Size = New System.Drawing.Size(75, 23)
        Me.limpiarbtn.TabIndex = 20
        Me.limpiarbtn.Text = "Limpiar"
        Me.limpiarbtn.UseVisualStyleBackColor = True
        '
        'guardarbtn
        '
        Me.guardarbtn.Location = New System.Drawing.Point(286, 154)
        Me.guardarbtn.Name = "guardarbtn"
        Me.guardarbtn.Size = New System.Drawing.Size(75, 23)
        Me.guardarbtn.TabIndex = 21
        Me.guardarbtn.Text = "Guardar"
        Me.guardarbtn.UseVisualStyleBackColor = True
        '
        'datos
        '
        Me.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datos.Location = New System.Drawing.Point(11, 213)
        Me.datos.Name = "datos"
        Me.datos.Size = New System.Drawing.Size(749, 208)
        Me.datos.TabIndex = 22
        '
        'eliminarbtn
        '
        Me.eliminarbtn.Location = New System.Drawing.Point(382, 154)
        Me.eliminarbtn.Name = "eliminarbtn"
        Me.eliminarbtn.Size = New System.Drawing.Size(75, 23)
        Me.eliminarbtn.TabIndex = 23
        Me.eliminarbtn.Text = "Eliminar"
        Me.eliminarbtn.UseVisualStyleBackColor = True
        '
        'clavetxt
        '
        Me.clavetxt.Location = New System.Drawing.Point(69, 135)
        Me.clavetxt.Name = "clavetxt"
        Me.clavetxt.Size = New System.Drawing.Size(100, 20)
        Me.clavetxt.TabIndex = 24
        Me.clavetxt.Visible = False
        '
        'modificarbtn
        '
        Me.modificarbtn.Location = New System.Drawing.Point(481, 154)
        Me.modificarbtn.Name = "modificarbtn"
        Me.modificarbtn.Size = New System.Drawing.Size(75, 23)
        Me.modificarbtn.TabIndex = 25
        Me.modificarbtn.Text = "Modificar"
        Me.modificarbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 434)
        Me.Controls.Add(Me.modificarbtn)
        Me.Controls.Add(Me.clavetxt)
        Me.Controls.Add(Me.eliminarbtn)
        Me.Controls.Add(Me.datos)
        Me.Controls.Add(Me.guardarbtn)
        Me.Controls.Add(Me.limpiarbtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nombretxt As TextBox
    Friend WithEvents apellidotxt As TextBox
    Friend WithEvents mat1txt As TextBox
    Friend WithEvents mat2txt As TextBox
    Friend WithEvents mat3txt As TextBox
    Friend WithEvents mat4txt As TextBox
    Friend WithEvents mat5txt As TextBox
    Friend WithEvents mat6txt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents limpiarbtn As Button
    Friend WithEvents guardarbtn As Button
    Friend WithEvents datos As DataGridView
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents clavetxt As TextBox
    Friend WithEvents modificarbtn As Button
End Class
