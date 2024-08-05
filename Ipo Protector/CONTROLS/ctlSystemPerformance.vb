Public Class ctlSystemPerformance
    Private Sub ctlSystemPerformance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim name As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)
        lblComputerName.Text = name
        Dim speed As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing) & " MHz"
        lblComputerSpeed.Text = speed
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fcpu As Single = pCPU.NextValue()
        Dim fram As Single = pRAM.NextValue()
        ProgressBar1.Value = CInt(fcpu)
        ProgressBar2.Value = CInt(fram)
        lblcpuSpeed.Text = String.Format("{0:0:00}%", fcpu)
        lblramSpeed.Text = String.Format("{0:0:00}%", fram)
        Chart1.Series("CPU").Points.AddY(fcpu)
        Chart1.Series("RAM").Points.AddY(fram)
    End Sub
End Class
