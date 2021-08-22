<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal_01
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btm_Principal.Location = New System.Drawing.Point(86, 59)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(112, 48)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui"
        Me.Btm_Principal.UseVisualStyleBackColor = False
        '
        'Frm_TelaPrincipal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 169)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_TelaPrincipal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Olá Mundo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btm_Principal As Button
End Class
