Imports System.Runtime.InteropServices

Public Class Form1
    Public Sub New()
        InitializeComponent()
        ' MouseDown event handler'ını panelinize ekleyin
        AddHandler HeaderPanel.MouseDown, AddressOf HeaderPanel_MouseDown
    End Sub

    Private Sub HeaderPanel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HTCAPTION, 0)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        frmClose.ShowDialog()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CtlDashboard1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        With btnDashboard
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgDashboard.BackColor = MyColors.imageActiveColor
        CtlDashboard1.BringToFront()
        CtlDashboard1.Visible = True

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotifications.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnProtection_Click(sender As Object, e As EventArgs) Handles btnProtection.Click
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        CtlScan1.BringToFront()
        CtlScan1.Visible = True
        imgDashboard.BackColor = MyColors.imageDeactiveColor



        With btnProtection
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2
        End With
        imgProtection.BackColor = MyColors.imageActiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotifications.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor

    End Sub

    Private Sub btnPrivacy_Click(sender As Object, e As EventArgs) Handles btnPrivacy.Click
        MyFunctions.privacyClick()
        If My.Settings.ActivationStatus = False Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlPrivacy1.BringToFront()
            CtlPrivacy1.Visible = True
        End If
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        MyFunctions.systemPerformanceClick()
        If My.Settings.ActivationStatus = False Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlSystemPerformance1.BringToFront()
            CtlSystemPerformance1.Visible = True
        End If
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        CtlAccount1.BringToFront()
        CtlAccount1.Visible = True
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotifications.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.active_color1
            .TopColor = MyColors.active_color2

        End With
        imgAccount.BackColor = MyColors.imageActiveColor
    End Sub

    Private Sub btnPreferences_Click(sender As Object, e As EventArgs)
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotifications.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
        With btnDashboard
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgDashboard.BackColor = MyColors.imageDeactiveColor

        With btnProtection
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgProtection.BackColor = MyColors.imageDeactiveColor

        With btnPrivacy
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgPrivacy.BackColor = MyColors.imageDeactiveColor

        With btnNotifications
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgNotifications.BackColor = MyColors.imageDeactiveColor

        With btnAccount
            .BottomColor = MyColors.deactive_color1
            .TopColor = MyColors.deactive_color2
        End With
        imgAccount.BackColor = MyColors.imageDeactiveColor
    End Sub

    Private Sub imgPreferences_Click(sender As Object, e As EventArgs) Handles imgPreferences.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub imgHelp_Click(sender As Object, e As EventArgs) Handles imgHelp.Click
        Process.Start(MyStrings.HelpLink)
    End Sub

    Private Sub MyButton8_Click(sender As Object, e As EventArgs) Handles MyButton8.Click
        CtlSubscription1.BringToFront()
        CtlSubscription1.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        If My.Settings.ActivationStatus = True Then
            lblTitle.Text = "Ipo Protector - " & My.Settings.validation
            MyButton8.Visible = False
        Else
            MyButton8.Visible = True
        End If


        If My.Settings.startVPN = True Then
            MyFunctions.StartVPN()
        End If

        If My.Settings.scan1Hour = True Then
            If frmSettings.CheckBox2.Checked Then
                MyFunctions.Scan()
            End If
        End If

        If My.Settings.ActivationStatus = False Then
            CtlSubscription1.BringToFront()
            CtlSubscription1.Visible = True
        End If
    End Sub
End Class