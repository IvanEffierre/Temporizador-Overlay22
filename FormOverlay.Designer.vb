<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOverlay
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        contadorPublico = New Label()
        TimerPisca = New Timer(components)
        SuspendLayout()
        ' 
        ' contadorPublico
        ' 
        contadorPublico.BackColor = Color.Gainsboro
        contadorPublico.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        contadorPublico.Location = New Point(-6, -9)
        contadorPublico.MaximumSize = New Size(144, 42)
        contadorPublico.MinimumSize = New Size(144, 42)
        contadorPublico.Name = "contadorPublico"
        contadorPublico.Size = New Size(144, 42)
        contadorPublico.TabIndex = 0
        contadorPublico.Text = "00:00:00"
        contadorPublico.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TimerPisca
        ' 
        TimerPisca.Interval = 250
        ' 
        ' FormOverlay
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(146, 28)
        Controls.Add(contadorPublico)
        Name = "FormOverlay"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.Manual
        Text = "Tela Overlay (Pública)"
        ResumeLayout(False)
    End Sub

    Friend WithEvents contadorPublico As Label
    Friend WithEvents TimerPisca As Timer
End Class
