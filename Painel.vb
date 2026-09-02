Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Windows

Public Class Painel

    'Inicia o modo Tela de Espera ( a que conta o tempo mostrando o countdown grande e centralizado!)
    Public modoCountdown As Boolean = False
    Private telaEspera As FormEspera

    ' Tempo principal em segundos
    Private tempoRestante As Integer

    ' Tempo de estouro em segundos
    Private tempoRestante2 As Integer

    ' 0 = parado ou  1 = rodando
    Private estado As Integer

    ' Guarda o tempo anterior
    Private a As String

    ' Indica se o tempo foi alterado
    ' 0 = não alterado ou 1 = alterado
    Private b As Integer

    ' 0 = contagem regressiva ou 1 = contagem crescente após chegar a zero
    Private estado2 As Integer

    Private piscando As Boolean
    Private estadoPiscando As Boolean

    Private telaPublica As FormOverlay

    Private mostrar As Integer
    Private passador As String
    Private passador2 As String


    ' ============================================================
    ' CRÉDITOS E DIREITOS AUTORAIS
    ' ============================================================
    '
    ' © 2026 Valdivan Ramos
    '
    ' Este software foi desenvolvido por Valdivan Ramos.
    '
    ' Todos os direitos reservados.
    '
    ' Este software é disponibilizado gratuitamente para uso,
    ' estudo e avaliação.
    '
    ' A utilização, cópia, modificação e distribuição deste
    ' software estão sujeitas aos termos estabelecidos na licença
    ' de uso e no EULA que acompanham este programa.
    '
    ' É permitida a realização de modificações para fins de estudo
    ' e desenvolvimento, desde que sejam respeitados os direitos
    ' autorais do autor original e os termos da licença aplicável.
    '
    ' Eventuais modificações, melhorias ou novas funcionalidades
    ' desenvolvidas por terceiros devem ser devidamente documentadas,
    ' identificando claramente as alterações realizadas e mantendo
    ' os créditos referentes à autoria original.
    '
    ' A autoria original e os respectivos créditos não devem ser
    ' removidos ou apresentados de forma a sugerir que o software
    ' original foi desenvolvido por terceiros.
    '
    ' Para informações detalhadas sobre as condições de uso,
    ' distribuição e modificação, consulte o EULA e a licença
    ' que acompanham este software.
    '
    ' ============================================================


    Private Sub Painel_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Timer1.Stop()

        estado = 0
        estado2 = 0

        tempoRestante = 0
        tempoRestante2 = 0

        b = 0

        ' Intervalo de 1 segundo
        Timer1.Interval = 1000

        piscando = False
        estadoPiscando = False

        telaPublica = New FormOverlay()
        telaPublica.Show()

        mostrar = 1

        btnRepetir.Enabled = False

        btnPlay.ForeColor = Color.White
        btnPlay.BackColor = Color.Gray


        If My.Settings.EULA_Aceito Then

            ' Já aceitou anteriormente, o programa pode continuar normalmente.
            'MsgBox("ja aceitou")
            Return

        End If

        ' testar o EULA. EULA AINDA NÃO FOI ACEITO
        Using telaEULA As New FormEULA()

            Dim resultado As DialogResult = telaEULA.ShowDialog()

            ' USUÁRIO RECUSOU
            If resultado <> DialogResult.OK Then
                Application.Exit()
                Return
            End If

        End Using

    End Sub


    Private Sub Timer1_Tick(
        sender As Object,
        e As EventArgs
    ) Handles Timer1.Tick

        'Contagem regressiva e Estouro de tempo
        If estado2 = 1 Then

            piscando = False
            estadoPiscando = False

            TimerPisca.Stop()
            contador2.Visible = True

            ' Fundo vermelho no Painel
            contador2.BackColor = Color.Red

            ' Fundo vermelho no Overlay
            telaPublica.DefinirCrescente(True)

            ' Garante que o Overlay não pisque
            telaPublica.DefinirPisca(False)

            ' incrementa o estouro
            tempoRestante2 += 1

            Dim tempoComoHora As DateTime =
                New DateTime().AddSeconds(tempoRestante2)

            contador2.Text =
                tempoComoHora.ToString("HH:mm:ss")

            ' Atualiza o Overlay
            telaPublica.AtualizarContador(contador2.Text)

        Else

            'Contagem regressiva
            If tempoRestante > 0 Then
                tempoRestante -= 1

                ' formatar tempo
                Dim tempoComoHora As DateTime =
                    New DateTime().AddSeconds(tempoRestante)

                contador2.Text =
                    tempoComoHora.ToString("HH:mm:ss")

                contador2.BackColor =
                    SystemColors.Control

                telaPublica.DefinirCrescente(False)

                ' atualizar overlay
                telaPublica.AtualizarContador(contador2.Text)

                ' verifica se falta 30 seg
                If tempoRestante <= 30 Then

                    ' faz piscar o contador aqui no painel
                    piscando = True
                    TimerPisca.Start()

                    ' faz piscar na tela do Overlay
                    telaPublica.DefinirPisca(True)

                Else
                    ' fim do pisca
                    piscando = False
                    estadoPiscando = False
                    TimerPisca.Stop()
                    contador2.Visible = True

                    ' fim pisca no overlay
                    telaPublica.DefinirPisca(False)

                End If

            Else
                ' Contador zerado
                contador2.Visible = True
                contador2.Text = "00:00:00"

                contador2.BackColor = SystemColors.Control

                piscando = False
                estadoPiscando = False

                TimerPisca.Stop()
                telaPublica.DefinirPisca(False)
                telaPublica.DefinirCrescente(False)
                telaPublica.AtualizarContador(contador2.Text)

                'Verifica se tem estouro permitido
                If CheckBox1.Checked Then
                    ' estouro permitido
                    estado2 = 1
                    tempoRestante2 = 0
                    telaPublica.DefinirCrescente(True)
                    telaPublica.DefinirPisca(False)

                Else
                    'estouro não permitido
                    estado2 = 0
                    estado = 0
                    Timer1.Stop()

                    btnPlay.Enabled = False
                    btnPlay.ForeColor = Color.White
                    btnPlay.BackColor = Color.Gray

                    If btnPlay.Enabled = False And
                       CheckBox1.Checked = False And
                       passador2 <> "00:00:00" Then

                        btnRepetir.Enabled = True
                        btnRepetir.ForeColor = Color.FromArgb(192, 0, 0)

                        btnRepetir.BackColor = Color.FromArgb(255, 192, 192)

                    Else

                        btnRepetir.ForeColor = Color.White
                        btnRepetir.BackColor = Color.Gray
                        btnRepetir.Enabled = False

                    End If

                End If

            End If

        End If

        contador2.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub Label2_Click(
        sender As Object,
        e As EventArgs
    ) Handles Label2.Click,
            Label3.Click,
            Label4.Click

    End Sub


    Private Sub btnConfigurar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnConfigurar.Click

        'Entrando no modo de Configurar
        If horaT.Enabled = False Then

            ' Guarda o tempo atual no formato HH:mm:ss
            a =
                horaT.Text.PadLeft(2, "0"c) & ":" &
                minutoT.Text.PadLeft(2, "0"c) & ":" &
                segundoT.Text.PadLeft(2, "0"c)

            ' Habilita os campos
            btnPlay.Enabled = False
            btnPlay.ForeColor = Color.White
            btnPlay.BackColor = Color.Gray

            horaT.Enabled = True
            minutoT.Enabled = True
            segundoT.Enabled = True

            horaT.Focus()
            horaT.SelectAll()

            CheckBox1.Enabled = True
            CheckBox1.ForeColor = Color.FromArgb(192, 0, 0)
            CheckBox1.BackColor = Color.FromArgb(255, 192, 192)

            labelInfo.Visible = False

            Exit Sub

        End If

        'Sair do modo de Configuração
        horaT.Enabled = False
        minutoT.Enabled = False
        segundoT.Enabled = False

        CheckBox1.Enabled = False
        CheckBox1.ForeColor = Color.White
        CheckBox1.BackColor = Color.Gray

        btnPlay.Enabled = True
        btnPlay.ForeColor = Color.FromArgb(192, 0, 0)
        btnPlay.BackColor = Color.FromArgb(255, 192, 192)
        btnPlay.Focus()


        Dim horas As Integer
        Dim minutos As Integer
        Dim segundos As Integer
        ' converter para hora
        If Not Integer.TryParse(horaT.Text, horas) Then
            horas = 0
        End If

        ' converter para minuto
        If Not Integer.TryParse(minutoT.Text, minutos) Then
            minutos = 0
        End If

        ' converte para segundos
        If Not Integer.TryParse(segundoT.Text, segundos) Then
            segundos = 0
        End If

        ' garantir valores válidos
        If horas < 0 Then horas = 0
        If minutos < 0 Then minutos = 0
        If segundos < 0 Then segundos = 0
        If minutos > 59 Then minutos = 59
        If segundos > 59 Then segundos = 59

        ' criar novo tempo válido
        Dim tempoInicial As TimeSpan = New TimeSpan(horas, minutos, segundos)

        tempoRestante = CInt(tempoInicial.TotalSeconds)
        passador2 = CInt(tempoInicial.TotalSeconds)

        tempoRestante2 = 0
        estado2 = 0

        ' formata para HH:MM:SS
        Dim verificador2 As String = tempoInicial.ToString("hh\:mm\:ss")

        contador2.Text = verificador2
        passador = contador2.Text

        telaPublica.AtualizarContador(
            contador2.Text
        )

        contador2.BackColor = SystemColors.Control
        contador2.TextAlign = ContentAlignment.MiddleCenter

        ' verifica alteração
        If a = verificador2 Then
            ' Não mudou
            b = 0
        Else
            ' Mudou
            b = 1
        End If


        btnCountdown.Enabled = True
        btnCountdown.ForeColor = Color.FromArgb(192, 0, 0)
        btnCountdown.BackColor = Color.FromArgb(255, 192, 192)

    End Sub

    Private Sub TimerPisca_Tick(
        sender As Object,
        e As EventArgs
    ) Handles TimerPisca.Tick

        If piscando AndAlso
           estado2 = 0 AndAlso
           estado = 1 Then

            estadoPiscando = Not estadoPiscando
            contador2.Visible = estadoPiscando

        Else
            contador2.Visible = True
        End If

    End Sub


    Private Sub btnPlay_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPlay.Click

        If estado = 0 Then
            labelInfo.Visible = False

            If tempoRestante = 0 Then

                ' Verifica se está no estouro
                If estado2 = 1 Then

                    ' Retoma o estouro de onde parou. Não altera tempoRestante2
                    contador2.Visible = True
                    contador2.BackColor = Color.Red

                    telaPublica.DefinirCrescente(True)
                    telaPublica.DefinirPisca(False)

                Else

                    'Tempo zerado mas ainda não está no estouro
                    If Not CheckBox1.Checked Then

                        btnPlay.Enabled = False
                        btnPlay.ForeColor = Color.White
                        btnPlay.BackColor = Color.Gray
                        labelInfo.Visible = True

                        labelInfo.Text =
                            "O Tempo total está zerado." &
                            vbCrLf &
                            "Caso queira iniciar a contagem crescente," &
                            vbCrLf &
                            "você deve Permitir Estouro de Tempo."

                        btnRepetir.Enabled = True
                        btnRepetir.ForeColor = Color.FromArgb(192, 0, 0)
                        btnRepetir.BackColor = Color.FromArgb(255, 192, 192)

                        Exit Sub

                    End If

                    'Permitir iniciar zerado para contagem crescente
                    estado2 = 1

                    tempoRestante2 = 0
                    contador2.Visible = True
                    contador2.BackColor = Color.Red
                    telaPublica.DefinirCrescente(True)
                    telaPublica.DefinirPisca(False)

                End If

            Else
                'Contagem regressiva
                estado2 = 0

                ' Não existe estouro anterior
                tempoRestante2 = 0
                contador2.Visible = True
                contador2.BackColor = SystemColors.Control

                ' Fundo normal no Overlay
                telaPublica.DefinirCrescente(False)

                ' Nunca inicia piscando ao clicar Play
                telaPublica.DefinirPisca(False)

            End If

            estado = 1
            Timer1.Start()

            ' grava horário de início
            If b = 1 Then

                b = 0

            End If

            btnRepetir.ForeColor = Color.White
            btnRepetir.BackColor = Color.Gray
            btnRepetir.Enabled = False

        Else
            'Modo pausa
            estado = 0
            Timer1.Stop()
            btnRepetir.Enabled = True
            btnRepetir.ForeColor = Color.FromArgb(192, 0, 0)
            btnRepetir.BackColor = Color.FromArgb(255, 192, 192)
        End If

    End Sub

    ' Controlar os Fades da Tela do Overlay
    Private Sub btnFade_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFade.Click

        If mostrar = 1 Then
            ' Esconder
            telaPublica.Fade(False)
            mostrar = 0
            btnFade.Text = "Mostrar Contador Público"

        Else
            ' Mostrar
            telaPublica.Fade(True)
            mostrar = 1
            btnFade.Text = "Esconder Contador Público"

        End If

    End Sub

    'Controle de teclas permitidas
    Private Sub segundoT_KeyPress(
        sender As Object,
        e As KeyPressEventArgs
    ) Handles segundoT.KeyPress

        ' Permite Backspace
        If e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If

        ' Permite somente números
        If Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True
            Exit Sub

        End If

        ' Verifica o valor que ficará no TextBox
        Dim textoNovo As String = segundoT.Text.Remove(segundoT.SelectionStart, segundoT.SelectionLength)
        textoNovo = textoNovo.Insert(segundoT.SelectionStart, e.KeyChar.ToString())

        ' Limita de 00 a 59
        Dim valor As Integer

        If Integer.TryParse(textoNovo, valor) Then
            If valor > 59 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub minutoT_KeyPress(
        sender As Object,
        e As KeyPressEventArgs
    ) Handles minutoT.KeyPress

        ' Permite Backspace
        If e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If

        ' Permite somente números
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Exit Sub

        End If

        ' Verifica o valor que ficará no TextBox
        Dim textoNovo As String = minutoT.Text.Remove(minutoT.SelectionStart, minutoT.SelectionLength)
        textoNovo = textoNovo.Insert(minutoT.SelectionStart, e.KeyChar.ToString())

        ' Limita de 00 a 59
        Dim valor As Integer
        If Integer.TryParse(textoNovo, valor) Then
            If valor > 59 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub horaT_KeyPress(
        sender As Object,
        e As KeyPressEventArgs
    ) Handles horaT.KeyPress

        ' Permite Backspace
        If e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If

        ' Permite somente números
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        ' Verifica o valor que ficará no TextBox
        Dim textoNovo As String = horaT.Text.Remove(horaT.SelectionStart, horaT.SelectionLength)
        textoNovo = textoNovo.Insert(horaT.SelectionStart, e.KeyChar.ToString())

        ' Limita de 00 a 23
        Dim valor As Integer
        If Integer.TryParse(textoNovo, valor) Then
            If valor > 23 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub horaT_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles horaT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            minutoT.Focus()
            minutoT.SelectAll()
        End If

    End Sub

    Private Sub minutoT_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles minutoT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            segundoT.Focus()
            segundoT.SelectAll()
        End If

    End Sub

    Private Sub segundoT_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles segundoT.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnConfigurar_Click(btnConfigurar, EventArgs.Empty)
            btnPlay.Focus()
        End If

    End Sub

    Private Sub btnRepetir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRepetir.Click

        contador2.Text = passador
        labelInfo.Visible = False

        Dim tempoComoHora As DateTime = New DateTime().AddSeconds(tempoRestante2)
        contador2.Text = tempoComoHora.ToString("HH:mm:ss")

        Dim horas As Integer
        Dim minutos As Integer
        Dim segundos As Integer

        If Not Integer.TryParse(horaT.Text, horas) Then
            horas = 0
        End If

        If Not Integer.TryParse(minutoT.Text, minutos) Then
            minutos = 0
        End If

        If Not Integer.TryParse(segundoT.Text, segundos) Then
            segundos = 0
        End If

        If horas < 0 Then horas = 0
        If minutos < 0 Then minutos = 0
        If segundos < 0 Then segundos = 0
        If minutos > 59 Then minutos = 59
        If segundos > 59 Then segundos = 59

        Dim tempoInicial As TimeSpan = New TimeSpan(horas, minutos, segundos)
        tempoRestante = CInt(tempoInicial.TotalSeconds)
        tempoRestante2 = 0
        estado2 = 0

        Dim verificador2 As String = tempoInicial.ToString("hh\:mm\:ss")
        contador2.Text = verificador2
        telaPublica.AtualizarContador(contador2.Text)

        horaT.Enabled = False
        minutoT.Enabled = False
        segundoT.Enabled = False
        CheckBox1.Enabled = False
        CheckBox1.ForeColor = Color.White
        CheckBox1.BackColor = Color.Gray

        btnPlay.Enabled = True
        btnPlay.ForeColor = Color.FromArgb(192, 0, 0)
        btnPlay.BackColor = Color.FromArgb(255, 192, 192)
        btnPlay.Focus()

    End Sub

    Private Sub Button3_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button3.Click
        about.ShowDialog()

    End Sub

    Private Sub Button2_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button2.Click
        FormEULA2.ShowDialog()

    End Sub

    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click
        FormGuiaUso.ShowDialog()

    End Sub

    Private Sub Button4_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button4.Click

        FormGitHub.ShowDialog()

    End Sub

    Private Sub btnCountdown_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCountdown.Click
        If tempoRestante = 0 Then
            modoCountdown = False
        End If

        If Not modoCountdown Then

            'Cria a Tela Central de Espera para exibir o tempo configurado cmo tempo de espera
            telaEspera = New FormEspera()

            ' Passa para ela o tempo configurado
            telaEspera.DefinirTempo(tempoRestante)

            ' Abre a tela
            telaEspera.Show()
            modoCountdown = True
            btnCountdown.Text = "Esconder Tela de Espera"

            ' Esconde o contador público
            telaPublica.Fade(False)
            mostrar = 0
            btnFade.Text = "Mostrar Contador Público"

        Else

            telaEspera.Close()
            telaEspera = Nothing
            modoCountdown = False
            btnCountdown.Text = "Mostrar Contador de Espera"

        End If

    End Sub


    Private Sub btnPosicinaContadorPub_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPosicinaContadorPub.Click

        If Not telaPublica.Posicionar Then

            telaPublica.DefinirPosicao(True)
            btnPosicinaContadorPub.Text = "Colocar na Posição Anterior"

        Else
            telaPublica.DefinirPosicao(False)
            btnPosicinaContadorPub.Text = "Posicionar na Tela Pública"
        End If

    End Sub

End Class