Public Class Frm_TelaPrincipal_03

    'declarando uma varável global
    Dim listaCurso As String
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().


        'Aprendendo alterar os valores dinamicamente
        Lbl_NomeProjeto.Text = "Manipulando Textos"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "Manipulando Textos"
        Btm_Char.Text = "Clique para obter o char"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicionar na lista"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim PrimeiraLetra As Char = "A"
        MsgBox("O caracter da variável PrimeiraLetra é " + PrimeiraLetra)

        Dim numero As Integer = 66
        Dim SegundaLetra As Char = Chr(numero)
        MsgBox("O caracter referente a " + numero.ToString + " é " + SegundaLetra)


    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click
        'Verificando os valores da tabela ASCII

        Dim ValorChar As Integer = Val(Txt_NumeroChar.Text)
        Dim letra As Char = Chr(ValorChar)

        MsgBox("O caracter referente a " + ValorChar.ToString + " é " + letra)
    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim cursoDigitado As String = Txt_Curso.Text
        listaCurso = listaCurso + cursoDigitado + vbCrLf
        Txt_Lista.Text = listaCurso


    End Sub

    Private Sub Lbl_NomeProjeto_Click(sender As Object, e As EventArgs) Handles Lbl_NomeProjeto.Click

    End Sub
End Class
