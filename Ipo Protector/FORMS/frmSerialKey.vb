Public Class frmSerialKey
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Hide()
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MsgBox("Please Enter E-mail/Serial Key to continue", MsgBoxStyle.Information)
        Else
            If TextBox1.Text = Nothing Then
                MsgBox("Please Enter E-mail to continue", MsgBoxStyle.Information)
            Else
                If TextBox2.Text = Nothing Then
                    MsgBox("Please Enter Serial Key to continue", MsgBoxStyle.Information)
                Else
                    If TextBox2.Text = My.Settings.monthKey Then
                        My.Settings.ActivationStatus = True
                        My.Settings.serialKey = TextBox2.Text
                        My.Settings.email = TextBox1.Text
                        My.Settings.expiry = "Monthly Subscription"
                        My.Settings.validation = "31 Days Activated"
                        My.Settings.Save()
                        Application.Restart()
                    Else
                        If TextBox2.Text = My.Settings.yearKey Then
                            My.Settings.ActivationStatus = True
                            My.Settings.serialKey = TextBox2.Text
                            My.Settings.email = TextBox1.Text
                            My.Settings.expiry = "Yearly Subscription"
                            My.Settings.validation = "365 Days Activated"
                            My.Settings.Save()
                            Application.Restart()
                        Else
                            If TextBox2.Text = My.Settings.lifetimeKey Then
                                My.Settings.ActivationStatus = True
                                My.Settings.serialKey = TextBox2.Text
                                My.Settings.email = TextBox1.Text
                                My.Settings.expiry = "Life Time Subscription"
                                My.Settings.validation = "Forever"
                                My.Settings.Save()
                                Application.Restart()
                            Else
                                MsgBox("Invalid Serial Key/Email, Please contact us for support.", MsgBoxStyle.Information)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class