Public Class ctlPremium
    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Form1.CtlSubscription1.BringToFront()
        Form1.CtlSubscription1.Visible = True
    End Sub
End Class
