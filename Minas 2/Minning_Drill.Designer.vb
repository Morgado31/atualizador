<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minning_Drill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minning_Drill))
        Me.checkEquipa = New System.Windows.Forms.CheckBox()
        Me.checkUsada = New System.Windows.Forms.CheckBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.checkComprar = New System.Windows.Forms.CheckBox()
        Me.txtQuantidadeUsada = New System.Windows.Forms.TextBox()
        Me.txtComprar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'checkEquipa
        '
        Me.checkEquipa.AutoSize = True
        Me.checkEquipa.Location = New System.Drawing.Point(30, 57)
        Me.checkEquipa.Name = "checkEquipa"
        Me.checkEquipa.Size = New System.Drawing.Size(91, 19)
        Me.checkEquipa.TabIndex = 2
        Me.checkEquipa.Text = "Com Equipa"
        Me.checkEquipa.UseVisualStyleBackColor = True
        '
        'checkUsada
        '
        Me.checkUsada.AutoSize = True
        Me.checkUsada.Location = New System.Drawing.Point(30, 86)
        Me.checkUsada.Name = "checkUsada"
        Me.checkUsada.Size = New System.Drawing.Size(159, 19)
        Me.checkUsada.TabIndex = 3
        Me.checkUsada.Text = "Com Minning Drill Usada"
        Me.checkUsada.UseVisualStyleBackColor = True
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Location = New System.Drawing.Point(64, 144)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(46, 15)
        Me.lblFatura.TabIndex = 4
        Me.lblFatura.Text = "Fatura :"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(30, 169)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(75, 23)
        Me.btnVender.TabIndex = 6
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(30, 27)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(0, 15)
        Me.lblQuantidade.TabIndex = 7
        Me.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(111, 169)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 8
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'checkComprar
        '
        Me.checkComprar.AutoSize = True
        Me.checkComprar.Location = New System.Drawing.Point(30, 115)
        Me.checkComprar.Name = "checkComprar"
        Me.checkComprar.Size = New System.Drawing.Size(145, 19)
        Me.checkComprar.TabIndex = 9
        Me.checkComprar.Text = "Comprar Drill's Usadas"
        Me.checkComprar.UseVisualStyleBackColor = True
        '
        'txtQuantidadeUsada
        '
        Me.txtQuantidadeUsada.Location = New System.Drawing.Point(195, 84)
        Me.txtQuantidadeUsada.Name = "txtQuantidadeUsada"
        Me.txtQuantidadeUsada.PlaceholderText = "Quantidade"
        Me.txtQuantidadeUsada.Size = New System.Drawing.Size(81, 23)
        Me.txtQuantidadeUsada.TabIndex = 10
        Me.txtQuantidadeUsada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComprar
        '
        Me.txtComprar.Location = New System.Drawing.Point(195, 115)
        Me.txtComprar.Name = "txtComprar"
        Me.txtComprar.PlaceholderText = "Quantidade"
        Me.txtComprar.Size = New System.Drawing.Size(81, 23)
        Me.txtComprar.TabIndex = 11
        Me.txtComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Minning_Drill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 214)
        Me.Controls.Add(Me.txtComprar)
        Me.Controls.Add(Me.txtQuantidadeUsada)
        Me.Controls.Add(Me.checkComprar)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.lblFatura)
        Me.Controls.Add(Me.checkUsada)
        Me.Controls.Add(Me.checkEquipa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Minning_Drill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkEquipa As CheckBox
    Friend WithEvents checkUsada As CheckBox
    Friend WithEvents lblFatura As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents checkComprar As CheckBox
    Friend WithEvents txtQuantidadeUsada As TextBox
    Friend WithEvents txtComprar As TextBox
End Class
