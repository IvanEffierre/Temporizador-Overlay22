
Imports System.Reflection
Imports System.Diagnostics


Public Class about
    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim versaoCompleta As String = Application.ProductVersion
        Dim apenasOHash As String
        ' Verifica se o sinal de "+" existe no texto antes de tentar cortar
        If versaoCompleta.Contains("+") Then
            ' O índice (1) pega tudo o que está DEPOIS do "+"
            apenasOHash = versaoCompleta.Split("+"c)(1)

        End If


        Label1.Text =
"Temporizador-Overlay
Desenvolvido por: Valdivan Ramos
© 2026 - Todos os direitos reservados.
______________________________________________

Versão: " & My.Application.Info.Version.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class