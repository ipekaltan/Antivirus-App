<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAccount
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlAccount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgAccount = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblexpiry = New System.Windows.Forms.Label()
        Me.lblvalidation = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyButton2 = New Ipo_Protector.MyButton()
        Me.MyButton1 = New Ipo_Protector.MyButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblActivationKey = New System.Windows.Forms.Label()
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(37, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 5)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 53)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "User Account"
        '
        'imgAccount
        '
        Me.imgAccount.Image = CType(resources.GetObject("imgAccount.Image"), System.Drawing.Image)
        Me.imgAccount.Location = New System.Drawing.Point(341, 96)
        Me.imgAccount.Name = "imgAccount"
        Me.imgAccount.Size = New System.Drawing.Size(148, 182)
        Me.imgAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAccount.TabIndex = 32
        Me.imgAccount.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblActivationKey)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblexpiry)
        Me.GroupBox1.Controls.Add(Me.lblvalidation)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(37, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 185)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'lblexpiry
        '
        Me.lblexpiry.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.lblexpiry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblexpiry.Location = New System.Drawing.Point(226, 103)
        Me.lblexpiry.Name = "lblexpiry"
        Me.lblexpiry.Size = New System.Drawing.Size(449, 27)
        Me.lblexpiry.TabIndex = 36
        Me.lblexpiry.Text = "-"
        '
        'lblvalidation
        '
        Me.lblvalidation.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.lblvalidation.ForeColor = System.Drawing.SystemColors.Control
        Me.lblvalidation.Location = New System.Drawing.Point(226, 67)
        Me.lblvalidation.Name = "lblvalidation"
        Me.lblvalidation.Size = New System.Drawing.Size(449, 27)
        Me.lblvalidation.TabIndex = 35
        Me.lblvalidation.Text = "-"
        '
        'lblemail
        '
        Me.lblemail.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.lblemail.ForeColor = System.Drawing.SystemColors.Control
        Me.lblemail.Location = New System.Drawing.Point(226, 28)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(449, 27)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(135, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Expiry:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(98, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 27)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Validation:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 27)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Activation E-mail:"
        '
        'MyButton2
        '
        Me.MyButton2.BottomColor = System.Drawing.Color.Crimson
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.Menu
        Me.MyButton2.Location = New System.Drawing.Point(487, 284)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(150, 50)
        Me.MyButton2.TabIndex = 35
        Me.MyButton2.Text = "Create Acoount"
        Me.MyButton2.TopColor = System.Drawing.Color.OrangeRed
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.BottomColor = System.Drawing.SystemColors.HotTrack
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.Menu
        Me.MyButton1.Location = New System.Drawing.Point(191, 284)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(150, 50)
        Me.MyButton1.TabIndex = 34
        Me.MyButton1.Text = "Login"
        Me.MyButton1.TopColor = System.Drawing.Color.DodgerBlue
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(58, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 27)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Activation Key:"
        '
        'lblActivationKey
        '
        Me.lblActivationKey.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.lblActivationKey.ForeColor = System.Drawing.SystemColors.Control
        Me.lblActivationKey.Location = New System.Drawing.Point(226, 142)
        Me.lblActivationKey.Name = "lblActivationKey"
        Me.lblActivationKey.Size = New System.Drawing.Size(449, 27)
        Me.lblActivationKey.TabIndex = 38
        Me.lblActivationKey.Text = "-"
        '
        'ctlAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imgAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ctlAccount"
        Me.Size = New System.Drawing.Size(792, 555)
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents imgAccount As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblemail As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblexpiry As Label
    Friend WithEvents lblvalidation As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents lblActivationKey As Label
    Friend WithEvents Label5 As Label
End Class
