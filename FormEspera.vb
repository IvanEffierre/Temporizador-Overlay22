Imports System.Threading

Public Class FormEspera


    Private tempoRestante As Integer
    Private tempoFechar As Integer
    Private opacidadeInicial As Double = 1.0
    Private inicioFade As DateTime


    Public Sub DefinirTempo(tempo As Integer)

        ' Recebe o tempo definido no Painel
        tempoRestante = tempo

        ' Mostra imediatamente o tempo recebido
        AtualizarContador()

        ' Inicia a contagem
        Timer1.Interval = 1000
        Timer1.Start()

    End Sub


    Private Sub AtualizarContador()

        Dim tempoFormatado As TimeSpan =
            TimeSpan.FromSeconds(tempoRestante)

        labelHoraInicial.Text =
            tempoFormatado.ToString("hh\:mm\:ss")

    End Sub


    Private Sub FormEspera_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load


        ' Descobre se tem 2 ou mais monitores: usa o primeiro monitor que não é o primário.
        Dim Monitor As Screen

        If Screen.AllScreens.Length = 1 Then
            Me.TopMost = False
            Me.ShowInTaskbar = False
            ' Existe apenas um monitor
            Monitor = Screen.AllScreens(0)

        Else

            ' Existem dois ou mais monitores
            ' Procura um monitor que não seja o principal
            Monitor = Screen.AllScreens.FirstOrDefault(
        Function(s) Not s.Primary
    )

            ' Segurança: se não encontrar, usa o principal
            If Monitor Is Nothing Then
                Monitor = Screen.PrimaryScreen
            End If

        End If

        ' Ocupa todo o monitor
        Me.FormBorderStyle =
            FormBorderStyle.None

        Me.StartPosition =
            FormStartPosition.Manual

        Me.Bounds =
            Monitor.Bounds


        ' Ajusta o tamanho da fonte
        AjustarLabel()


        ' Faz a Label ocupar toda a tela
        labelHoraInicial.AutoSize = False

        labelHoraInicial.Left = 0
        labelHoraInicial.Top = 0

        labelHoraInicial.Width =
            Me.ClientSize.Width

        labelHoraInicial.Height =
            Me.ClientSize.Height

        ' Centraliza o texto
        labelHoraInicial.TextAlign =
            ContentAlignment.MiddleCenter

    End Sub


    Private Sub AjustarLabel()

        ' Resolução de referência
        Dim larguraReferencia As Integer = 1920
        Dim alturaReferencia As Integer = 1080

        ' Tamanho original da fonte no Designer
        Dim fonteOriginal As Single = 225.0F

        ' Calcula a proporção da tela
        Dim escalaLargura As Single =
            Me.ClientSize.Width / larguraReferencia

        Dim escalaAltura As Single =
            Me.ClientSize.Height / alturaReferencia

        ' Usa a menor escala para preservar a proporção
        Dim escala As Single =
            Math.Min(escalaLargura, escalaAltura)

        ' Novo tamanho da fonte
        Dim novoTamanho As Single =
            fonteOriginal * escala

        ' Aplica a nova fonte
        labelHoraInicial.Font =
            New Font(
                labelHoraInicial.Font.FontFamily,
                novoTamanho,
                labelHoraInicial.Font.Style
            )

    End Sub


    Private Sub Timer1_Tick(
    sender As Object,
    e As EventArgs
) Handles Timer1.Tick


        ' Diminui um segundo
        tempoRestante -= 1

        ' Atualiza o contador
        AtualizarContador()


        ' Verifica se chegou a zero
        If tempoRestante <= 0 Then

            tempoRestante = 0
            labelHoraInicial.ForeColor = Color.White
            Me.BackColor = Color.Black
            Timer1.Stop()
            AtualizarContador()

            ' Para o countdown principal


            ' Define os 3 segundos para fechamento
            tempoFechar = 3


            ' Marca o início do fade
            inicioFade = DateTime.Now

            ' Inicia o fade
            TimerFade.Interval = 50
            TimerFade.Start()

            'some com o contador

            ' Atualiza o Painel
            Painel.modoCountdown = False
            Painel.btnCountdown.Text = "Mostrar Tela de Espera"

            Exit Sub

        End If


        ' Últimos 11 segundos ficam vermelhos
        If tempoRestante <= 10 Then

            labelHoraInicial.ForeColor = Color.Red

        End If




    End Sub


    Private Sub labelHoraInicial_Click(
        sender As Object,
        e As EventArgs
    ) Handles labelHoraInicial.Click

    End Sub

    Private Sub TimerFade_Tick(
    sender As Object,
    e As EventArgs
) Handles TimerFade.Tick

        ' Quanto tempo passou desde o início do fade
        Dim decorrido As Double =
        (DateTime.Now - inicioFade).TotalSeconds


        ' Quanto dos 3 segundos já passou
        Dim progresso As Double =
        decorrido / tempoFechar


        ' Terminou os 3 segundos
        If progresso >= 1.0 Then

            Me.Opacity = 0.0

            TimerFade.Stop()

            Me.Close()

            Exit Sub

        End If


        ' Reduz a opacidade progressivamente
        Me.Opacity =
        opacidadeInicial * (1.0 - progresso)


    End Sub
End Class