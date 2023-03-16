<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processo_Pedra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processo_Pedra))
        Me.txtPedra = New System.Windows.Forms.TextBox()
        Me.txtAreia = New System.Windows.Forms.TextBox()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.txtPrata = New System.Windows.Forms.TextBox()
        Me.txtCobre = New System.Windows.Forms.TextBox()
        Me.txtVidro = New System.Windows.Forms.TextBox()
        Me.seletorMenu = New System.Windows.Forms.ComboBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPedra
        '
        Me.txtPedra.Location = New System.Drawing.Point(105, 65)
        Me.txtPedra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPedra.Name = "txtPedra"
        Me.txtPedra.PlaceholderText = "Pedra"
        Me.txtPedra.Size = New System.Drawing.Size(69, 23)
        Me.txtPedra.TabIndex = 0
        Me.txtPedra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAreia
        '
        Me.txtAreia.Location = New System.Drawing.Point(189, 65)
        Me.txtAreia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAreia.Name = "txtAreia"
        Me.txtAreia.PlaceholderText = "Areia"
        Me.txtAreia.Size = New System.Drawing.Size(69, 23)
        Me.txtAreia.TabIndex = 1
        Me.txtAreia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(21, 100)
        Me.txtFerro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.PlaceholderText = "Ferro"
        Me.txtFerro.Size = New System.Drawing.Size(69, 23)
        Me.txtFerro.TabIndex = 2
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrata
        '
        Me.txtPrata.Location = New System.Drawing.Point(105, 100)
        Me.txtPrata.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrata.Name = "txtPrata"
        Me.txtPrata.PlaceholderText = "Prata"
        Me.txtPrata.Size = New System.Drawing.Size(69, 23)
        Me.txtPrata.TabIndex = 3
        Me.txtPrata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCobre
        '
        Me.txtCobre.Location = New System.Drawing.Point(189, 100)
        Me.txtCobre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCobre.Name = "txtCobre"
        Me.txtCobre.PlaceholderText = "Cobre"
        Me.txtCobre.Size = New System.Drawing.Size(69, 23)
        Me.txtCobre.TabIndex = 4
        Me.txtCobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVidro
        '
        Me.txtVidro.Location = New System.Drawing.Point(273, 100)
        Me.txtVidro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVidro.Name = "txtVidro"
        Me.txtVidro.PlaceholderText = "Vidro"
        Me.txtVidro.Size = New System.Drawing.Size(69, 23)
        Me.txtVidro.TabIndex = 5
        Me.txtVidro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'seletorMenu
        '
        Me.seletorMenu.FormattingEnabled = True
        Me.seletorMenu.Location = New System.Drawing.Point(54, 29)
        Me.seletorMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.seletorMenu.Name = "seletorMenu"
        Me.seletorMenu.Size = New System.Drawing.Size(257, 23)
        Me.seletorMenu.TabIndex = 6
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(148, 134)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(68, 22)
        Me.btnGravar.TabIndex = 7
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Selecionar Menu"
        '
        'Processo_Pedra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 173)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.seletorMenu)
        Me.Controls.Add(Me.txtVidro)
        Me.Controls.Add(Me.txtCobre)
        Me.Controls.Add(Me.txtPrata)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.txtAreia)
        Me.Controls.Add(Me.txtPedra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Processo_Pedra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas 2 - Processo de Pedra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPedra As TextBox
    Friend WithEvents txtAreia As TextBox
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents txtPrata As TextBox
    Friend WithEvents txtCobre As TextBox
    Friend WithEvents txtVidro As TextBox
    Friend WithEvents seletorMenu As ComboBox
    Friend WithEvents btnGravar As Button
    Friend WithEvents Label9 As Label
End Class
