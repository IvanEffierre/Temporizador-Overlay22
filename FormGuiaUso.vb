Public Class FormGuiaUso

    Private Sub FormGuiaUso_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load


        Me.Text = "Guia de Uso"
        'Me.StartPosition = FormStartPosition.CenterScreen


        ' CONFIGURAÇÃO DO RICH TEXT BOX
        rtbConteudo.ReadOnly = True
        rtbConteudo.BackColor = Color.White
        rtbConteudo.ForeColor = Color.Black
        rtbConteudo.Font = New Font(
            "Segoe UI",
            10,
            FontStyle.Regular
        )

        rtbConteudo.WordWrap = True
        rtbConteudo.ScrollBars =
            RichTextBoxScrollBars.Vertical


        ' CARREGA OS TÓPICOS

        lstTopicos.Items.Clear()

        lstTopicos.Items.Add("1. Visão Geral")
        lstTopicos.Items.Add("2. Configurando o Tempo")
        lstTopicos.Items.Add("3. Iniciando a Contagem")
        lstTopicos.Items.Add("4. Últimos 30 Segundos")
        lstTopicos.Items.Add("5. Estouro de Tempo")
        lstTopicos.Items.Add("6. Overlay (Contador Público)")
        lstTopicos.Items.Add("7. Repetir Tempo")
        lstTopicos.Items.Add("8. Dicas e Boas Práticas")
        lstTopicos.Items.Add("9. Outras Informações")

        If lstTopicos.Items.Count > 0 Then
            lstTopicos.SelectedIndex = 0
        End If

    End Sub

    ' ALTERAÇÃO DO TÓPICO

    Private Sub lstTopicos_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles lstTopicos.SelectedIndexChanged

        Select Case lstTopicos.SelectedIndex

            Case 0
                MostrarVisaoGeral()

            Case 1
                MostrarConfiguracaoTempo()

            Case 2
                MostrarInicioContagem()

            Case 3
                MostrarUltimos30Segundos()

            Case 4
                MostrarEstouroTempo()

            Case 5
                MostrarOverlay()

            Case 6
                MostrarRepetirTempo()

            Case 7
                MostrarDicas()

            Case 8
                MostrarInfos()

        End Select

    End Sub


    ' Criação dos elementos presentes no form

    Private Sub MostrarVisaoGeral()

        ExibirConteudo(
            "1. Visão Geral",
            "",
            "O Temporizador Overlay é um contador padrão, desenvolvido para facilitar o controle de tempo em suas atividades, podendo ser iniciado de forma regressiva ou progressiva.",
            "",
            "Principais recursos:",
            "• Desenvolvido para trabalhar com um ou mais monitores",
            "• Configuração de horas, minutos e segundos",
            "• Alerta visual piscante nos últimos 30 segundos",
            "• Permitir estouro de tempo (contagem crescente)",
            "• Contador público (Tela Overlay) visível ou não",
            "• Repetição rápida do último tempo configurado",
            "• Pode ser posicionado em qualquer parte da tela (monitor)",
            "• Pode ser posicionado automaticamente na tela do público",
            "• Funciona em Tela Principal ou Secundária",
            "• Pode exibir contador de espera decrescente para abertura do evento",
            "",
            "Use o painel de configuração para acessar todas as funções.",
            ""
        )

    End Sub


    Private Sub MostrarConfiguracaoTempo()

        ExibirConteudo(
            "2. Configurando o Tempo",
            "",
            "Para Tempo Regressivo:",
            "1. Informe as horas.",
            "2. Informe os minutos.",
            "3. Informe os segundos.",
            "4. Clique em ""Configurar / Definir"".",
            "Assim, o tempo configurado será utilizado como referência para a contagem regressiva.",
            "OBS.: Em contagem regressiva o contador abandona a contagem ao final do tempo decorrido. Para seguir a contagem excedente, permita a ação marcando a opção a opção ""Permitir Estouro de Tempo"".",
            "",
            "",
            "Para Tempo Progressivo",
            "1. Informe as horas como 00.",
            "2. Informe os minutos como 00.",
            "3. Informe os segundos como 00.",
            "Dessa forma o tempo em Horas, Minutos e Segundos será exibido como 00:00:00",
            "2. Marque a opção ""Permitir Estouro de Tempo"".",
            "3. Clique em ""Configurar / Definir"".",
            "Assim, o tempo configurado será utilizado como referência para a contagem progressiva",
            "OBS.: A contagem progressiva somente é possível permitindo o estouro de tempo",
            ""
            )

    End Sub


    Private Sub MostrarInicioContagem()

        ExibirConteudo(
            "3. Iniciando a Contagem",
            "",
            "Depois de configurar o tempo, utilize o botão ""Play / Stop"" para iniciar ou interromper a contagem.",
            "",
            "Durante a execução, o contador será atualizado a cada segundo, tanto na área do Painel de Configuração, quanto na Tela do Público.",
            "",
            "Quando necessário, pressione novamente o botão para interromper a contagem.",
            ""
        )

    End Sub


    Private Sub MostrarUltimos30Segundos()

        ExibirConteudo(
            "4. Últimos 30 Segundos",
            "",
            "Quando o contador entra nos últimos 30 segundos, o sistema ativa o alerta visual.",
            "",
            "Esse recurso permite identificar rapidamente que o tempo configurado está próximo do fim.",
            "",
            "O comportamento visual faz o contador piscar em ambas as telas, além de aplicar destaque em cor vermelha envolvendo o contador.",
            ""
        )

    End Sub


    Private Sub MostrarEstouroTempo()

        ExibirConteudo(
            "5. Estouro de Tempo",
            "",
            "A opção ""Permitir Estouro de Tempo"" permite que o contador continue funcionando depois que a contagem regressiva chegar a zero.",
            "",
            "Quando essa função está habilitada, o contador passa a apresentar o tempo excedido de forma crescente, caso contrário, o contador se encerra ao zerar o tempo decorrido.",
            "",
            "Esse recurso é útil quando é importante saber quanto tempo ultrapassou o limite inicialmente definido ou para monitorar o tempo de forma crescente.",
            ""
        )

    End Sub


    Private Sub MostrarOverlay()

        ExibirConteudo(
            "6. Overlay (Contador Público)",
            "",
            "O contador público é apresentado em uma janela independente que pode permanecer sobre outras aplicações.",
            "",
            "Esse recurso é útil para apresentações, aulas, reuniões, palestras e outras situações em que o tempo precisa permanecer visível.",
            "",
            "O botão ""Esconder / Mostrar Contador Público"" permite controlar a exibição da Tela Overlay que é a tela pública do Software.",
            "",
            "",
            "6.1 Posicionando a Tela Overlay",
            "A Tela Overlay pode ser movida através da sua barra de título. Basta clicar e segurar (com o ponteiro do mouse na barra de título) para mover livremente a Tela Overlay para o local de exibição desejado no monitor.",
            "Ao posicionar no local desejado, recomenda-se esconder a barra de título da Tela Overlay. Para tanto, basta dar um duplo clique no contador da Tela Overlay e a barra de título será ocultada, deixando apenas o contador visível. Para ativar novamente a barra de título, basta dar um novo duplo clique no contador.",
            "",
            "Caso deseje posicionar o contador público de forma automática, basta utilizar o botão ""Posicionar na Tela Pública."" Desta forma o contador público será posicionado automaticamente na tela visível ao público.",
            "OBS.: Caso o sistema detecte dois ou mais monitores, utilizará o monitor secundário. Caso contrário, utilizará o monitor primário-padrão do sistema. Nesse recurso, o Sotfware calcula a proporção e resolução da tela e posiciona o contador público no topo direito da tela e esconde a barra de título automaticamente.",
            ""
        )

    End Sub


    Private Sub MostrarRepetirTempo()

        ExibirConteudo(
            "7. Repetir Tempo",
            "",
            "O botão ""Repetir Tempo"" permite restaurar rapidamente o último tempo configurado.",
            "",
            "Esse recurso é especialmente útil quando o mesmo intervalo de tempo precisa ser utilizado várias vezes.",
            ""
        )

    End Sub


    Private Sub MostrarDicas()

        ExibirConteudo(
            "8. Dicas e Boas Práticas",
            "",
            "• Configure o tempo antes de iniciar a contagem.",
            "• Verifique se a Tela Overlay está visível quando precisar acompanhar o tempo.",
            "• Utilize o recurso de repetição quando trabalhar com intervalos iguais.",
            "• Utilize o alerta visual para acompanhar os momentos finais da contagem.",
            "• Em apresentações, posicione o contador público em uma área de fácil visualização.",
            "• Em apresentações, considere utilizar o botão ""Posicionar na Tela Pública"" para um ajuste mais refinado.",
            ""
            )
    End Sub


    Private Sub MostrarInfos()

        ExibirConteudo(
            "9. Outras Informações",
            "",
            "O painel ""Ajuda e Informações"" exibe atalhos para:",
            "1. Guia de Uso",
            "2. Termos de Licença de Uso",
            "3. Informações sobre este Software",
            "4. Link para Repositório GitHub Oficial desse projeto",
            "",
            "Não foram configurados atalhos de teclado para este software.",
            "",
            "Em caso de dúvidas, consulte a documentação e o Repositório para obter ajuda, informações e atualizações disponíveis.",
            ""
       )

        'glórias a Deus!
    End Sub

    'Metodo para exibir os conteudos

    Private Sub ExibirConteudo(
        ParamArray linhas() As String
    )

        rtbConteudo.Text =
            String.Join(vbCrLf, linhas)


        ' formatar titulos para ficar legal
        If rtbConteudo.Lines.Length > 0 Then

            Dim titulo As String =
                rtbConteudo.Lines(0)

            rtbConteudo.Select(
                0,
                titulo.Length
            )

            rtbConteudo.SelectionFont =
                New Font(
                    "Segoe UI",
                    14,
                    FontStyle.Bold
                )

            rtbConteudo.SelectionColor =
                Color.FromArgb(0, 90, 160)

        End If


        ' Remove a seleção
        rtbConteudo.SelectionStart = 0
        rtbConteudo.SelectionLength = 0

    End Sub


    Private Sub btnFechar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFechar.Click

        Me.Close()

    End Sub

    Private Sub lstTopicos_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstTopicos.DrawItem

        If e.Index < 0 Then Exit Sub
        Dim lista As ListBox = DirectCast(sender, ListBox)

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds)

        Else
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)

        End If
        Dim corTexto As Color
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            corTexto = SystemColors.HighlightText
        Else
            corTexto = SystemColors.ControlText
        End If

        Using pincel As New SolidBrush(corTexto)
            e.Graphics.DrawString(lista.Items(e.Index).ToString(),
                                  e.Font, pincel,
                                  e.Bounds.Left + 5,
                                  e.Bounds.Top + 7
          )

            Using caneta As New Pen(Color.LightGray)
                e.Graphics.DrawLine(caneta,
                                  e.Bounds.Left,
                                  e.Bounds.Bottom - 1,
                                  e.Bounds.Right,
                                  e.Bounds.Bottom - 1
                                  )

            End Using
        End Using
    End Sub
End Class