Public Class ctlScan
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If My.Settings.ActivationStatus = True Then
            frmScan.ShowDialog()
        Else
            Form1.CtlPremium1.BringToFront()
            Form1.CtlPremium1.Visible = True
        End If
    End Sub
End Class
