Public Class FormOverlay

    Private piscando As Boolean = False
    Private estadoPiscando As Boolean = True
    Private Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Private Const HTCAPTION As Integer = 2
    Public Posicionar As Boolean = False
    Private posicaoOriginal As Point
    Private posicaoOriginalSalva As Boolean = False
    Private posicaoAnterior As Point
    Private fadeAtivo As Boolean = False

    Protected Overrides Sub WndProc(
        ByRef m As Message
    )

        If m.Msg = WM_NCLBUTTONDBLCLK Then
            Return
        End If

        MyBase.WndProc(m)

    End Sub


    Private Sub FormOverlay_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Me.FormBorderStyle =
            FormBorderStyle.SizableToolWindow

        Me.TopMost = True
        Me.ShowInTaskbar = False
        Me.Opacity = 0.2

        TimerPisca.Interval = 200
        TimerPisca.Stop()

        contadorPublico.Visible = True
        contadorPublico.BackColor =
            SystemColors.Control


        ' Guarda a posição original para o botão
        ' posicionar btnPosicinaContadorPub
        posicaoOriginal = Me.Location
        posicaoOriginalSalva = True

        Me.MinimumSize =
            New Size(145, 69)

        Me.MaximumSize =
            New Size(145, 69)

    End Sub


    ' FADE
    '  ativo = True -> Mostra o contador.
    ' ativo = False -> Esconde o contador.
    ' O estado do Fade fica armazenado em fadeAtivo para impedir que DefinirCrescente() faça o Overlay reaparecer
    Public Sub Fade(ativo As Boolean)

        Me.TopMost = True
        Me.ShowInTaskbar = False

        If ativo Then
            ' Mostrar o Overlay
            fadeAtivo = False

        Else
            ' Esconder o Overlay
            fadeAtivo = True

        End If

        AtualizarOpacidade()

    End Sub


    ' Controle da central de opacidade
    'OBS. Esta rotina é a única responsável por determinar a opacidade do Overlay

    ' Prioridade:
    ' 1º - Fade ativo      = 0.0
    ' 2º - Fundo vermelho  = 0.6
    ' 3º - Fundo normal    = 0.2
    Private Sub AtualizarOpacidade()

        If fadeAtivo Then
            ' Overlay escondido
            Me.Opacity = 0.0

        ElseIf contadorPublico.BackColor = Color.Red Then
            ' Contagem crescente
            Me.Opacity = 0.7

        Else
            ' Contagem regressiva normal
            Me.Opacity = 0.2

        End If

    End Sub


    Public Sub AtualizarContador(
        valor As String
    )
        contadorPublico.Text = valor

    End Sub


    'Definir a contagem crescente
    ' IMPORTANTE: Este método NÃO altera diretamente Me.Opacity. Só troca a cor e chama AtualizarOpacidade().

    ' Dessa forma, se o Fade estiver ativo, a opacidade continua
    ' em 0.0 mesmo que o Timer1 chame este método.
    Public Sub DefinirCrescente(
        ativo As Boolean
    )

        If ativo Then
            contadorPublico.BackColor =
                Color.Red

        Else
            contadorPublico.BackColor =
                SystemColors.Control

        End If

        AtualizarOpacidade()

    End Sub

    'Acha a posição onde colocar o Overlay
    Public Sub DefinirPosicao(
        ativar As Boolean
    )

        Posicionar = ativar

        If ativar Then
            ' Guarda a posição atual antes de mover
            posicaoAnterior = Me.Location

            ' Procura o monitor secundário
            Dim monitor As Screen = Nothing

            If Screen.AllScreens.Length > 1 Then
                monitor =
                    Screen.AllScreens.FirstOrDefault(
                        Function(s) Not s.Primary
                    )

            End If

            ' Se não houver secundário, usa o primário
            If monitor Is Nothing Then
                monitor =
                    Screen.PrimaryScreen
            End If


            Me.StartPosition =
                FormStartPosition.Manual

            ' Retira as bordas e barra de títulos para posicionar
            Me.FormBorderStyle =
                FormBorderStyle.None

            Me.MinimumSize =
                New Size(130, 30)

            Me.MaximumSize =
                New Size(130, 30)

            ' Canto superior direito do segundo monitor
            Me.Left =
                monitor.Bounds.Right - Me.Width

            Me.Top =
                monitor.Bounds.Top

        Else
            ' Volta para a posição anterior
            Me.StartPosition =
                FormStartPosition.Manual

            Me.Location =
                posicaoAnterior

            ' Reexibe as bordas da janela
            Me.FormBorderStyle =
                FormBorderStyle.SizableToolWindow

            Me.MinimumSize =
                New Size(145, 69)

            Me.MaximumSize =
                New Size(145, 69)

        End If

    End Sub


    Public Sub DefinirPisca(
        ativar As Boolean
    )

        piscando = ativar


        If ativar Then

            TimerPisca.Start()

        Else

            TimerPisca.Stop()

            contadorPublico.Visible = True

            estadoPiscando = True

        End If

    End Sub


    Private Sub TimerPisca_Tick(
        sender As Object,
        e As EventArgs
    ) Handles TimerPisca.Tick

        If piscando Then

            estadoPiscando =
                Not estadoPiscando

            contadorPublico.Visible =
                estadoPiscando

        Else

            contadorPublico.Visible = True

        End If

    End Sub


    Private Sub contadorPublico_DoubleClick(
        sender As Object,
        e As EventArgs
    ) Handles contadorPublico.DoubleClick

        If Me.FormBorderStyle =
            FormBorderStyle.SizableToolWindow Then

            Me.FormBorderStyle =
                FormBorderStyle.None

            Me.MinimumSize =
                New Size(130, 30)

            Me.MaximumSize =
                New Size(130, 30)

        Else

            Me.FormBorderStyle =
                FormBorderStyle.SizableToolWindow

            Me.MinimumSize =
                New Size(145, 69)

            Me.MaximumSize =
                New Size(145, 69)

        End If

    End Sub


End Class