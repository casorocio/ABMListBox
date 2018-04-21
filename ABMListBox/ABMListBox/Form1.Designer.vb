<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Alta = New System.Windows.Forms.Button
        Me.Baja = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.Enumerar = New System.Windows.Forms.Button
        Me.Alfabetizar = New System.Windows.Forms.Button
        Me.Mayuscula = New System.Windows.Forms.Button
        Me.Quitar = New System.Windows.Forms.Button
        Me.Grabarxml = New System.Windows.Forms.Button
        Me.Leerxml = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 17)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(154, 199)
        Me.ListBox1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 229)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(197, 31)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(75, 30)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Location = New System.Drawing.Point(197, 67)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(75, 31)
        Me.Baja.TabIndex = 2
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(197, 104)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 31)
        Me.Modificar.TabIndex = 3
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Enumerar
        '
        Me.Enumerar.Location = New System.Drawing.Point(197, 141)
        Me.Enumerar.Name = "Enumerar"
        Me.Enumerar.Size = New System.Drawing.Size(75, 28)
        Me.Enumerar.TabIndex = 5
        Me.Enumerar.Text = "Enumerar"
        Me.Enumerar.UseVisualStyleBackColor = True
        '
        'Alfabetizar
        '
        Me.Alfabetizar.Location = New System.Drawing.Point(197, 175)
        Me.Alfabetizar.Name = "Alfabetizar"
        Me.Alfabetizar.Size = New System.Drawing.Size(75, 27)
        Me.Alfabetizar.TabIndex = 6
        Me.Alfabetizar.Text = "Alfabetizar"
        Me.Alfabetizar.UseVisualStyleBackColor = True
        '
        'Mayuscula
        '
        Me.Mayuscula.Location = New System.Drawing.Point(197, 208)
        Me.Mayuscula.Name = "Mayuscula"
        Me.Mayuscula.Size = New System.Drawing.Size(75, 27)
        Me.Mayuscula.TabIndex = 7
        Me.Mayuscula.Text = "Mayuscula"
        Me.Mayuscula.UseVisualStyleBackColor = True
        '
        'Quitar
        '
        Me.Quitar.Location = New System.Drawing.Point(197, 241)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(75, 26)
        Me.Quitar.TabIndex = 8
        Me.Quitar.Text = "Quitar"
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'Grabarxml
        '
        Me.Grabarxml.Location = New System.Drawing.Point(325, 31)
        Me.Grabarxml.Name = "Grabarxml"
        Me.Grabarxml.Size = New System.Drawing.Size(75, 30)
        Me.Grabarxml.TabIndex = 9
        Me.Grabarxml.Text = "Grabar"
        Me.Grabarxml.UseVisualStyleBackColor = True
        '
        'Leerxml
        '
        Me.Leerxml.Location = New System.Drawing.Point(325, 67)
        Me.Leerxml.Name = "Leerxml"
        Me.Leerxml.Size = New System.Drawing.Size(75, 31)
        Me.Leerxml.TabIndex = 10
        Me.Leerxml.Text = "Leer"
        Me.Leerxml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 290)
        Me.Controls.Add(Me.Leerxml)
        Me.Controls.Add(Me.Grabarxml)
        Me.Controls.Add(Me.Quitar)
        Me.Controls.Add(Me.Mayuscula)
        Me.Controls.Add(Me.Alfabetizar)
        Me.Controls.Add(Me.Enumerar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Enumerar As System.Windows.Forms.Button
    Friend WithEvents Alfabetizar As System.Windows.Forms.Button
    Friend WithEvents Mayuscula As System.Windows.Forms.Button
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents Grabarxml As System.Windows.Forms.Button
    Friend WithEvents Leerxml As System.Windows.Forms.Button

End Class
