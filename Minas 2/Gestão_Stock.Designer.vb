<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestão_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestão_Stock))
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.seletorStockEquipa = New System.Windows.Forms.ComboBox()
        Me.seletorMenu = New System.Windows.Forms.ComboBox()
        Me.txtStockVidro = New System.Windows.Forms.TextBox()
        Me.txtStockCobre = New System.Windows.Forms.TextBox()
        Me.txtStockPrata = New System.Windows.Forms.TextBox()
        Me.txtStockFerro = New System.Windows.Forms.TextBox()
        Me.txtStockAreia = New System.Windows.Forms.TextBox()
        Me.txtStockPedra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.txtPrata = New System.Windows.Forms.TextBox()
        Me.txtCobre = New System.Windows.Forms.TextBox()
        Me.txtVidro = New System.Windows.Forms.TextBox()
        Me.txtFatura = New System.Windows.Forms.TextBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStockMinério = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(260, 349)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(94, 29)
        Me.btnRetirar.TabIndex = 35
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Quantidade a Retirar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(277, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Equipa"
        '
        'seletorStockEquipa
        '
        Me.seletorStockEquipa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seletorStockEquipa.FormattingEnabled = True
        Me.seletorStockEquipa.Location = New System.Drawing.Point(234, 99)
        Me.seletorStockEquipa.Name = "seletorStockEquipa"
        Me.seletorStockEquipa.Size = New System.Drawing.Size(151, 28)
        Me.seletorStockEquipa.TabIndex = 31
        '
        'seletorMenu
        '
        Me.seletorMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seletorMenu.FormattingEnabled = True
        Me.seletorMenu.Items.AddRange(New Object() {"Calculadora Mina Legal", "Craft Polvora"})
        Me.seletorMenu.Location = New System.Drawing.Point(103, 39)
        Me.seletorMenu.Name = "seletorMenu"
        Me.seletorMenu.Size = New System.Drawing.Size(229, 28)
        Me.seletorMenu.TabIndex = 30
        '
        'txtStockVidro
        '
        Me.txtStockVidro.Location = New System.Drawing.Point(82, 303)
        Me.txtStockVidro.Name = "txtStockVidro"
        Me.txtStockVidro.ReadOnly = True
        Me.txtStockVidro.Size = New System.Drawing.Size(74, 27)
        Me.txtStockVidro.TabIndex = 29
        Me.txtStockVidro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStockCobre
        '
        Me.txtStockCobre.Location = New System.Drawing.Point(82, 270)
        Me.txtStockCobre.Name = "txtStockCobre"
        Me.txtStockCobre.ReadOnly = True
        Me.txtStockCobre.Size = New System.Drawing.Size(74, 27)
        Me.txtStockCobre.TabIndex = 28
        Me.txtStockCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStockPrata
        '
        Me.txtStockPrata.Location = New System.Drawing.Point(82, 237)
        Me.txtStockPrata.Name = "txtStockPrata"
        Me.txtStockPrata.ReadOnly = True
        Me.txtStockPrata.Size = New System.Drawing.Size(74, 27)
        Me.txtStockPrata.TabIndex = 27
        Me.txtStockPrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStockFerro
        '
        Me.txtStockFerro.Location = New System.Drawing.Point(82, 205)
        Me.txtStockFerro.Name = "txtStockFerro"
        Me.txtStockFerro.ReadOnly = True
        Me.txtStockFerro.Size = New System.Drawing.Size(74, 27)
        Me.txtStockFerro.TabIndex = 26
        Me.txtStockFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStockAreia
        '
        Me.txtStockAreia.Location = New System.Drawing.Point(82, 109)
        Me.txtStockAreia.Name = "txtStockAreia"
        Me.txtStockAreia.ReadOnly = True
        Me.txtStockAreia.Size = New System.Drawing.Size(74, 27)
        Me.txtStockAreia.TabIndex = 25
        Me.txtStockAreia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStockPedra
        '
        Me.txtStockPedra.Location = New System.Drawing.Point(82, 76)
        Me.txtStockPedra.Name = "txtStockPedra"
        Me.txtStockPedra.ReadOnly = True
        Me.txtStockPedra.Size = New System.Drawing.Size(74, 27)
        Me.txtStockPedra.TabIndex = 24
        Me.txtStockPedra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Vidro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cobre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Prata"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Ferro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Areia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Pedra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(155, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Selecionar Menus"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(260, 191)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(94, 29)
        Me.btnConsultar.TabIndex = 37
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(184, 279)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.PlaceholderText = "Ferro"
        Me.txtFerro.Size = New System.Drawing.Size(57, 27)
        Me.txtFerro.TabIndex = 39
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrata
        '
        Me.txtPrata.Location = New System.Drawing.Point(247, 279)
        Me.txtPrata.Name = "txtPrata"
        Me.txtPrata.PlaceholderText = "Prata"
        Me.txtPrata.Size = New System.Drawing.Size(57, 27)
        Me.txtPrata.TabIndex = 40
        Me.txtPrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCobre
        '
        Me.txtCobre.Location = New System.Drawing.Point(310, 279)
        Me.txtCobre.Name = "txtCobre"
        Me.txtCobre.PlaceholderText = "Cobre"
        Me.txtCobre.Size = New System.Drawing.Size(57, 27)
        Me.txtCobre.TabIndex = 41
        Me.txtCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVidro
        '
        Me.txtVidro.Location = New System.Drawing.Point(373, 279)
        Me.txtVidro.Name = "txtVidro"
        Me.txtVidro.PlaceholderText = "Vidro"
        Me.txtVidro.Size = New System.Drawing.Size(57, 27)
        Me.txtVidro.TabIndex = 42
        Me.txtVidro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFatura
        '
        Me.txtFatura.Location = New System.Drawing.Point(260, 316)
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.ReadOnly = True
        Me.txtFatura.Size = New System.Drawing.Size(94, 27)
        Me.txtFatura.TabIndex = 43
        Me.txtFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Location = New System.Drawing.Point(360, 319)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(0, 20)
        Me.lblFatura.TabIndex = 44
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(234, 158)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(151, 27)
        Me.txtCliente.TabIndex = 45
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(277, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Cliente"
        '
        'txtStockMinério
        '
        Me.txtStockMinério.Location = New System.Drawing.Point(82, 142)
        Me.txtStockMinério.Name = "txtStockMinério"
        Me.txtStockMinério.ReadOnly = True
        Me.txtStockMinério.Size = New System.Drawing.Size(74, 27)
        Me.txtStockMinério.TabIndex = 47
        Me.txtStockMinério.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Minério"
        '
        'Gestão_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 411)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStockMinério)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblFatura)
        Me.Controls.Add(Me.txtFatura)
        Me.Controls.Add(Me.txtVidro)
        Me.Controls.Add(Me.txtCobre)
        Me.Controls.Add(Me.txtPrata)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.seletorStockEquipa)
        Me.Controls.Add(Me.seletorMenu)
        Me.Controls.Add(Me.txtStockVidro)
        Me.Controls.Add(Me.txtStockCobre)
        Me.Controls.Add(Me.txtStockPrata)
        Me.Controls.Add(Me.txtStockFerro)
        Me.Controls.Add(Me.txtStockAreia)
        Me.Controls.Add(Me.txtStockPedra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gestão_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetirar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents seletorStockEquipa As ComboBox
    Friend WithEvents seletorMenu As ComboBox
    Friend WithEvents txtStockVidro As TextBox
    Friend WithEvents txtStockCobre As TextBox
    Friend WithEvents txtStockPrata As TextBox
    Friend WithEvents txtStockFerro As TextBox
    Friend WithEvents txtStockAreia As TextBox
    Friend WithEvents txtStockPedra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents txtPrata As TextBox
    Friend WithEvents txtCobre As TextBox
    Friend WithEvents txtVidro As TextBox
    Friend WithEvents txtFatura As TextBox
    Friend WithEvents lblFatura As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStockMinério As TextBox
    Friend WithEvents Label11 As Label
End Class
