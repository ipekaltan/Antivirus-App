Public Class frmSettings
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
    End Sub
    Public Sub New()
        InitializeComponent()
        ' MouseDown event handler'ını panelinize ekleyin
        AddHandler Panel1.MouseDown, AddressOf frmSettings_MouseDown
    End Sub
    Private Sub frmSettings_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HTCAPTION, 0)
        End If
    End Sub

    Private Sub MyButton3_Click(sender As Object, e As EventArgs) Handles MyButton3.Click
        If CheckBox2.Checked = True Then
            Timer1.Interval = 100000
            Timer1.Start()
        End If

        If CheckBox3.Checked = True Then

        End If

        If CheckBox1.Checked = True Then
            My.Settings.bootUp() = True
            My.Settings.Save()
        Else
            If CheckBox2.Checked = True Then
                My.Settings.scan1Hour() = True
                My.Settings.Save()
            Else
                If CheckBox3.Checked = True Then
                    My.Settings.startVPN() = True
                    My.Settings.Save()
                End If
            End If
        End If

        MsgBox("Settings Saved Successfully", MsgBoxStyle.Information, "Attention!")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            MyFunctions.Scan()
            Timer1.Start()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Visible = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim applicationName As String = Application.ProductName
        Dim applicationPath As String = Application.ExecutablePath

        If CheckBox1.Checked Then
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue(applicationName, """" & applicationPath & """")
            regKey.Close()
            My.Settings.startup = True
            My.Settings.Save()

        Else
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.Close()
            My.Settings.startup = False
            My.Settings.Save()

        End If
    End Sub

End Class