Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class MyFunctions

    Public Shared username As String
    Public Shared password As String
    Public Shared host As String
    Public Shared locations As String

    ' DLL import for dragging the window
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = &H2

    <DllImport("User32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("User32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Public Shared Sub privacyClick()
        With Form1.btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgDashboard.BackColor = MyColors.imageDeactiveColor

        With Form1.btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgProtection.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPrivacy
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        Form1.imgPrivacy.BackColor = MyColors.imageActiveColor

        With Form1.btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgNotifications.BackColor = MyColors.imageDeactiveColor

        With Form1.btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Public Shared Sub systemPerformanceClick()
        With Form1.btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgDashboard.BackColor = MyColors.imageDeactiveColor

        With Form1.btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgProtection.BackColor = MyColors.imageDeactiveColor

        With Form1.btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With Form1.btnNotifications
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2

        End With
        Form1.imgNotifications.BackColor = MyColors.imageActiveColor

        With Form1.btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        Form1.imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Public Shared Sub Enable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=enable"
        firewall.Start()
        MsgBox("Firewall Enabled Successfully!", MsgBoxStyle.Information, "Attention!")
        My.Settings.Firewall = True
        My.Settings.Save()
    End Sub

    Public Shared Sub Disable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=disable"
        firewall.Start()
        MsgBox("Firewall Disabled Successfully!", MsgBoxStyle.Information, "Attention!")
        My.Settings.Firewall = False
        My.Settings.Save()
    End Sub

    Public Shared Sub Scan()
        frmScan.ShowDialog()
        frmScan.FolderBrowserDialog1.SelectedPath = "C:\"

        On Error Resume Next
        For Each strDir As String In System.IO.Directory.GetDirectories(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly)
            For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                frmScan.ListBox1.Items.Add(strFile)
            Next
        Next

        frmScan.MyButton1.Enabled = False
        frmScan.MyButton3.Enabled = True
        frmScan.MyButton4.Enabled = True

        frmScan.Timer1.Start()
        frmScan.ProgressBar1.Visible = False
    End Sub

    Public Shared Sub StartVPN()
        MyFunctions.username = "freevpn"
        MyFunctions.host = "83.170.115.92"
        MyFunctions.password = "account"
        MyFunctions.locations = "USA"
        Form1.CtlPrivacy1.PictureBox1.Image = Form1.CtlPrivacy1.PictureBox4.Image

        With Form1

            .CtlPrivacy1.MyButton1.PerformClick()
        End With
    End Sub

    Public Shared Sub userDetails()
        If My.Settings.ActivationStatus = True Then
            Form1.CtlAccount1.MyButton1.Visible = False
            Form1.CtlAccount1.MyButton2.Visible = False
        End If
        With Form1
            .CtlAccount1.lblemail.Text = My.Settings.email
            .CtlAccount1.lblexpiry.Text = My.Settings.expiry
            .CtlAccount1.lblvalidation.Text = My.Settings.validation
            .CtlAccount1.lblActivationKey.Text = My.Settings.serialKey
        End With
    End Sub

End Class
