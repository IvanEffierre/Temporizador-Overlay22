<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEULA2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEULA2))
        rtbEULA = New RichTextBox()
        btnAceitar = New Button()
        chkAceite = New CheckBox()
        btnRecusar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' rtbEULA
        ' 
        rtbEULA.Location = New Point(20, 226)
        rtbEULA.Name = "rtbEULA"
        rtbEULA.Size = New Size(466, 262)
        rtbEULA.TabIndex = 0
        rtbEULA.Text = ""
        ' 
        ' btnAceitar
        ' 
        btnAceitar.Enabled = False
        btnAceitar.Location = New Point(137, 515)
        btnAceitar.Name = "btnAceitar"
        btnAceitar.Size = New Size(167, 41)
        btnAceitar.TabIndex = 1
        btnAceitar.Text = "Aceitar"
        btnAceitar.UseVisualStyleBackColor = True
        btnAceitar.Visible = False
        ' 
        ' chkAceite
        ' 
        chkAceite.AutoSize = True
        chkAceite.Checked = True
        chkAceite.CheckState = CheckState.Checked
        chkAceite.Enabled = False
        chkAceite.Font = New Font("Segoe UI", 10F)
        chkAceite.Location = New Point(7, 490)
        chkAceite.Name = "chkAceite"
        chkAceite.Size = New Size(282, 23)
        chkAceite.TabIndex = 2
        chkAceite.Text = "O usuário já aceitou os termos da Licença"
        chkAceite.UseVisualStyleBackColor = True
        ' 
        ' btnRecusar
        ' 
        btnRecusar.Enabled = False
        btnRecusar.Location = New Point(310, 515)
        btnRecusar.Name = "btnRecusar"
        btnRecusar.Size = New Size(167, 41)
        btnRecusar.TabIndex = 3
        btnRecusar.Text = "Recusar"
        btnRecusar.UseVisualStyleBackColor = True
        btnRecusar.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.TitleBar
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = SystemColors.Control
        Label1.CausesValidation = False
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(17, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(477, 37)
        Label1.TabIndex = 4
        Label1.Text = "Termos de Uso"
        Label1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.TitleBar
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.CausesValidation = False
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(375, 21)
        Label2.TabIndex = 5
        Label2.Text = "Leia atentamente os termos baixo antes de continuar"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnRecusar)
        Panel1.Controls.Add(chkAceite)
        Panel1.Controls.Add(btnAceitar)
        Panel1.Controls.Add(rtbEULA)
        Panel1.Location = New Point(6, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 566)
        Panel1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(310, 515)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 41)
        Button1.TabIndex = 13
        Button1.Text = "Fechar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(129, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 21)
        Label3.TabIndex = 10
        Label3.Text = "Contador Regressivo / Progressivo"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Location = New Point(217, 47)
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
        Label4.Location = New Point(102, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(303, 37)
        Label4.TabIndex = 11
        Label4.Text = "Temporizador Overlay"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormEULA2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(519, 577)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MaximumSize = New Size(519, 577)
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        MinimumSize = New Size(519, 577)
        Name = "FormEULA2"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Temporizador Overlay - Aceite os Termos de Uso para Prosseguir"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rtbEULA As RichTextBox
    Friend WithEvents btnAceitar As Button
    Friend WithEvents chkAceite As CheckBox
    Friend WithEvents btnRecusar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
