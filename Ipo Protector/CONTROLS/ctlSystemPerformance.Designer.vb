<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSystemPerformance
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.lblcpuSpeed = New System.Windows.Forms.Label()
        Me.lblramSpeed = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pCPU = New System.Diagnostics.PerformanceCounter()
        Me.pRAM = New System.Diagnostics.PerformanceCounter()
        Me.lblComputerSpeed = New System.Windows.Forms.Label()
        Me.lblComputerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(40, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 5)
        Me.Panel1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(36, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(467, 47)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Monitor your computer performance very easily." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We help you to control your compu" &
    "ter speed as you wish to do so." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(31, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(509, 53)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Computer Performance"
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(88, 183)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.LabelBackColor = System.Drawing.Color.White
        Series5.Legend = "Legend1"
        Series5.Name = "CPU"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "RAM"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(576, 205)
        Me.Chart1.TabIndex = 33
        Me.Chart1.Text = "Chart1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(210, 473)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(443, 23)
        Me.ProgressBar1.TabIndex = 35
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(210, 505)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(443, 23)
        Me.ProgressBar2.TabIndex = 35
        '
        'lblcpuSpeed
        '
        Me.lblcpuSpeed.AutoSize = True
        Me.lblcpuSpeed.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblcpuSpeed.ForeColor = System.Drawing.SystemColors.Control
        Me.lblcpuSpeed.Location = New System.Drawing.Point(660, 473)
        Me.lblcpuSpeed.Name = "lblcpuSpeed"
        Me.lblcpuSpeed.Size = New System.Drawing.Size(105, 21)
        Me.lblcpuSpeed.TabIndex = 36
        Me.lblcpuSpeed.Text = "CPU Speed"
        '
        'lblramSpeed
        '
        Me.lblramSpeed.AutoSize = True
        Me.lblramSpeed.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblramSpeed.ForeColor = System.Drawing.SystemColors.Control
        Me.lblramSpeed.Location = New System.Drawing.Point(659, 505)
        Me.lblramSpeed.Name = "lblramSpeed"
        Me.lblramSpeed.Size = New System.Drawing.Size(106, 21)
        Me.lblramSpeed.TabIndex = 37
        Me.lblramSpeed.Text = "RAM Speed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(670, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 21)
        Me.Label6.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Salmon
        Me.Panel2.Location = New System.Drawing.Point(73, 474)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 20)
        Me.Panel2.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lime
        Me.Panel3.Location = New System.Drawing.Point(73, 505)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 41
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pCPU
        '
        Me.pCPU.CategoryName = "Processor"
        Me.pCPU.CounterName = "% Processor Time"
        Me.pCPU.InstanceName = "_Total"
        '
        'pRAM
        '
        Me.pRAM.CategoryName = "Memory"
        Me.pRAM.CounterName = "% Committed Bytes in Use"
        '
        'lblComputerSpeed
        '
        Me.lblComputerSpeed.AutoSize = True
        Me.lblComputerSpeed.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblComputerSpeed.ForeColor = System.Drawing.SystemColors.Control
        Me.lblComputerSpeed.Location = New System.Drawing.Point(84, 436)
        Me.lblComputerSpeed.Name = "lblComputerSpeed"
        Me.lblComputerSpeed.Size = New System.Drawing.Size(0, 21)
        Me.lblComputerSpeed.TabIndex = 42
        '
        'lblComputerName
        '
        Me.lblComputerName.AutoSize = True
        Me.lblComputerName.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblComputerName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblComputerName.Location = New System.Drawing.Point(84, 404)
        Me.lblComputerName.Name = "lblComputerName"
        Me.lblComputerName.Size = New System.Drawing.Size(0, 21)
        Me.lblComputerName.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(99, 476)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "CPU Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(99, 505)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "RAM Speed"
        '
        'ctlSystemPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblComputerName)
        Me.Controls.Add(Me.lblComputerSpeed)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblramSpeed)
        Me.Controls.Add(Me.lblcpuSpeed)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ctlSystemPerformance"
        Me.Size = New System.Drawing.Size(792, 555)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pRAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents lblcpuSpeed As Label
    Friend WithEvents lblramSpeed As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pCPU As PerformanceCounter
    Public WithEvents pRAM As PerformanceCounter
    Friend WithEvents lblComputerSpeed As Label
    Friend WithEvents lblComputerName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
