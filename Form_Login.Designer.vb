<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Line2 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Line1 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblAvisoLogin = New System.Windows.Forms.Label()
        Me.picPassword = New System.Windows.Forms.PictureBox()
        Me.picUsername = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogin.Location = New System.Drawing.Point(262, 254)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(167, 32)
        Me.btnLogin.TabIndex = 27
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Black
        Me.Line2.Location = New System.Drawing.Point(262, 207)
        Me.Line2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(166, 1)
        Me.Line2.TabIndex = 26
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(263, 192)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.Size = New System.Drawing.Size(167, 16)
        Me.txtPassword.TabIndex = 25
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Black
        Me.Line1.Location = New System.Drawing.Point(262, 145)
        Me.Line1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(166, 1)
        Me.Line1.TabIndex = 24
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Control
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(262, 131)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.Size = New System.Drawing.Size(167, 16)
        Me.txtUsername.TabIndex = 23
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvisoLogin
        '
        Me.lblAvisoLogin.AutoSize = True
        Me.lblAvisoLogin.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblAvisoLogin.ForeColor = System.Drawing.Color.Black
        Me.lblAvisoLogin.Location = New System.Drawing.Point(238, 85)
        Me.lblAvisoLogin.Name = "lblAvisoLogin"
        Me.lblAvisoLogin.Size = New System.Drawing.Size(215, 15)
        Me.lblAvisoLogin.TabIndex = 22
        Me.lblAvisoLogin.Text = "Tem atenção aos registos, obrigado!"
        '
        'picPassword
        '
        Me.picPassword.Image = CType(resources.GetObject("picPassword.Image"), System.Drawing.Image)
        Me.picPassword.Location = New System.Drawing.Point(212, 185)
        Me.picPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picPassword.Name = "picPassword"
        Me.picPassword.Size = New System.Drawing.Size(45, 31)
        Me.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPassword.TabIndex = 21
        Me.picPassword.TabStop = False
        '
        'picUsername
        '
        Me.picUsername.Image = CType(resources.GetObject("picUsername.Image"), System.Drawing.Image)
        Me.picUsername.Location = New System.Drawing.Point(212, 124)
        Me.picUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picUsername.Name = "picUsername"
        Me.picUsername.Size = New System.Drawing.Size(45, 31)
        Me.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUsername.TabIndex = 20
        Me.picUsername.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(253, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Bem-vindo!"
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 361)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblAvisoLogin)
        Me.Controls.Add(Me.picPassword)
        Me.Controls.Add(Me.picUsername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Login"
        Me.Text = "Form_Login"
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsername, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Line2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Line1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblAvisoLogin As Label
    Friend WithEvents picPassword As PictureBox
    Friend WithEvents picUsername As PictureBox
    Friend WithEvents Label1 As Label
End Class
