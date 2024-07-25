<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MELogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MELogin))
        btnLogin = New Button()
        txtboxUser = New TextBox()
        txtboxPass = New TextBox()
        Logo = New PictureBox()
        txtboxCopyright = New TextBox()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ControlLight
        btnLogin.Location = New Point(316, 905)
        btnLogin.Margin = New Padding(6)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(249, 73)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtboxUser
        ' 
        txtboxUser.Location = New Point(212, 781)
        txtboxUser.Margin = New Padding(6)
        txtboxUser.Name = "txtboxUser"
        txtboxUser.PlaceholderText = "Username"
        txtboxUser.Size = New Size(461, 39)
        txtboxUser.TabIndex = 1
        txtboxUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtboxPass
        ' 
        txtboxPass.Location = New Point(212, 843)
        txtboxPass.Margin = New Padding(6)
        txtboxPass.Name = "txtboxPass"
        txtboxPass.PasswordChar = "*"c
        txtboxPass.PlaceholderText = "Password"
        txtboxPass.Size = New Size(461, 39)
        txtboxPass.TabIndex = 2
        txtboxPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Logo
        ' 
        Logo.Anchor = AnchorStyles.None
        Logo.BackgroundImageLayout = ImageLayout.None
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(2, -32)
        Logo.Margin = New Padding(6)
        Logo.Name = "Logo"
        Logo.Size = New Size(895, 766)
        Logo.SizeMode = PictureBoxSizeMode.Zoom
        Logo.TabIndex = 3
        Logo.TabStop = False
        ' 
        ' txtboxCopyright
        ' 
        txtboxCopyright.BackColor = SystemColors.ControlLightLight
        txtboxCopyright.BorderStyle = BorderStyle.None
        txtboxCopyright.Font = New Font("Segoe UI", 5F)
        txtboxCopyright.ForeColor = SystemColors.WindowFrame
        txtboxCopyright.Location = New Point(2, 990)
        txtboxCopyright.Margin = New Padding(6)
        txtboxCopyright.Name = "txtboxCopyright"
        txtboxCopyright.ReadOnly = True
        txtboxCopyright.Size = New Size(895, 18)
        txtboxCopyright.TabIndex = 4
        txtboxCopyright.TabStop = False
        txtboxCopyright.Text = vbLf & "© Monolithic Expeditionary™. All rights reserved."
        txtboxCopyright.TextAlign = HorizontalAlignment.Center
        ' 
        ' MELogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(899, 1023)
        Controls.Add(txtboxCopyright)
        Controls.Add(Logo)
        Controls.Add(txtboxPass)
        Controls.Add(txtboxUser)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MELogin"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtboxUser As TextBox
    Friend WithEvents txtboxPass As TextBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents txtboxCopyright As TextBox

End Class
