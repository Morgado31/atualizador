<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administração
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEquipa = New System.Windows.Forms.TextBox()
        Me.btnGravarEquipa = New System.Windows.Forms.Button()
        Me.txtSafiras = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.selectorTrabalhador = New System.Windows.Forms.ComboBox()
        Me.txtPagamento = New System.Windows.Forms.TextBox()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(122, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stash Contentor"
        '
        'lblPedra
        '
        Me.lblPedra.AutoSize = True
        Me.lblPedra.Location = New System.Drawing.Point(27, 55)
        Me.lblPedra.Name = "lblPedra"
        Me.lblPedra.Size = New System.Drawing.Size(46, 20)
        Me.lblPedra.TabIndex = 1
        Me.lblPedra.Text = "Pedra"
        Me.lblPedra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAreia
        '
        Me.lblAreia.AutoSize = True
        Me.lblAreia.Location = New System.Drawing.Point(30, 87)
        Me.lblAreia.Name = "lblAreia"
        Me.lblAreia.Size = New System.Drawing.Size(44, 20)
        Me.lblAreia.TabIndex = 2
        Me.lblAreia.Text = "Areia"
        Me.lblAreia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarvão
        '
        Me.lblCarvão.AutoSize = True
        Me.lblCarvão.Location = New System.Drawing.Point(20, 119)
        Me.lblCarvão.Name = "lblCarvão"
        Me.lblCarvão.Size = New System.Drawing.Size(55, 20)
        Me.lblCarvão.TabIndex = 3
        Me.lblCarvão.Text = "Carvão"
        Me.lblCarvão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinério
        '
        Me.lblMinério.AutoSize = True
        Me.lblMinério.Location = New System.Drawing.Point(198, 55)
        Me.lblMinério.Name = "lblMinério"
        Me.lblMinério.Size = New System.Drawing.Size(60, 20)
        Me.lblMinério.TabIndex = 4
        Me.lblMinério.Text = "Minério"
        '
        'lblNíquel
        '
        Me.lblNíquel.AutoSize = True
        Me.lblNíquel.Location = New System.Drawing.Point(204, 87)
        Me.lblNíquel.Name = "lblNíquel"
        Me.lblNíquel.Size = New System.Drawing.Size(53, 20)
        Me.lblNíquel.TabIndex = 5
        Me.lblNíquel.Text = "Níquel"
        '
        'lblEnxofre
        '
        Me.lblEnxofre.AutoSize = True
        Me.lblEnxofre.Location = New System.Drawing.Point(198, 119)
        Me.lblEnxofre.Name = "lblEnxofre"
        Me.lblEnxofre.Size = New System.Drawing.Size(59, 20)
        Me.lblEnxofre.TabIndex = 6
        Me.lblEnxofre.Tag = "Enxofre"
        Me.lblEnxofre.Text = "Enxofre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(565, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Stash Roulote"
        '
        'txtPedra
        '
        Me.txtPedra.Location = New System.Drawing.Point(82, 52)
        Me.txtPedra.Name = "txtPedra"
        Me.txtPedra.ReadOnly = True
        Me.txtPedra.Size = New System.Drawing.Size(76, 27)
        Me.txtPedra.TabIndex = 8
        Me.txtPedra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAreia
        '
        Me.txtAreia.Location = New System.Drawing.Point(82, 84)
        Me.txtAreia.Name = "txtAreia"
        Me.txtAreia.ReadOnly = True
        Me.txtAreia.Size = New System.Drawing.Size(76, 27)
        Me.txtAreia.TabIndex = 9
        Me.txtAreia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCarvão
        '
        Me.txtCarvão.Location = New System.Drawing.Point(82, 116)
        Me.txtCarvão.Name = "txtCarvão"
        Me.txtCarvão.ReadOnly = True
        Me.txtCarvão.Size = New System.Drawing.Size(76, 27)
        Me.txtCarvão.TabIndex = 10
        Me.txtCarvão.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinério
        '
        Me.txtMinério.Location = New System.Drawing.Point(264, 52)
        Me.txtMinério.Name = "txtMinério"
        Me.txtMinério.ReadOnly = True
        Me.txtMinério.Size = New System.Drawing.Size(76, 27)
        Me.txtMinério.TabIndex = 11
        Me.txtMinério.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNiquel
        '
        Me.txtNiquel.Location = New System.Drawing.Point(264, 84)
        Me.txtNiquel.Name = "txtNiquel"
        Me.txtNiquel.ReadOnly = True
        Me.txtNiquel.Size = New System.Drawing.Size(76, 27)
        Me.txtNiquel.TabIndex = 12
        Me.txtNiquel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnxofre
        '
        Me.txtEnxofre.Location = New System.Drawing.Point(264, 116)
        Me.txtEnxofre.Name = "txtEnxofre"
        Me.txtEnxofre.ReadOnly = True
        Me.txtEnxofre.Size = New System.Drawing.Size(76, 27)
        Me.txtEnxofre.TabIndex = 13
        Me.txtEnxofre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFerro
        '
        Me.lblFerro.AutoSize = True
        Me.lblFerro.Location = New System.Drawing.Point(466, 55)
        Me.lblFerro.Name = "lblFerro"
        Me.lblFerro.Size = New System.Drawing.Size(43, 20)
        Me.lblFerro.TabIndex = 14
        Me.lblFerro.Text = "Ferro"
        '
        'lblPrata
        '
        Me.lblPrata.AutoSize = True
        Me.lblPrata.Location = New System.Drawing.Point(466, 90)
        Me.lblPrata.Name = "lblPrata"
        Me.lblPrata.Size = New System.Drawing.Size(43, 20)
        Me.lblPrata.TabIndex = 15
        Me.lblPrata.Text = "Prata"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cobre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Vidro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Polvora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(628, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Borracha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Parafusos"
        '
        'txtCobre
        '
        Me.txtCobre.Location = New System.Drawing.Point(517, 116)
        Me.txtCobre.Name = "txtCobre"
        Me.txtCobre.ReadOnly = True
        Me.txtCobre.Size = New System.Drawing.Size(76, 27)
        Me.txtCobre.TabIndex = 23
        Me.txtCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrata
        '
        Me.txtPrata.Location = New System.Drawing.Point(517, 84)
        Me.txtPrata.Name = "txtPrata"
        Me.txtPrata.ReadOnly = True
        Me.txtPrata.Size = New System.Drawing.Size(76, 27)
        Me.txtPrata.TabIndex = 22
        Me.txtPrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(517, 52)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.ReadOnly = True
        Me.txtFerro.Size = New System.Drawing.Size(76, 27)
        Me.txtFerro.TabIndex = 21
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVidro
        '
        Me.txtVidro.Location = New System.Drawing.Point(517, 149)
        Me.txtVidro.Name = "txtVidro"
        Me.txtVidro.ReadOnly = True
        Me.txtVidro.Size = New System.Drawing.Size(76, 27)
        Me.txtVidro.TabIndex = 24
        Me.txtVidro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParafusos
        '
        Me.txtParafusos.Location = New System.Drawing.Point(699, 116)
        Me.txtParafusos.Name = "txtParafusos"
        Me.txtParafusos.ReadOnly = True
        Me.txtParafusos.Size = New System.Drawing.Size(76, 27)
        Me.txtParafusos.TabIndex = 27
        Me.txtParafusos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBorracha
        '
        Me.txtBorracha.Location = New System.Drawing.Point(699, 84)
        Me.txtBorracha.Name = "txtBorracha"
        Me.txtBorracha.ReadOnly = True
        Me.txtBorracha.Size = New System.Drawing.Size(76, 27)
        Me.txtBorracha.TabIndex = 26
        Me.txtBorracha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPolvora
        '
        Me.txtPolvora.Location = New System.Drawing.Point(699, 52)
        Me.txtPolvora.Name = "txtPolvora"
        Me.txtPolvora.ReadOnly = True
        Me.txtPolvora.Size = New System.Drawing.Size(76, 27)
        Me.txtPolvora.TabIndex = 25
        Me.txtPolvora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(360, 85)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(83, 25)
        Me.btnAtualizar.TabIndex = 28
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(36, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 28)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Adicionar Equipa"
        '
        'txtEquipa
        '
        Me.txtEquipa.Location = New System.Drawing.Point(20, 238)
        Me.txtEquipa.Name = "txtEquipa"
        Me.txtEquipa.PlaceholderText = "Introduzir Equipa"
        Me.txtEquipa.Size = New System.Drawing.Size(192, 27)
        Me.txtEquipa.TabIndex = 33
        Me.txtEquipa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGravarEquipa
        '
        Me.btnGravarEquipa.Location = New System.Drawing.Point(72, 271)
        Me.btnGravarEquipa.Name = "btnGravarEquipa"
        Me.btnGravarEquipa.Size = New System.Drawing.Size(89, 28)
        Me.btnGravarEquipa.TabIndex = 34
        Me.btnGravarEquipa.Text = "Adicionar"
        Me.btnGravarEquipa.UseVisualStyleBackColor = True
        '
        'txtSafiras
        '
        Me.txtSafiras.Enabled = False
        Me.txtSafiras.Location = New System.Drawing.Point(82, 149)
        Me.txtSafiras.Name = "txtSafiras"
        Me.txtSafiras.ReadOnly = True
        Me.txtSafiras.Size = New System.Drawing.Size(76, 27)
        Me.txtSafiras.TabIndex = 0
        Me.txtSafiras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Safiras"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(299, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 28)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Consultar Pagamentos"
        '
        'selectorTrabalhador
        '
        Me.selectorTrabalhador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectorTrabalhador.FormattingEnabled = True
        Me.selectorTrabalhador.Location = New System.Drawing.Point(265, 237)
        Me.selectorTrabalhador.Name = "selectorTrabalhador"
        Me.selectorTrabalhador.Size = New System.Drawing.Size(136, 28)
        Me.selectorTrabalhador.TabIndex = 37
        '
        'txtPagamento
        '
        Me.txtPagamento.Enabled = False
        Me.txtPagamento.Location = New System.Drawing.Point(407, 238)
        Me.txtPagamento.Name = "txtPagamento"
        Me.txtPagamento.Size = New System.Drawing.Size(125, 27)
        Me.txtPagamento.TabIndex = 38
        Me.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPago
        '
        Me.btnPago.Location = New System.Drawing.Point(352, 271)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(94, 29)
        Me.btnPago.TabIndex = 39
        Me.btnPago.Text = "Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(553, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 28)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Quantidade de Drills Usadas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(584, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(191, 28)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "DESENVOLVIMENTO"
        '
        'Administração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 317)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.txtPagamento)
        Me.Controls.Add(Me.selectorTrabalhador)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSafiras)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGravarEquipa)
        Me.Controls.Add(Me.txtEquipa)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEquipa As TextBox
    Friend WithEvents btnGravarEquipa As Button
    Friend WithEvents txtSafiras As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents selectorTrabalhador As ComboBox
    Friend WithEvents txtPagamento As TextBox
    Friend WithEvents btnPago As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
End Class
