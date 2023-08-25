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
        Me.btnGuardarExcel = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnGuardarWord = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnGuardarExcel
        '
        Me.btnGuardarExcel.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarExcel.Location = New System.Drawing.Point(288, 165)
        Me.btnGuardarExcel.Name = "btnGuardarExcel"
        Me.btnGuardarExcel.Size = New System.Drawing.Size(113, 56)
        Me.btnGuardarExcel.TabIndex = 11
        Me.btnGuardarExcel.Text = "Guardar Excel"
        Me.btnGuardarExcel.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.Location = New System.Drawing.Point(133, 87)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(195, 27)
        Me.txtDato.TabIndex = 10
        Me.txtDato.Text = "Hola Mundito :D"
        Me.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGuardarWord
        '
        Me.btnGuardarWord.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarWord.Location = New System.Drawing.Point(74, 165)
        Me.btnGuardarWord.Name = "btnGuardarWord"
        Me.btnGuardarWord.Size = New System.Drawing.Size(113, 56)
        Me.btnGuardarWord.TabIndex = 9
        Me.btnGuardarWord.Text = "Guardar Word"
        Me.btnGuardarWord.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 309)
        Me.Controls.Add(Me.btnGuardarExcel)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnGuardarWord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnGuardarExcel As Button
    Private WithEvents txtDato As TextBox
    Private WithEvents btnGuardarWord As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
