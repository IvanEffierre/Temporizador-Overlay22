<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Label5 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(18, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(428, 209)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(113, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 21)
        Label2.TabIndex = 1
        Label2.Text = "Contador Regressivo / Progressivo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(85, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(302, 21)
        Label3.TabIndex = 1
        Label3.Text = " com 2 Telas Sobrepostas e Independentes"
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.TitleBar
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.CausesValidation = False
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(86, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(303, 37)
        Label4.TabIndex = 5
        Label4.Text = "Temporizador Overlay"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Location = New Point(205, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(63, 58)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(5, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(464, 487)
        Panel2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(290, 437)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 41)
        Button1.TabIndex = 7
        Button1.Text = "Fechar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AccessibleRole = AccessibleRole.TitleBar
        Label5.Anchor = AnchorStyles.None
        Label5.CausesValidation = False
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label5.Location = New Point(-28, 222)
        Label5.Name = "Label5"
        Label5.Size = New Size(521, 50)
        Label5.TabIndex = 8
        Label5.Text = "Sobre"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' about
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(474, 496)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "about"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Sobre o Temporizador Overlay"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
