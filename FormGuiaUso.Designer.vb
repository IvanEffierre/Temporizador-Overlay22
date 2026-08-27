<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuiaUso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGuiaUso))
        lstTopicos = New ListBox()
        rtbConteudo = New RichTextBox()
        btnFechar = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstTopicos
        ' 
        lstTopicos.BorderStyle = BorderStyle.None
        lstTopicos.DrawMode = DrawMode.OwnerDrawFixed
        lstTopicos.Font = New Font("Segoe UI", 10F)
        lstTopicos.FormattingEnabled = True
        lstTopicos.IntegralHeight = False
        lstTopicos.ItemHeight = 32
        lstTopicos.Location = New Point(7, 221)
        lstTopicos.Name = "lstTopicos"
        lstTopicos.Size = New Size(182, 292)
        lstTopicos.TabIndex = 0
        ' 
        ' rtbConteudo
        ' 
        rtbConteudo.BackColor = Color.White
        rtbConteudo.BulletIndent = 2
        rtbConteudo.Font = New Font("Segoe UI", 10F)
        rtbConteudo.Location = New Point(186, 217)
        rtbConteudo.Name = "rtbConteudo"
        rtbConteudo.ReadOnly = True
        rtbConteudo.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbConteudo.Size = New Size(327, 294)
        rtbConteudo.TabIndex = 1
        rtbConteudo.Text = ""
        ' 
        ' btnFechar
        ' 
        btnFechar.Location = New Point(343, 529)
        btnFechar.Name = "btnFechar"
        btnFechar.Size = New Size(167, 41)
        btnFechar.TabIndex = 2
        btnFechar.Text = "Fechar"
        btnFechar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(rtbConteudo)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnFechar)
        Panel1.Location = New Point(6, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(521, 580)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(136, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 21)
        Label2.TabIndex = 10
        Label2.Text = "Contador Regressivo / Progressivo"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Location = New Point(224, 40)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(63, 58)
        Panel2.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.TitleBar
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.CausesValidation = False
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(109, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(303, 37)
        Label4.TabIndex = 11
        Label4.Text = "Temporizador Overlay"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.TitleBar
        Label1.Anchor = AnchorStyles.None
        Label1.CausesValidation = False
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(0, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 50)
        Label1.TabIndex = 5
        Label1.Text = "Guia de Uso"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormGuiaUso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(533, 589)
        Controls.Add(lstTopicos)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormGuiaUso"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "FormGuiaUso"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstTopicos As ListBox
    Friend WithEvents rtbConteudo As RichTextBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
End Class
