<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEspera
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
        Timer1 = New Timer(components)
        labelHoraInicial = New Label()
        TimerFade = New Timer(components)
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' labelHoraInicial
        ' 
        labelHoraInicial.Anchor = AnchorStyles.None
        labelHoraInicial.FlatStyle = FlatStyle.Flat
        labelHoraInicial.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        labelHoraInicial.Location = New Point(9, 31)
        labelHoraInicial.Margin = New Padding(0)
        labelHoraInicial.Name = "labelHoraInicial"
        labelHoraInicial.Size = New Size(837, 382)
        labelHoraInicial.TabIndex = 0
        labelHoraInicial.Text = "00:00"
        labelHoraInicial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TimerFade
        ' 
        TimerFade.Interval = 50
        ' 
        ' FormEspera
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(855, 450)
        Controls.Add(labelHoraInicial)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "FormEspera"
        Text = "FormEspera"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents labelHoraInicial As Label
    Friend WithEvents TimerFade As Timer
End Class
