Imports System.Diagnostics

Public Class FormGitHub
    'link repositório
    Private Const URL_GITHUB As String =
        "https://github.com/IvanEffierre/Temporizador-Overlay"


    Private Sub FormGitHub_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Me.Text = "GitHub - Temporizador Overlay"
        ' Me.StartPosition = FormStartPosition.CenterScreen

        lblTitulo.Text = "Repositório Oficial"

        lblDescricao.Text =
            "O código-fonte e a documentação do " &
            "Temporizador Overlay estão disponíveis no GitHub."


        Label1.Text =
            "Acesse o Repositório Oficial para:" & vbLf &
            "◆ Ver o Código-fonte" & vbLf &
            "◆ Baixar o Código-fonte" & vbLf &
            "◆ Baixar Atualizações" & vbLf &
            "◆ Reportar Problemas" & vbLf &
            "◆ Sugerir Funcionalidade"




        lnkGitHub.Text =
            "https://github.com/IvanEffierre/Temporizador-Overlay"

    End Sub


    Private Sub btnAbrirGitHub_Click(
        sender As Object,
        e As EventArgs
    )

        AbrirGitHub()

    End Sub


    Private Sub lnkGitHub_LinkClicked(
        sender As Object,
        e As LinkLabelLinkClickedEventArgs
    ) Handles lnkGitHub.LinkClicked

        AbrirGitHub()

    End Sub


    Private Sub AbrirGitHub()

        Try

            Process.Start(
                New ProcessStartInfo With {
                    .FileName = URL_GITHUB,
                    .UseShellExecute = True
                }
            )

        Catch ex As Exception

            MessageBox.Show(
                "Não foi possível abrir o GitHub.",
                "Temporizador Overlay",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        End Try

    End Sub


    Private Sub btnFechar_Click(
        sender As Object,
        e As EventArgs
    )

        Close()

    End Sub

    Private Sub btnFechar_Click_1(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub
End Class