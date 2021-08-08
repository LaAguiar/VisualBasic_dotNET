Public Class Frm_TelaPrincipal_04
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "Controle de Fluxo"
        Btm_Principal.Text = "Checagem da permissão de entrada"
        Me.Text = "Controle de Fluxo"

        ' Inicialização dos componentes da aplicação

        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        GrP_Pais.Text = "Acompanhado dos pais?"
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"



    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Txt_Resultado.Text = ""
        Dim idade As Integer
        idade = Txt_idade.Text

        Dim acompanhadoPais As String = "N"

        If Rdb_Sim.Checked Then
            acompanhadoPais = "S"
        End If

        Dim mensagemAdiconal As String

        If acompanhadoPais = "S" Then
            mensagemAdiconal = "Está acompanhado."
        Else
            mensagemAdiconal = "Não está acompanhado."
        End If

        If (idade >= 18) Or (acompanhadoPais = "S" And idade >= 16) Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar! " + mensagemAdiconal
        Else
            Txt_Resultado.ForeColor = Color.Red
            Txt_Resultado.Text = "Não pode entrar! " + mensagemAdiconal
        End If

    End Sub
End Class
