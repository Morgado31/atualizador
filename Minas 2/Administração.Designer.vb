<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administração
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administração))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPedra = New System.Windows.Forms.Label()
        Me.lblAreia = New System.Windows.Forms.Label()
        Me.lblCarvão = New System.Windows.Forms.Label()
        Me.lblMinério = New System.Windows.Forms.Label()
        Me.lblNíquel = New System.Windows.Forms.Label()
        Me.lblEnxofre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPedra = New System.Windows.Forms.TextBox()
        Me.txtAreia = New System.Windows.Forms.TextBox()
        Me.txtCarvão = New System.Windows.Forms.TextBox()
        Me.txtMinério = New System.Windows.Forms.TextBox()
        Me.txtNiquel = New System.Windows.Forms.TextBox()
        Me.txtEnxofre = New System.Windows.Forms.TextBox()
        Me.lblFerro = New System.Windows.Forms.Label()
        Me.lblPrata = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCobre = New System.Windows.Forms.TextBox()
        Me.txtPrata = New System.Windows.Forms.TextBox()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.txtVidro = New System.Windows.Forms.TextBox()
        Me.txtParafusos = New System.Windows.Forms.TextBox()
        Me.txtBorracha = New System.Windows.Forms.TextBox()
        Me.txtPolvora = New System.Windows.Forms.TextBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.seletorMaterial = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnGravarLogs = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEquipa = New System.Windows.Forms.TextBox()
        Me.btnGravarEquipa = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(103, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stash Contentor"
        '
        'lblPedra
        '
        Me.lblPedra.AutoSize = True
        Me.lblPedra.Location = New System.Drawing.Point(27, 55)
        Me.lblPedra.Name = "lblPedra"
        Me.lblPedra.Size = New System.Drawing.Size(37, 15)
        Me.lblPedra.TabIndex = 1
        Me.lblPedra.Text = "Pedra"
        Me.lblPedra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAreia
        '
        Me.lblAreia.AutoSize = True
        Me.lblAreia.Location = New System.Drawing.Point(30, 87)
        Me.lblAreia.Name = "lblAreia"
        Me.lblAreia.Size = New System.Drawing.Size(34, 15)
        Me.lblAreia.TabIndex = 2
        Me.lblAreia.Text = "Areia"
        Me.lblAreia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarvão
        '
        Me.lblCarvão.AutoSize = True
        Me.lblCarvão.Location = New System.Drawing.Point(20, 119)
        Me.lblCarvão.Name = "lblCarvão"
        Me.lblCarvão.Size = New System.Drawing.Size(44, 15)
        Me.lblCarvão.TabIndex = 3
        Me.lblCarvão.Text = "Carvão"
        Me.lblCarvão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinério
        '
        Me.lblMinério.AutoSize = True
        Me.lblMinério.Location = New System.Drawing.Point(198, 55)
        Me.lblMinério.Name = "lblMinério"
        Me.lblMinério.Size = New System.Drawing.Size(48, 15)
        Me.lblMinério.TabIndex = 4
        Me.lblMinério.Text = "Minério"
        '
        'lblNíquel
        '
        Me.lblNíquel.AutoSize = True
        Me.lblNíquel.Location = New System.Drawing.Point(204, 87)
        Me.lblNíquel.Name = "lblNíquel"
        Me.lblNíquel.Size = New System.Drawing.Size(42, 15)
        Me.lblNíquel.TabIndex = 5
        Me.lblNíquel.Text = "Níquel"
        '
        'lblEnxofre
        '
        Me.lblEnxofre.AutoSize = True
        Me.lblEnxofre.Location = New System.Drawing.Point(198, 119)
        Me.lblEnxofre.Name = "lblEnxofre"
        Me.lblEnxofre.Size = New System.Drawing.Size(47, 15)
        Me.lblEnxofre.TabIndex = 6
        Me.lblEnxofre.Tag = "Enxofre"
        Me.lblEnxofre.Text = "Enxofre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(111, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Stash Roulote"
        '
        'txtPedra
        '
        Me.txtPedra.Location = New System.Drawing.Point(70, 52)
        Me.txtPedra.Name = "txtPedra"
        Me.txtPedra.ReadOnly = True
        Me.txtPedra.Size = New System.Drawing.Size(76, 23)
        Me.txtPedra.TabIndex = 8
        Me.txtPedra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAreia
        '
        Me.txtAreia.Location = New System.Drawing.Point(70, 84)
        Me.txtAreia.Name = "txtAreia"
        Me.txtAreia.ReadOnly = True
        Me.txtAreia.Size = New System.Drawing.Size(76, 23)
        Me.txtAreia.TabIndex = 9
        Me.txtAreia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCarvão
        '
        Me.txtCarvão.Location = New System.Drawing.Point(70, 116)
        Me.txtCarvão.Name = "txtCarvão"
        Me.txtCarvão.ReadOnly = True
        Me.txtCarvão.Size = New System.Drawing.Size(76, 23)
        Me.txtCarvão.TabIndex = 10
        Me.txtCarvão.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinério
        '
        Me.txtMinério.Location = New System.Drawing.Point(252, 52)
        Me.txtMinério.Name = "txtMinério"
        Me.txtMinério.ReadOnly = True
        Me.txtMinério.Size = New System.Drawing.Size(76, 23)
        Me.txtMinério.TabIndex = 11
        Me.txtMinério.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNiquel
        '
        Me.txtNiquel.Location = New System.Drawing.Point(252, 84)
        Me.txtNiquel.Name = "txtNiquel"
        Me.txtNiquel.ReadOnly = True
        Me.txtNiquel.Size = New System.Drawing.Size(76, 23)
        Me.txtNiquel.TabIndex = 12
        Me.txtNiquel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnxofre
        '
        Me.txtEnxofre.Location = New System.Drawing.Point(252, 116)
        Me.txtEnxofre.Name = "txtEnxofre"
        Me.txtEnxofre.ReadOnly = True
        Me.txtEnxofre.Size = New System.Drawing.Size(76, 23)
        Me.txtEnxofre.TabIndex = 13
        Me.txtEnxofre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFerro
        '
        Me.lblFerro.AutoSize = True
        Me.lblFerro.Location = New System.Drawing.Point(30, 215)
        Me.lblFerro.Name = "lblFerro"
        Me.lblFerro.Size = New System.Drawing.Size(34, 15)
        Me.lblFerro.TabIndex = 14
        Me.lblFerro.Text = "Ferro"
        '
        'lblPrata
        '
        Me.lblPrata.AutoSize = True
        Me.lblPrata.Location = New System.Drawing.Point(30, 250)
        Me.lblPrata.Name = "lblPrata"
        Me.lblPrata.Size = New System.Drawing.Size(34, 15)
        Me.lblPrata.TabIndex = 15
        Me.lblPrata.Text = "Prata"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cobre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Vidro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Polvora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Borracha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Parafusos"
        '
        'txtCobre
        '
        Me.txtCobre.Location = New System.Drawing.Point(70, 276)
        Me.txtCobre.Name = "txtCobre"
        Me.txtCobre.ReadOnly = True
        Me.txtCobre.Size = New System.Drawing.Size(76, 23)
        Me.txtCobre.TabIndex = 23
        Me.txtCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrata
        '
        Me.txtPrata.Location = New System.Drawing.Point(70, 244)
        Me.txtPrata.Name = "txtPrata"
        Me.txtPrata.ReadOnly = True
        Me.txtPrata.Size = New System.Drawing.Size(76, 23)
        Me.txtPrata.TabIndex = 22
        Me.txtPrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(70, 212)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.ReadOnly = True
        Me.txtFerro.Size = New System.Drawing.Size(76, 23)
        Me.txtFerro.TabIndex = 21
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVidro
        '
        Me.txtVidro.Location = New System.Drawing.Point(70, 309)
        Me.txtVidro.Name = "txtVidro"
        Me.txtVidro.ReadOnly = True
        Me.txtVidro.Size = New System.Drawing.Size(76, 23)
        Me.txtVidro.TabIndex = 24
        Me.txtVidro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParafusos
        '
        Me.txtParafusos.Location = New System.Drawing.Point(252, 276)
        Me.txtParafusos.Name = "txtParafusos"
        Me.txtParafusos.ReadOnly = True
        Me.txtParafusos.Size = New System.Drawing.Size(76, 23)
        Me.txtParafusos.TabIndex = 27
        Me.txtParafusos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBorracha
        '
        Me.txtBorracha.Location = New System.Drawing.Point(252, 244)
        Me.txtBorracha.Name = "txtBorracha"
        Me.txtBorracha.ReadOnly = True
        Me.txtBorracha.Size = New System.Drawing.Size(76, 23)
        Me.txtBorracha.TabIndex = 26
        Me.txtBorracha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPolvora
        '
        Me.txtPolvora.Location = New System.Drawing.Point(252, 212)
        Me.txtPolvora.Name = "txtPolvora"
        Me.txtPolvora.ReadOnly = True
        Me.txtPolvora.Size = New System.Drawing.Size(76, 23)
        Me.txtPolvora.TabIndex = 25
        Me.txtPolvora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(125, 355)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(76, 23)
        Me.btnAtualizar.TabIndex = 28
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'seletorMaterial
        '
        Me.seletorMaterial.FormattingEnabled = True
        Me.seletorMaterial.Items.AddRange(New Object() {"Pedra", "Areia", "Carvão ", "Minério", "Níquel", "Enxofre", "Ferro", "Prata", "Cobre", "Vidro", "Polvora", "Borracha", "Parafusos"})
        Me.seletorMaterial.Location = New System.Drawing.Point(412, 212)
        Me.seletorMaterial.Name = "seletorMaterial"
        Me.seletorMaterial.Size = New System.Drawing.Size(119, 23)
        Me.seletorMaterial.TabIndex = 29
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(546, 212)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.PlaceholderText = "Quantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(76, 23)
        Me.txtQuantidade.TabIndex = 30
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGravarLogs
        '
        Me.btnGravarLogs.Location = New System.Drawing.Point(480, 250)
        Me.btnGravarLogs.Name = "btnGravarLogs"
        Me.btnGravarLogs.Size = New System.Drawing.Size(76, 23)
        Me.btnGravarLogs.TabIndex = 31
        Me.btnGravarLogs.Text = "Gravar"
        Me.btnGravarLogs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(455, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Adicionar Equipa"
        '
        'txtEquipa
        '
        Me.txtEquipa.Location = New System.Drawing.Point(422, 55)
        Me.txtEquipa.Name = "txtEquipa"
        Me.txtEquipa.PlaceholderText = "Introduzir Equipa"
        Me.txtEquipa.Size = New System.Drawing.Size(192, 23)
        Me.txtEquipa.TabIndex = 33
        Me.txtEquipa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGravarEquipa
        '
        Me.btnGravarEquipa.Location = New System.Drawing.Point(481, 84)
        Me.btnGravarEquipa.Name = "btnGravarEquipa"
        Me.btnGravarEquipa.Size = New System.Drawing.Size(75, 23)
        Me.btnGravarEquipa.TabIndex = 34
        Me.btnGravarEquipa.Text = "Adicionar"
        Me.btnGravarEquipa.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(415, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Retirar e Adicionar Materiais"
        '
        'Administração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 398)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGravarEquipa)
        Me.Controls.Add(Me.txtEquipa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGravarLogs)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.seletorMaterial)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.txtParafusos)
        Me.Controls.Add(Me.txtBorracha)
        Me.Controls.Add(Me.txtPolvora)
        Me.Controls.Add(Me.txtVidro)
        Me.Controls.Add(Me.txtCobre)
        Me.Controls.Add(Me.txtPrata)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrata)
        Me.Controls.Add(Me.lblFerro)
        Me.Controls.Add(Me.txtEnxofre)
        Me.Controls.Add(Me.txtNiquel)
        Me.Controls.Add(Me.txtMinério)
        Me.Controls.Add(Me.txtCarvão)
        Me.Controls.Add(Me.txtAreia)
        Me.Controls.Add(Me.txtPedra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEnxofre)
        Me.Controls.Add(Me.lblNíquel)
        Me.Controls.Add(Me.lblMinério)
        Me.Controls.Add(Me.lblCarvão)
        Me.Controls.Add(Me.lblAreia)
        Me.Controls.Add(Me.lblPedra)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Administração"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas 2 - Administração"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPedra As Label
    Friend WithEvents lblAreia As Label
    Friend WithEvents lblCarvão As Label
    Friend WithEvents lblMinério As Label
    Friend WithEvents lblNíquel As Label
    Friend WithEvents lblEnxofre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPedra As TextBox
    Friend WithEvents txtAreia As TextBox
    Friend WithEvents txtCarvão As TextBox
    Friend WithEvents txtMinério As TextBox
    Friend WithEvents txtNiquel As TextBox
    Friend WithEvents txtEnxofre As TextBox
    Friend WithEvents lblFerro As Label
    Friend WithEvents lblPrata As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCobre As TextBox
    Friend WithEvents txtPrata As TextBox
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents txtVidro As TextBox
    Friend WithEvents txtParafusos As TextBox
    Friend WithEvents txtBorracha As TextBox
    Friend WithEvents txtPolvora As TextBox
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents seletorMaterial As ComboBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents btnGravarLogs As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEquipa As TextBox
    Friend WithEvents btnGravarEquipa As Button
    Friend WithEvents Label9 As Label
End Class
