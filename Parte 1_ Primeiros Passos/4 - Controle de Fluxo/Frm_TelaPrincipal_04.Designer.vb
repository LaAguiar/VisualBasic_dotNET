<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal_04
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
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Txt_idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Lbl_Idade = New System.Windows.Forms.Label()
        Me.GrP_Pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.Rdb_Sim = New System.Windows.Forms.RadioButton()
        Me.GrP_Pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Btm_Principal.Location = New System.Drawing.Point(12, 184)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(239, 23)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui"
        Me.Btm_Principal.UseVisualStyleBackColor = False
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(34, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(77, 30)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Label1"
        '
        'Txt_idade
        '
        Me.Txt_idade.Location = New System.Drawing.Point(61, 66)
        Me.Txt_idade.Name = "Txt_idade"
        Me.Txt_idade.Size = New System.Drawing.Size(100, 23)
        Me.Txt_idade.TabIndex = 2
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(98, 231)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(273, 23)
        Me.Txt_Resultado.TabIndex = 3
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Resultado.Location = New System.Drawing.Point(18, 234)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(43, 15)
        Me.Lbl_Resultado.TabIndex = 4
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Lbl_Idade
        '
        Me.Lbl_Idade.AutoSize = True
        Me.Lbl_Idade.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Idade.Location = New System.Drawing.Point(12, 70)
        Me.Lbl_Idade.Name = "Lbl_Idade"
        Me.Lbl_Idade.Size = New System.Drawing.Size(43, 15)
        Me.Lbl_Idade.TabIndex = 5
        Me.Lbl_Idade.Text = "Label1"
        '
        'GrP_Pais
        '
        Me.GrP_Pais.Controls.Add(Me.Rdb_Nao)
        Me.GrP_Pais.Controls.Add(Me.Rdb_Sim)
        Me.GrP_Pais.Location = New System.Drawing.Point(12, 95)
        Me.GrP_Pais.Name = "GrP_Pais"
        Me.GrP_Pais.Size = New System.Drawing.Size(158, 83)
        Me.GrP_Pais.TabIndex = 6
        Me.GrP_Pais.TabStop = False
        Me.GrP_Pais.Text = "GroupBox1"
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(6, 47)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(97, 19)
        Me.Rdb_Nao.TabIndex = 1
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "RadioButton1"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Rdb_Sim
        '
        Me.Rdb_Sim.AutoSize = True
        Me.Rdb_Sim.Location = New System.Drawing.Point(6, 22)
        Me.Rdb_Sim.Name = "Rdb_Sim"
        Me.Rdb_Sim.Size = New System.Drawing.Size(97, 19)
        Me.Rdb_Sim.TabIndex = 0
        Me.Rdb_Sim.TabStop = True
        Me.Rdb_Sim.Text = "RadioButton1"
        Me.Rdb_Sim.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 280)
        Me.Controls.Add(Me.GrP_Pais)
        Me.Controls.Add(Me.Lbl_Idade)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_idade)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_TelaPrincipal_04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Olá Mundo"
        Me.GrP_Pais.ResumeLayout(False)
        Me.GrP_Pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Txt_idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Lbl_Idade As Label
    Friend WithEvents GrP_Pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton
End Class

