Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_NumerosInteiros.Click
        'Aprendendo sobre a declaração de variáveis inteiras

        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade  multiplicado por 5 e somado com 10 é " + idade.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btm_PontoFlutuante.Click
        'Aprendendo sobre a declaração de variáveis do tipo double

        Dim valor As Double
        valor = 9.2
        MsgBox("A variável valor é igual a " + valor.ToString, MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        'mesmo os números sendo inteiros, como a variavel valor é double o resultado será 2.5
        valor = numerador / denominador
        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumeros.Click
        'Aprendendo sobre a conversão de tipos de números

        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("Valor salário: " + salario.ToString + " / Valor salário inteiro: " + salarioInteiro.ToString, MsgBoxStyle.Critical)

        'Aprendendo sobre os limites de tamanho

        'long 64bits
        Dim salarioGrande As Long
        salarioGrande = 1000000000000000

        'integer 32bits
        Dim salarioMedio As Integer
        salarioMedio = 1000000000

        'short 16bits
        Dim salarioPequeno As Short
        salarioPequeno = 10000

        'sbyte 8bits
        Dim salarioMinusculo As SByte
        salarioMinusculo = 100

        'double não tem uma precisão exata - 64bits
        Dim valorDouble As Double
        valorDouble = 9.8995215355221333

        'decimal 128bits
        Dim valorDecimal As Decimal
        valorDecimal = 9.8995215355221333

        MsgBox("Valor double: " + valorDouble.ToString + " / Valor decimal: " + valorDecimal.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click
        'Aprendendo a utilizar caixas de texto

        Dim numerador As Double
        Dim denominador As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultado As Double
        resultado = numerador / denominador

        MsgBox("Resultado da divisão é igual a " + resultado.ToString, MsgBoxStyle.Exclamation)

        Txt_Resultado.Text = resultado.ToString

    End Sub

End Class

