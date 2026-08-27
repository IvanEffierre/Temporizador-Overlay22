<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Painel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Painel))
        Label1 = New Label()
        Timer1 = New Timer(components)
        contador2 = New Label()
        btnPlay = New Button()
        horaT = New TextBox()
        minutoT = New TextBox()
        segundoT = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnConfigurar = New Button()
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        labelInfo = New Label()
        TimerPisca = New Timer(components)
        btnFade = New Button()
        btnRepetir = New Button()
        GroupBox2 = New GroupBox()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.TitleBar
        Label1.CausesValidation = False
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(453, 50)
        Label1.TabIndex = 0
        Label1.Text = "Painel de Configuração"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' contador2
        ' 
        contador2.Font = New Font("Segoe UI", 38F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        contador2.Location = New Point(3, 239)
        contador2.Name = "contador2"
        contador2.Size = New Size(450, 63)
        contador2.TabIndex = 1
        contador2.Text = "00:00:00"
        contador2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPlay
        ' 
        btnPlay.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnPlay.Enabled = False
        btnPlay.Font = New Font("Segoe UI", 12F)
        btnPlay.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnPlay.Location = New Point(110, 314)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(239, 36)
        btnPlay.TabIndex = 2
        btnPlay.Text = "Play / Stop"
        btnPlay.UseVisualStyleBackColor = False
        ' 
        ' horaT
        ' 
        horaT.Enabled = False
        horaT.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        horaT.Location = New Point(77, 53)
        horaT.Margin = New Padding(100)
        horaT.MaxLength = 2
        horaT.Name = "horaT"
        horaT.Size = New Size(69, 35)
        horaT.TabIndex = 1
        horaT.Text = "00"
        horaT.TextAlign = HorizontalAlignment.Center
        horaT.WordWrap = False
        ' 
        ' minutoT
        ' 
        minutoT.Enabled = False
        minutoT.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        minutoT.Location = New Point(163, 53)
        minutoT.Margin = New Padding(100)
        minutoT.MaxLength = 2
        minutoT.Name = "minutoT"
        minutoT.Size = New Size(69, 35)
        minutoT.TabIndex = 2
        minutoT.Text = "00"
        minutoT.TextAlign = HorizontalAlignment.Center
        minutoT.WordWrap = False
        ' 
        ' segundoT
        ' 
        segundoT.Enabled = False
        segundoT.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        segundoT.Location = New Point(247, 53)
        segundoT.Margin = New Padding(100)
        segundoT.MaxLength = 2
        segundoT.Name = "segundoT"
        segundoT.Size = New Size(69, 35)
        segundoT.TabIndex = 3
        segundoT.Text = "00"
        segundoT.TextAlign = HorizontalAlignment.Center
        segundoT.WordWrap = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 4
        Label2.Text = "Hora"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(163, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 25)
        Label3.TabIndex = 4
        Label3.Text = "Min"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(247, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 25)
        Label4.TabIndex = 4
        Label4.Text = "Seg"
        ' 
        ' btnConfigurar
        ' 
        btnConfigurar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnConfigurar.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnConfigurar.Location = New Point(78, 94)
        btnConfigurar.Name = "btnConfigurar"
        btnConfigurar.Size = New Size(239, 36)
        btnConfigurar.TabIndex = 4
        btnConfigurar.Text = "Configurar / Definir"
        btnConfigurar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(minutoT)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(btnConfigurar)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(horaT)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(segundoT)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Segoe UI", 12F)
        GroupBox1.Location = New Point(37, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(383, 170)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Configurar Tempo"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Gray
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Enabled = False
        CheckBox1.FlatAppearance.BorderSize = 5
        CheckBox1.Font = New Font("Segoe UI", 10F)
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(95, 136)
        CheckBox1.Margin = New Padding(0)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Padding = New Padding(8, 1, 1, 1)
        CheckBox1.Size = New Size(205, 25)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Permitir Estouro de Tempo?"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' labelInfo
        ' 
        labelInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        labelInfo.Font = New Font("Segoe UI", 10F)
        labelInfo.ForeColor = Color.Red
        labelInfo.Location = New Point(3, 239)
        labelInfo.Name = "labelInfo"
        labelInfo.Size = New Size(447, 63)
        labelInfo.TabIndex = 6
        labelInfo.Text = "Label5"
        labelInfo.TextAlign = ContentAlignment.MiddleCenter
        labelInfo.Visible = False
        ' 
        ' TimerPisca
        ' 
        TimerPisca.Interval = 250
        ' 
        ' btnFade
        ' 
        btnFade.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnFade.Font = New Font("Segoe UI", 8F)
        btnFade.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnFade.Location = New Point(101, 69)
        btnFade.Margin = New Padding(0)
        btnFade.Name = "btnFade"
        btnFade.Size = New Size(167, 41)
        btnFade.TabIndex = 2
        btnFade.Text = "      Esconder / Mostrar       Contador Público"
        btnFade.UseVisualStyleBackColor = False
        ' 
        ' btnRepetir
        ' 
        btnRepetir.BackColor = Color.Gray
        btnRepetir.Font = New Font("Segoe UI", 8F)
        btnRepetir.ForeColor = Color.White
        btnRepetir.Location = New Point(101, 26)
        btnRepetir.Name = "btnRepetir"
        btnRepetir.Size = New Size(167, 41)
        btnRepetir.TabIndex = 7
        btnRepetir.Text = "Repetir Último Tempo"
        btnRepetir.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox2.Controls.Add(btnFade)
        GroupBox2.Controls.Add(btnRepetir)
        GroupBox2.FlatStyle = FlatStyle.Popup
        GroupBox2.Font = New Font("Segoe UI", 12F)
        GroupBox2.Location = New Point(48, 363)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(356, 119)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Outras Funções"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Location = New Point(-11, 309)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(478, 46)
        Panel1.TabIndex = 9
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Font = New Font("Segoe UI", 12F)
        GroupBox3.Location = New Point(12, 486)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(0)
        GroupBox3.Size = New Size(430, 95)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Ajuda e Informações"
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLight
        Button4.Font = New Font("Segoe UI", 10F)
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.TopCenter
        Button4.Location = New Point(324, 25)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 64)
        Button4.TabIndex = 17
        Button4.Text = "GitHub"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlLight
        Button3.Font = New Font("Segoe UI", 10F)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(220, 25)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 64)
        Button3.TabIndex = 16
        Button3.Text = "Sobre"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLight
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.Location = New Point(115, 25)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 64)
        Button2.TabIndex = 15
        Button2.Text = "Termos"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLight
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(11, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 64)
        Button1.TabIndex = 14
        Button1.Text = "Guia de Uso"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7F)
        Label5.Location = New Point(122, 591)
        Label5.Name = "Label5"
        Label5.Size = New Size(216, 12)
        Label5.TabIndex = 11
        Label5.Text = "Software Livre - © Copyright by Valdivan Ramos"
        ' 
        ' Painel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 608)
        Controls.Add(Label5)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(labelInfo)
        Controls.Add(GroupBox1)
        Controls.Add(btnPlay)
        Controls.Add(contador2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Painel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Temporizador Overlay  -  Painel de Configuração"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents contador2 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents horaT As TextBox
    Friend WithEvents minutoT As TextBox
    Friend WithEvents segundoT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConfigurar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents labelInfo As Label
    Friend WithEvents TimerPisca As Timer
    Friend WithEvents btnFade As Button
    Friend WithEvents btnRepetir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label

End Class
