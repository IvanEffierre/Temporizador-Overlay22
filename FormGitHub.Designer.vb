<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGitHub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGitHub))
        lblDescricao = New Label()
        lnkGitHub = New LinkLabel()
        btnFechar = New Button()
        lblTitulo = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        SuspendLayout()
        ' 
        ' lblDescricao
        ' 
        lblDescricao.Anchor = AnchorStyles.None
        lblDescricao.BackColor = SystemColors.Control
        lblDescricao.Font = New Font("Segoe UI", 10F)
        lblDescricao.Location = New Point(96, 178)
        lblDescricao.Name = "lblDescricao"
        lblDescricao.Size = New Size(336, 40)
        lblDescricao.TabIndex = 0
        lblDescricao.Text = "Label1"
        lblDescricao.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lnkGitHub
        ' 
        lnkGitHub.Anchor = AnchorStyles.None
        lnkGitHub.BackColor = SystemColors.Control
        lnkGitHub.Font = New Font("Segoe UI", 12F)
        lnkGitHub.LinkBehavior = LinkBehavior.NeverUnderline
        lnkGitHub.Location = New Point(12, 327)
        lnkGitHub.Name = "lnkGitHub"
        lnkGitHub.Size = New Size(493, 26)
        lnkGitHub.TabIndex = 1
        lnkGitHub.TabStop = True
        lnkGitHub.Text = "LinkLabel1"
        lnkGitHub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnFechar
        ' 
        btnFechar.Location = New Point(329, 495)
        btnFechar.Name = "btnFechar"
        btnFechar.Size = New Size(167, 41)
        btnFechar.TabIndex = 3
        btnFechar.Text = "Fechar"
        btnFechar.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AccessibleRole = AccessibleRole.TitleBar
        lblTitulo.Anchor = AnchorStyles.None
        lblTitulo.BackColor = SystemColors.Control
        lblTitulo.CausesValidation = False
        lblTitulo.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitulo.Location = New Point(12, 292)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(493, 50)
        lblTitulo.TabIndex = 6
        lblTitulo.Text = "GitHub"
        lblTitulo.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(136, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 21)
        Label2.TabIndex = 7
        Label2.Text = "Contador Regressivo / Progressivo"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Location = New Point(224, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(63, 58)
        Panel1.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.TitleBar
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.CausesValidation = False
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(109, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(303, 37)
        Label4.TabIndex = 8
        Label4.Text = "Temporizador Overlay"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Location = New Point(225, 227)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(70, 69)
        Panel2.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(113, 357)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 132)
        Label1.TabIndex = 11
        Label1.Text = "Label1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Location = New Point(9, 7)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(500, 537)
        Panel3.TabIndex = 12
        ' 
        ' FormGitHub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(517, 550)
        Controls.Add(lnkGitHub)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(lblTitulo)
        Controls.Add(btnFechar)
        Controls.Add(lblDescricao)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormGitHub"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FormGitHub"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDescricao As Label
    Friend WithEvents lnkGitHub As LinkLabel
    Friend WithEvents btnFechar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
End Class
