<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.btnNotifications = New Ipo_Protector.MyButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgDashboard = New System.Windows.Forms.PictureBox()
        Me.imgHelp = New System.Windows.Forms.PictureBox()
        Me.imgAccount = New System.Windows.Forms.PictureBox()
        Me.imgNotifications = New System.Windows.Forms.PictureBox()
        Me.imgPreferences = New System.Windows.Forms.PictureBox()
        Me.imgPrivacy = New System.Windows.Forms.PictureBox()
        Me.imgProtection = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnProtection = New Ipo_Protector.MyButton()
        Me.btnPrivacy = New Ipo_Protector.MyButton()
        Me.btnDashboard = New Ipo_Protector.MyButton()
        Me.btnAccount = New Ipo_Protector.MyButton()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.MyButton8 = New Ipo_Protector.MyButton()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CtlDashboard1 = New Ipo_Protector.ctlDashboard()
        Me.CtlScan1 = New Ipo_Protector.ctlScan()
        Me.CtlPrivacy1 = New Ipo_Protector.ctlPrivacy()
        Me.CtlSystemPerformance1 = New Ipo_Protector.ctlSystemPerformance()
        Me.CtlAccount1 = New Ipo_Protector.ctlAccount()
        Me.CtlPremium1 = New Ipo_Protector.ctlPremium()
        Me.CtlSubscription1 = New Ipo_Protector.ctlSubscription()
        Me.MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPreferences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPrivacy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgProtection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.btnNotifications)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.PictureBox8)
        Me.MainPanel.Controls.Add(Me.btnProtection)
        Me.MainPanel.Controls.Add(Me.btnPrivacy)
        Me.MainPanel.Controls.Add(Me.btnDashboard)
        Me.MainPanel.Controls.Add(Me.btnAccount)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(205, 600)
        Me.MainPanel.TabIndex = 0
        '
        'btnNotifications
        '
        Me.btnNotifications.BackColor = System.Drawing.Color.Black
        Me.btnNotifications.BottomColor = System.Drawing.Color.Black
        Me.btnNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnNotifications.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnNotifications.Location = New System.Drawing.Point(53, 273)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(151, 36)
        Me.btnNotifications.TabIndex = 8
        Me.btnNotifications.Text = "System Performance"
        Me.btnNotifications.TopColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnNotifications.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.imgDashboard)
        Me.Panel1.Controls.Add(Me.imgHelp)
        Me.Panel1.Controls.Add(Me.imgAccount)
        Me.Panel1.Controls.Add(Me.imgNotifications)
        Me.Panel1.Controls.Add(Me.imgPreferences)
        Me.Panel1.Controls.Add(Me.imgPrivacy)
        Me.Panel1.Controls.Add(Me.imgProtection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(58, 598)
        Me.Panel1.TabIndex = 9
        '
        'imgDashboard
        '
        Me.imgDashboard.BackColor = System.Drawing.Color.Crimson
        Me.imgDashboard.Image = CType(resources.GetObject("imgDashboard.Image"), System.Drawing.Image)
        Me.imgDashboard.Location = New System.Drawing.Point(11, 147)
        Me.imgDashboard.Name = "imgDashboard"
        Me.imgDashboard.Size = New System.Drawing.Size(36, 36)
        Me.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDashboard.TabIndex = 0
        Me.imgDashboard.TabStop = False
        '
        'imgHelp
        '
        Me.imgHelp.Image = CType(resources.GetObject("imgHelp.Image"), System.Drawing.Image)
        Me.imgHelp.Location = New System.Drawing.Point(11, 11)
        Me.imgHelp.Name = "imgHelp"
        Me.imgHelp.Size = New System.Drawing.Size(36, 36)
        Me.imgHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHelp.TabIndex = 0
        Me.imgHelp.TabStop = False
        '
        'imgAccount
        '
        Me.imgAccount.Image = CType(resources.GetObject("imgAccount.Image"), System.Drawing.Image)
        Me.imgAccount.Location = New System.Drawing.Point(11, 559)
        Me.imgAccount.Name = "imgAccount"
        Me.imgAccount.Size = New System.Drawing.Size(36, 36)
        Me.imgAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAccount.TabIndex = 0
        Me.imgAccount.TabStop = False
        '
        'imgNotifications
        '
        Me.imgNotifications.Image = CType(resources.GetObject("imgNotifications.Image"), System.Drawing.Image)
        Me.imgNotifications.Location = New System.Drawing.Point(11, 273)
        Me.imgNotifications.Name = "imgNotifications"
        Me.imgNotifications.Size = New System.Drawing.Size(36, 36)
        Me.imgNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNotifications.TabIndex = 0
        Me.imgNotifications.TabStop = False
        '
        'imgPreferences
        '
        Me.imgPreferences.Image = CType(resources.GetObject("imgPreferences.Image"), System.Drawing.Image)
        Me.imgPreferences.Location = New System.Drawing.Point(11, 517)
        Me.imgPreferences.Name = "imgPreferences"
        Me.imgPreferences.Size = New System.Drawing.Size(36, 36)
        Me.imgPreferences.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPreferences.TabIndex = 0
        Me.imgPreferences.TabStop = False
        '
        'imgPrivacy
        '
        Me.imgPrivacy.Image = CType(resources.GetObject("imgPrivacy.Image"), System.Drawing.Image)
        Me.imgPrivacy.Location = New System.Drawing.Point(11, 231)
        Me.imgPrivacy.Name = "imgPrivacy"
        Me.imgPrivacy.Size = New System.Drawing.Size(36, 36)
        Me.imgPrivacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPrivacy.TabIndex = 0
        Me.imgPrivacy.TabStop = False
        '
        'imgProtection
        '
        Me.imgProtection.Image = CType(resources.GetObject("imgProtection.Image"), System.Drawing.Image)
        Me.imgProtection.Location = New System.Drawing.Point(11, 189)
        Me.imgProtection.Name = "imgProtection"
        Me.imgProtection.Size = New System.Drawing.Size(36, 36)
        Me.imgProtection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProtection.TabIndex = 0
        Me.imgProtection.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(77, 11)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'btnProtection
        '
        Me.btnProtection.BackColor = System.Drawing.Color.Black
        Me.btnProtection.BottomColor = System.Drawing.Color.Black
        Me.btnProtection.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnProtection.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnProtection.Location = New System.Drawing.Point(53, 189)
        Me.btnProtection.Name = "btnProtection"
        Me.btnProtection.Size = New System.Drawing.Size(151, 36)
        Me.btnProtection.TabIndex = 8
        Me.btnProtection.Text = "Scan Center"
        Me.btnProtection.TopColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnProtection.UseVisualStyleBackColor = False
        '
        'btnPrivacy
        '
        Me.btnPrivacy.BackColor = System.Drawing.Color.Black
        Me.btnPrivacy.BottomColor = System.Drawing.Color.Black
        Me.btnPrivacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnPrivacy.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnPrivacy.Location = New System.Drawing.Point(53, 231)
        Me.btnPrivacy.Name = "btnPrivacy"
        Me.btnPrivacy.Size = New System.Drawing.Size(151, 36)
        Me.btnPrivacy.TabIndex = 8
        Me.btnPrivacy.Text = "Privacy"
        Me.btnPrivacy.TopColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnPrivacy.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Crimson
        Me.btnDashboard.BottomColor = System.Drawing.Color.Crimson
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDashboard.Location = New System.Drawing.Point(53, 147)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(151, 36)
        Me.btnDashboard.TabIndex = 8
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TopColor = System.Drawing.Color.OrangeRed
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.Black
        Me.btnAccount.BottomColor = System.Drawing.Color.Black
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAccount.Location = New System.Drawing.Point(53, 559)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(151, 36)
        Me.btnAccount.TabIndex = 8
        Me.btnAccount.Text = "My Account"
        Me.btnAccount.TopColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.MyButton8)
        Me.HeaderPanel.Controls.Add(Me.BtnMinimize)
        Me.HeaderPanel.Controls.Add(Me.BtnClose)
        Me.HeaderPanel.Controls.Add(Me.lblTitle)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(205, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(795, 41)
        Me.HeaderPanel.TabIndex = 0
        '
        'MyButton8
        '
        Me.MyButton8.BackColor = System.Drawing.Color.IndianRed
        Me.MyButton8.BottomColor = System.Drawing.Color.IndianRed
        Me.MyButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MyButton8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MyButton8.Location = New System.Drawing.Point(588, 0)
        Me.MyButton8.Name = "MyButton8"
        Me.MyButton8.Size = New System.Drawing.Size(139, 40)
        Me.MyButton8.TabIndex = 9
        Me.MyButton8.Text = "Go Premium"
        Me.MyButton8.TopColor = System.Drawing.Color.OrangeRed
        Me.MyButton8.UseVisualStyleBackColor = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Image = CType(resources.GetObject("BtnMinimize.Image"), System.Drawing.Image)
        Me.BtnMinimize.Location = New System.Drawing.Point(733, 9)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimize.TabIndex = 4
        Me.BtnMinimize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(763, 9)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(20, 20)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(6, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(201, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Ipo Protector - Trial Version"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CtlDashboard1)
        Me.Panel2.Controls.Add(Me.HeaderPanel)
        Me.Panel2.Controls.Add(Me.MainPanel)
        Me.Panel2.Controls.Add(Me.CtlScan1)
        Me.Panel2.Controls.Add(Me.CtlPrivacy1)
        Me.Panel2.Controls.Add(Me.CtlSystemPerformance1)
        Me.Panel2.Controls.Add(Me.CtlAccount1)
        Me.Panel2.Controls.Add(Me.CtlPremium1)
        Me.Panel2.Controls.Add(Me.CtlSubscription1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 600)
        Me.Panel2.TabIndex = 1
        '
        'CtlDashboard1
        '
        Me.CtlDashboard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlDashboard1.Location = New System.Drawing.Point(205, 41)
        Me.CtlDashboard1.Name = "CtlDashboard1"
        Me.CtlDashboard1.Size = New System.Drawing.Size(792, 555)
        Me.CtlDashboard1.TabIndex = 1
        '
        'CtlScan1
        '
        Me.CtlScan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlScan1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlScan1.Location = New System.Drawing.Point(205, 41)
        Me.CtlScan1.Name = "CtlScan1"
        Me.CtlScan1.Size = New System.Drawing.Size(795, 556)
        Me.CtlScan1.TabIndex = 2
        '
        'CtlPrivacy1
        '
        Me.CtlPrivacy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlPrivacy1.Location = New System.Drawing.Point(205, 46)
        Me.CtlPrivacy1.Name = "CtlPrivacy1"
        Me.CtlPrivacy1.Size = New System.Drawing.Size(795, 556)
        Me.CtlPrivacy1.TabIndex = 3
        '
        'CtlSystemPerformance1
        '
        Me.CtlSystemPerformance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlSystemPerformance1.Location = New System.Drawing.Point(205, 43)
        Me.CtlSystemPerformance1.Name = "CtlSystemPerformance1"
        Me.CtlSystemPerformance1.Size = New System.Drawing.Size(795, 556)
        Me.CtlSystemPerformance1.TabIndex = 4
        '
        'CtlAccount1
        '
        Me.CtlAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlAccount1.Location = New System.Drawing.Point(205, 46)
        Me.CtlAccount1.Name = "CtlAccount1"
        Me.CtlAccount1.Size = New System.Drawing.Size(795, 556)
        Me.CtlAccount1.TabIndex = 5
        '
        'CtlPremium1
        '
        Me.CtlPremium1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CtlPremium1.Location = New System.Drawing.Point(205, 44)
        Me.CtlPremium1.Name = "CtlPremium1"
        Me.CtlPremium1.Size = New System.Drawing.Size(795, 556)
        Me.CtlPremium1.TabIndex = 6
        '
        'CtlSubscription1
        '
        Me.CtlSubscription1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CtlSubscription1.Location = New System.Drawing.Point(1, 0)
        Me.CtlSubscription1.Name = "CtlSubscription1"
        Me.CtlSubscription1.Size = New System.Drawing.Size(1000, 600)
        Me.CtlSubscription1.TabIndex = 7
        Me.CtlSubscription1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ipo Protector"
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPreferences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPrivacy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgProtection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents imgDashboard As PictureBox
    Friend WithEvents imgNotifications As PictureBox
    Friend WithEvents imgPrivacy As PictureBox
    Friend WithEvents imgProtection As PictureBox
    Friend WithEvents imgAccount As PictureBox
    Friend WithEvents imgPreferences As PictureBox
    Friend WithEvents imgHelp As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDashboard As MyButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNotifications As MyButton
    Friend WithEvents btnProtection As MyButton
    Friend WithEvents btnPrivacy As MyButton
    Friend WithEvents btnAccount As MyButton
    Friend WithEvents MyButton8 As MyButton
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents CtlScan1 As ctlScan
    Friend WithEvents CtlPrivacy1 As ctlPrivacy
    Friend WithEvents CtlSystemPerformance1 As ctlSystemPerformance
    Friend WithEvents CtlAccount1 As ctlAccount
    Friend WithEvents CtlPremium1 As ctlPremium
    Friend WithEvents CtlSubscription1 As ctlSubscription
End Class
