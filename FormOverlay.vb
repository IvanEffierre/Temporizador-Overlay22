Public Class FormOverlay

    Private piscando As Boolean = False
    Private estadoPiscando As Boolean = True

    Private Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Private Const HTCAPTION As Integer = 2


    Private Sub FormOverlay_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Me.TopMost = True
        Me.ShowInTaskbar = False
        Me.Opacity = 0.4

        TimerPisca.Interval = 200
        TimerPisca.Stop()

        contadorPublico.Visible = True
        contadorPublico.BackColor = SystemColors.Control

    End Sub

    Public Sub Fade(ativo As Boolean)

        If ativo Then

            Me.TopMost = True
            Me.ShowInTaskbar = True
            Me.Opacity = 0.4
        Else
            Me.Opacity = 0.0
        End If

    End Sub


    Public Sub AtualizarContador(valor As String)

        contadorPublico.Text = valor

    End Sub


    Public Sub DefinirCrescente(ativo As Boolean)

        If ativo Then
            contadorPublico.BackColor = Color.Red
        Else
            contadorPublico.BackColor = SystemColors.Control
        End If

    End Sub


    Public Sub DefinirPisca(ativar As Boolean)

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

            estadoPiscando = Not estadoPiscando

            contadorPublico.Visible = estadoPiscando

        Else

            contadorPublico.Visible = True

        End If

    End Sub

    Private Sub contadorPublico_Click(sender As Object, e As EventArgs) Handles contadorPublico.Click

    End Sub

    Private Sub contadorPublico_DoubleClick(sender As Object, e As EventArgs) Handles contadorPublico.DoubleClick



        If Me.FormBorderStyle = FormBorderStyle.SizableToolWindow Then
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        End If



    End Sub
End Class