<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processo_Polvora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processo_Polvora))
        Me.SeletorMenu = New System.Windows.Forms.ComboBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.seletorEquipas = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtEntregar = New System.Windows.Forms.TextBox()
        Me.btnCraft = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SeletorMenu
        '
        Me.SeletorMenu.FormattingEnabled = True
        Me.SeletorMenu.Location = New System.Drawing.Point(109, 44)
        Me.SeletorMenu.Name = "SeletorMenu"
        Me.SeletorMenu.Size = New System.Drawing.Size(297, 28)
        Me.SeletorMenu.TabIndex = 0
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(28, 94)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.PlaceholderText = "Quantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(160, 27)
        Me.txtQuantidade.TabIndex = 1
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'seletorEquipas
        '
        Me.seletorEquipas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.seletorEquipas.FormattingEnabled = True
        Me.seletorEquipas.Location = New System.Drawing.Point(28, 160)
        Me.seletorEquipas.Name = "seletorEquipas"
        Me.seletorEquipas.Size = New System.Drawing.Size(160, 28)
        Me.seletorEquipas.TabIndex = 2
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(28, 127)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PlaceholderText = "Cliente"
        Me.txtCliente.Size = New System.Drawing.Size(160, 27)
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEntregar
        '
        Me.txtEntregar.Location = New System.Drawing.Point(327, 127)
        Me.txtEntregar.Name = "txtEntregar"
        Me.txtEntregar.ReadOnly = True
        Me.txtEntregar.Size = New System.Drawing.Size(159, 27)
        Me.txtEntregar.TabIndex = 4
        Me.txtEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCraft
        '
        Me.btnCraft.Location = New System.Drawing.Point(210, 109)
        Me.btnCraft.Name = "btnCraft"
        Me.btnCraft.Size = New System.Drawing.Size(94, 26)
        Me.btnCraft.TabIndex = 5
        Me.btnCraft.Text = "Craft"
        Me.btnCraft.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(210, 141)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 26)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantidade a Entregar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Selecionar Menu"
        '
        'Processo_Polvora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 203)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCraft)
        Me.Controls.Add(Me.txtEntregar)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.seletorEquipas)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.SeletorMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Processo_Polvora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minas2 - Processo de Polvora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SeletorMenu As ComboBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents seletorEquipas As ComboBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtEntregar As TextBox
    Friend WithEvents btnCraft As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
