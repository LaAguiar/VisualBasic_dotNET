<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_03
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
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_Char = New System.Windows.Forms.Button()
        Me.Txt_NumeroChar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btm_Principal.Location = New System.Drawing.Point(284, 58)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(244, 37)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui"
        Me.Btm_Principal.UseVisualStyleBackColor = False
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(370, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(77, 30)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Label1"
        '
        'Btm_Char
        '
        Me.Btm_Char.Location = New System.Drawing.Point(329, 188)
        Me.Btm_Char.Name = "Btm_Char"
        Me.Btm_Char.Size = New System.Drawing.Size(154, 47)
        Me.Btm_Char.TabIndex = 2
        Me.Btm_Char.Text = "Button1"
        Me.Btm_Char.UseVisualStyleBackColor = True
        '
        'Txt_NumeroChar
        '
        Me.Txt_NumeroChar.Location = New System.Drawing.Point(329, 156)
        Me.Txt_NumeroChar.Name = "Txt_NumeroChar"
        Me.Txt_NumeroChar.Size = New System.Drawing.Size(154, 23)
        Me.Txt_NumeroChar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(132, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Digite um valor para verificar qual letra representa na tabela ASCII"
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Curso.Location = New System.Drawing.Point(370, 256)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(77, 30)
        Me.Lbl_Curso.TabIndex = 5
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(116, 300)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(276, 23)
        Me.Txt_Curso.TabIndex = 6
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(416, 299)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(277, 24)
        Me.Btm_Adicionar.TabIndex = 7
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(116, 329)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(577, 67)
        Me.Txt_Lista.TabIndex = 8
        '
        'Frm_TelaPrincipal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btm_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_NumeroChar)
        Me.Controls.Add(Me.Btm_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_TelaPrincipal_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Olá Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Text_NumeroChar As TextBox
    Friend WithEvents Txt_NumeroChar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
End Class