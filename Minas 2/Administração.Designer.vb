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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Items Nas Stash's"
        '
        'lblPedra
        '
        Me.lblPedra.AutoSize = True
        Me.lblPedra.Location = New System.Drawing.Point(22, 53)
        Me.lblPedra.Name = "lblPedra"
        Me.lblPedra.Size = New System.Drawing.Size(37, 15)
        Me.lblPedra.TabIndex = 1
        Me.lblPedra.Text = "Pedra"
        '
        'lblAreia
        '
        Me.lblAreia.AutoSize = True
        Me.lblAreia.Location = New System.Drawing.Point(22, 81)
        Me.lblAreia.Name = "lblAreia"
        Me.lblAreia.Size = New System.Drawing.Size(34, 15)
        Me.lblAreia.TabIndex = 2
        Me.lblAreia.Text = "Areia"
        '
        'Administração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAreia)
        Me.Controls.Add(Me.lblPedra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Administração"
        Me.Text = "Minas 2 - Administração"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPedra As Label
    Friend WithEvents lblAreia As Label
End Class
