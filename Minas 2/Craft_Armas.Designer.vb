<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Craft_Armas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Craft_Armas))
        Me.SeletorMenu = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.seletorArma = New System.Windows.Forms.ComboBox()
        Me.txtQuantidadeArmas = New System.Windows.Forms.TextBox()
        Me.btnCraftArmas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAço = New System.Windows.Forms.TextBox()
        Me.txtAluminio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtABS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBorracha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMolas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPMetal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPolimero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBronze = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtParafusos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblEncomenda = New System.Windows.Forms.Label()
        Me.txtbpPistol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBPSMG = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBPRifle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SeletorMenu
        '
        Me.SeletorMenu.FormattingEnabled = True
        Me.SeletorMenu.Location = New System.Drawing.Point(439, 41)
        Me.SeletorMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SeletorMenu.Name = "SeletorMenu"
        Me.SeletorMenu.Size = New System.Drawing.Size(201, 28)
        Me.SeletorMenu.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Selecionar Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(187, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Craft de Armas"
        '
        'seletorArma
        '
        Me.seletorArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seletorArma.FormattingEnabled = True
        Me.seletorArma.Items.AddRange(New Object() {"Vintage", "Fajuta", "Revolver", "Tec-9", "Deagle", "Double Barrel", "Micro", "Thompson", "Draco", "PDW", "AK", "Famas"})
        Me.seletorArma.Location = New System.Drawing.Point(129, 86)
        Me.seletorArma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.seletorArma.Name = "seletorArma"
        Me.seletorArma.Size = New System.Drawing.Size(101, 28)
        Me.seletorArma.TabIndex = 27
        '
        'txtQuantidadeArmas
        '
        Me.txtQuantidadeArmas.Location = New System.Drawing.Point(241, 86)
        Me.txtQuantidadeArmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantidadeArmas.Name = "txtQuantidadeArmas"
        Me.txtQuantidadeArmas.Size = New System.Drawing.Size(70, 27)
        Me.txtQuantidadeArmas.TabIndex = 28
        Me.txtQuantidadeArmas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCraftArmas
        '
        Me.btnCraftArmas.Location = New System.Drawing.Point(323, 86)
        Me.btnCraftArmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCraftArmas.Name = "btnCraftArmas"
        Me.btnCraftArmas.Size = New System.Drawing.Size(73, 27)
        Me.btnCraftArmas.TabIndex = 29
        Me.btnCraftArmas.Text = "Craftar"
        Me.btnCraftArmas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Aço"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAço
        '
        Me.txtAço.Enabled = False
        Me.txtAço.Location = New System.Drawing.Point(17, 131)
        Me.txtAço.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAço.Name = "txtAço"
        Me.txtAço.Size = New System.Drawing.Size(70, 27)
        Me.txtAço.TabIndex = 40
        Me.txtAço.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAluminio
        '
        Me.txtAluminio.Enabled = False
        Me.txtAluminio.Location = New System.Drawing.Point(17, 209)
        Me.txtAluminio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAluminio.Name = "txtAluminio"
        Me.txtAluminio.Size = New System.Drawing.Size(70, 27)
        Me.txtAluminio.TabIndex = 42
        Me.txtAluminio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Aliminio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtABS
        '
        Me.txtABS.Enabled = False
        Me.txtABS.Location = New System.Drawing.Point(17, 170)
        Me.txtABS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtABS.Name = "txtABS"
        Me.txtABS.Size = New System.Drawing.Size(70, 27)
        Me.txtABS.TabIndex = 44
        Me.txtABS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "ABS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBorracha
        '
        Me.txtBorracha.Enabled = False
        Me.txtBorracha.Location = New System.Drawing.Point(183, 131)
        Me.txtBorracha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorracha.Name = "txtBorracha"
        Me.txtBorracha.Size = New System.Drawing.Size(70, 27)
        Me.txtBorracha.TabIndex = 46
        Me.txtBorracha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Borracha"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMolas
        '
        Me.txtMolas.Enabled = False
        Me.txtMolas.Location = New System.Drawing.Point(183, 211)
        Me.txtMolas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMolas.Name = "txtMolas"
        Me.txtMolas.Size = New System.Drawing.Size(70, 27)
        Me.txtMolas.TabIndex = 48
        Me.txtMolas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Molas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPMetal
        '
        Me.txtPMetal.Enabled = False
        Me.txtPMetal.Location = New System.Drawing.Point(352, 171)
        Me.txtPMetal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPMetal.Name = "txtPMetal"
        Me.txtPMetal.Size = New System.Drawing.Size(70, 27)
        Me.txtPMetal.TabIndex = 50
        Me.txtPMetal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Pedaços de Metal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPolimero
        '
        Me.txtPolimero.Enabled = False
        Me.txtPolimero.Location = New System.Drawing.Point(352, 211)
        Me.txtPolimero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPolimero.Name = "txtPolimero"
        Me.txtPolimero.Size = New System.Drawing.Size(70, 27)
        Me.txtPolimero.TabIndex = 52
        Me.txtPolimero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Polimero"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBronze
        '
        Me.txtBronze.Enabled = False
        Me.txtBronze.Location = New System.Drawing.Point(183, 171)
        Me.txtBronze.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBronze.Name = "txtBronze"
        Me.txtBronze.Size = New System.Drawing.Size(70, 27)
        Me.txtBronze.TabIndex = 56
        Me.txtBronze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Bronze"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtParafusos
        '
        Me.txtParafusos.Enabled = False
        Me.txtParafusos.Location = New System.Drawing.Point(352, 131)
        Me.txtParafusos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtParafusos.Name = "txtParafusos"
        Me.txtParafusos.Size = New System.Drawing.Size(70, 27)
        Me.txtParafusos.TabIndex = 58
        Me.txtParafusos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(428, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Parafusos"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(567, 248)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(73, 27)
        Me.btnReset.TabIndex = 59
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblEncomenda
        '
        Me.lblEncomenda.AutoSize = True
        Me.lblEncomenda.Location = New System.Drawing.Point(567, 131)
        Me.lblEncomenda.Name = "lblEncomenda"
        Me.lblEncomenda.Size = New System.Drawing.Size(90, 20)
        Me.lblEncomenda.TabIndex = 60
        Me.lblEncomenda.Text = "Encomenda:"
        '
        'txtbpPistol
        '
        Me.txtbpPistol.Enabled = False
        Me.txtbpPistol.Location = New System.Drawing.Point(17, 248)
        Me.txtbpPistol.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbpPistol.Name = "txtbpPistol"
        Me.txtbpPistol.Size = New System.Drawing.Size(70, 27)
        Me.txtbpPistol.TabIndex = 62
        Me.txtbpPistol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "BP Pistol"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBPSMG
        '
        Me.txtBPSMG.Enabled = False
        Me.txtBPSMG.Location = New System.Drawing.Point(183, 248)
        Me.txtBPSMG.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBPSMG.Name = "txtBPSMG"
        Me.txtBPSMG.Size = New System.Drawing.Size(70, 27)
        Me.txtBPSMG.TabIndex = 64
        Me.txtBPSMG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(259, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 20)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "BP SMG"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBPRifle
        '
        Me.txtBPRifle.Enabled = False
        Me.txtBPRifle.Location = New System.Drawing.Point(352, 248)
        Me.txtBPRifle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBPRifle.Name = "txtBPRifle"
        Me.txtBPRifle.Size = New System.Drawing.Size(70, 27)
        Me.txtBPRifle.TabIndex = 66
        Me.txtBPRifle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(428, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 20)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "BP Rifle"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Craft_Armas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 310)
        Me.Controls.Add(Me.txtBPRifle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBPSMG)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtbpPistol)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblEncomenda)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtParafusos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBronze)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPolimero)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPMetal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMolas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBorracha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtABS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAluminio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAço)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCraftArmas)
        Me.Controls.Add(Me.txtQuantidadeArmas)
        Me.Controls.Add(Me.seletorArma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SeletorMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Craft_Armas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas 2 - Craft de Armas e Acessorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeletorMenu As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents seletorArma As ComboBox
    Friend WithEvents txtQuantidadeArmas As TextBox
    Friend WithEvents btnCraftArmas As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAço As TextBox
    Friend WithEvents txtAluminio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtABS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBorracha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMolas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPMetal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPolimero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBronze As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtParafusos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblEncomenda As Label
    Friend WithEvents txtbpPistol As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBPSMG As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBPRifle As TextBox
    Friend WithEvents Label14 As Label
End Class
