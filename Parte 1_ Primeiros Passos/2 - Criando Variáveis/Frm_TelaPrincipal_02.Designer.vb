<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_02
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
        Me.Btm_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Btm_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btm_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btm_Resultado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_NumerosInteiros
        '
        Me.Btm_NumerosInteiros.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btm_NumerosInteiros.Location = New System.Drawing.Point(35, 78)
        Me.Btm_NumerosInteiros.Name = "Btm_NumerosInteiros"
        Me.Btm_NumerosInteiros.Size = New System.Drawing.Size(153, 67)
        Me.Btm_NumerosInteiros.TabIndex = 0
        Me.Btm_NumerosInteiros.Text = "Exemplos números interos"
        Me.Btm_NumerosInteiros.UseVisualStyleBackColor = False
        '
        'Btm_PontoFlutuante
        '
        Me.Btm_PontoFlutuante.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btm_PontoFlutuante.Location = New System.Drawing.Point(35, 167)
        Me.Btm_PontoFlutuante.Name = "Btm_PontoFlutuante"
        Me.Btm_PontoFlutuante.Size = New System.Drawing.Size(153, 67)
        Me.Btm_PontoFlutuante.TabIndex = 1
        Me.Btm_PontoFlutuante.Text = "Exemplo número ponto Flutuante"
        Me.Btm_PontoFlutuante.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Criando Variáveis"
        '
        'Btm_ConversaoNumeros
        '
        Me.Btm_ConversaoNumeros.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btm_ConversaoNumeros.Location = New System.Drawing.Point(35, 256)
        Me.Btm_ConversaoNumeros.Name = "Btm_ConversaoNumeros"
        Me.Btm_ConversaoNumeros.Size = New System.Drawing.Size(153, 67)
        Me.Btm_ConversaoNumeros.TabIndex = 3
        Me.Btm_ConversaoNumeros.Text = "Exemplo de coversão de números"
        Me.Btm_ConversaoNumeros.UseVisualStyleBackColor = False
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(320, 124)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(173, 23)
        Me.Txt_Numerador.TabIndex = 4
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(320, 162)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(173, 23)
        Me.Txt_Denominador.TabIndex = 5
        '
        'Btm_Resultado
        '
        Me.Btm_Resultado.Location = New System.Drawing.Point(365, 196)
        Me.Btm_Resultado.Name = "Btm_Resultado"
        Me.Btm_Resultado.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Resultado.TabIndex = 6
        Me.Btm_Resultado.Text = "Resultado"
        Me.Btm_Resultado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Numerador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Denominador"
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(320, 235)
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(173, 23)
        Me.Txt_Resultado.TabIndex = 9
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 349)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btm_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btm_ConversaoNumeros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btm_PontoFlutuante)
        Me.Controls.Add(Me.Btm_NumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criando Variáveis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumerosInteiros As Button
    Friend WithEvents Btm_PontoFlutuante As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btm As Button
    Friend WithEvents Btm_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Resultado As TextBox
End Class
