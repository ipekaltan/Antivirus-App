Public Class ctlSubscription
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Hide()
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub MyButton3_Click(sender As Object, e As EventArgs) Handles MyButton3.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSerialKey.ShowDialog()
    End Sub
End Class
