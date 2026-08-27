Imports System.IO
Imports System.Reflection
Imports System.Configuration
Imports System.Diagnostics


Public Class FormEULA2

    Private Sub FormEULA_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Botão Aceitar começa desabilitado
        btnAceitar.Enabled = False

        ' Impede edição do texto
        rtbEULA.ReadOnly = True

        ' Configura aparência do RichTextBox
        rtbEULA.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        rtbEULA.BackColor = Color.White
        rtbEULA.ForeColor = Color.Black
        rtbEULA.WordWrap = True
        rtbEULA.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbEULA.DetectUrls = True
        chkAceite.Checked = True
        ' Carrega o EULA incorporado no executável
        CarregarEULA()

    End Sub


    Private Sub CarregarEULA()

        Dim assembly As Assembly =
            Assembly.GetExecutingAssembly()

        ' Procura o recurso EULA.txt incorporado no EXE
        Dim nomeRecurso As String = Nothing

        For Each nome As String In assembly.GetManifestResourceNames()

            If nome.EndsWith(
                "eula.txt",
                StringComparison.OrdinalIgnoreCase
            ) Then

                nomeRecurso = nome
                Exit For

            End If

        Next


        ' Verifica se encontrou o arquivo
        If nomeRecurso Is Nothing Then

            MessageBox.Show(
                "Não foi possível carregar o EULA.",
                "Temporizador Overlay",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            btnAceitar.Enabled = False

            Exit Sub

        End If


        ' Abre o recurso incorporado
        Using stream As Stream =
            assembly.GetManifestResourceStream(nomeRecurso)

            If stream Is Nothing Then

                MessageBox.Show(
                    "Não foi possível acessar o conteúdo do EULA.",
                    "Temporizador Overlay",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                Exit Sub

            End If


            Using reader As New StreamReader(stream)

                Dim texto As String =
                    reader.ReadToEnd()

                ' Formata o conteúdo antes de exibir
                FormatarEULA(texto)

            End Using

        End Using

    End Sub


    Private Sub FormatarEULA(texto As String)

        rtbEULA.ReadOnly = False

        rtbEULA.Clear()

        ' Divide o texto em linhas
        Dim linhas() As String =
            texto.Replace(vbCrLf, vbLf).Split(vbLf)


        For Each linha As String In linhas

            Dim textoLinha As String =
                linha.Trim()


            ' Título principal
            If textoLinha.StartsWith("# ") Then

                Dim titulo As String =
                    textoLinha.Substring(2).Trim()

                AdicionarTituloPrincipal(titulo)


                ' Título de seção
            ElseIf textoLinha.StartsWith("## ") Then

                Dim titulo As String =
                    textoLinha.Substring(3).Trim()

                AdicionarTituloSecao(titulo)


                ' Linha em branco
            ElseIf String.IsNullOrWhiteSpace(textoLinha) Then

                rtbEULA.AppendText(vbCrLf)


                ' Texto normal
            Else

                AdicionarTextoFormatado(textoLinha)

            End If

        Next


        ' Volta o cursor para o início
        rtbEULA.SelectionStart = 0
        rtbEULA.SelectionLength = 0

        ' Impede edição novamente
        rtbEULA.ReadOnly = True

    End Sub


    ' Título principal
    Private Sub AdicionarTituloPrincipal(titulo As String)

        Dim inicio As Integer =
            rtbEULA.TextLength

        rtbEULA.AppendText(
            titulo & vbCrLf
        )

        rtbEULA.Select(
            inicio,
            titulo.Length
        )

        rtbEULA.SelectionFont =
            New Font(
                "Segoe UI",
                15,
                FontStyle.Bold
            )

        rtbEULA.SelectionColor =
            Color.FromArgb(0, 70, 130)

        rtbEULA.SelectionAlignment =
            HorizontalAlignment.Center

        rtbEULA.AppendText(vbCrLf)

        ' Volta alinhamento para esquerda
        rtbEULA.SelectionAlignment =
            HorizontalAlignment.Left

    End Sub


    ' Título de seção
    Private Sub AdicionarTituloSecao(titulo As String)

        ' Espaçamento antes da seção
        rtbEULA.AppendText(vbCrLf)

        Dim inicio As Integer =
            rtbEULA.TextLength

        rtbEULA.AppendText(
            titulo & vbCrLf
        )

        rtbEULA.Select(
            inicio,
            titulo.Length
        )

        rtbEULA.SelectionFont =
            New Font(
                "Segoe UI",
                11,
                FontStyle.Bold
            )

        rtbEULA.SelectionColor =
            Color.FromArgb(0, 90, 160)

    End Sub


    ' Texto
    Private Sub AdicionarTextoFormatado(texto As String)

        ' Remove elementos Markdown
        texto =
            texto.Replace("**", "")

        texto =
            texto.Replace("`", "")


        Dim posDoisPontos As Integer =
            texto.IndexOf(":")


        If posDoisPontos > 0 AndAlso
           posDoisPontos < 30 Then

            Dim rotulo As String =
                texto.Substring(
                    0,
                    posDoisPontos + 1
                )

            Dim valor As String =
                texto.Substring(
                    posDoisPontos + 1
                ).Trim()


            Dim inicio As Integer =
                rtbEULA.TextLength

            ' Adiciona o rótulo
            rtbEULA.AppendText(rotulo)

            ' Formata o rótulo em negrito
            rtbEULA.Select(
                inicio,
                rotulo.Length
            )

            rtbEULA.SelectionFont =
                New Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                )

            rtbEULA.SelectionColor =
                Color.Black


            ' Adiciona o valor
            rtbEULA.Select(
                rtbEULA.TextLength,
                0
            )

            rtbEULA.AppendText(
                " " & valor & vbCrLf
            )

        Else

            ' Texto normal
            rtbEULA.Select(
                rtbEULA.TextLength,
                0
            )

            rtbEULA.SelectionFont =
                New Font(
                    "Segoe UI",
                    10,
                    FontStyle.Regular
                )

            rtbEULA.SelectionColor =
                Color.Black

            rtbEULA.AppendText(
                texto & vbCrLf
            )

        End If

    End Sub


    ' Checkbox de aceite
    Private Sub chkAceite_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkAceite.CheckedChanged

        ' Só permite aceitar se o checkbox estiver marcado
        btnAceitar.Enabled =
            chkAceite.Checked

    End Sub


    ' Botão Aceitar
    Private Sub btnAceitar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAceitar.Click




    End Sub


    ' Botão Recusar
    Private Sub btnRecusar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRecusar.Click



    End Sub


    Private Sub Button1_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button1.Click


        Me.Close()
    End Sub

End Class