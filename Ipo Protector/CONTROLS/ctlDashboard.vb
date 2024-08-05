Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Threading

Public Class ctlDashboard

    Dim isActive As Boolean
    Private Async Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If My.Settings.ActivationStatus = True Then
            frmScan.ShowDialog()

            frmScan.FolderBrowserDialog1.SelectedPath = "C:\"

            Try
                ' Call the async scanning method
                Await ScanDirectoryAsync(frmScan.FolderBrowserDialog1.SelectedPath)

                frmScan.MyButton1.Enabled = False
                frmScan.MyButton3.Enabled = True
                frmScan.MyButton4.Enabled = True
                frmScan.Timer1.Start()
                frmScan.ProgressBar1.Visible = True
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Else
            Form1.CtlPremium1.BringToFront()
            Form1.CtlPremium1.Visible = True
        End If


        If frmScan Is Nothing Then
            MessageBox.Show("frmScan is not initialized.")
            Return
        End If
    End Sub

    Private Async Function ScanDirectoryAsync(selectedPath As String) As Task
        If My.Settings.ActivationStatus = True Then
            If String.IsNullOrEmpty(selectedPath) Then
                MessageBox.Show("The selected path is empty or null.")
                Return
            End If

            Try
                Await Task.Run(Sub() ScanDirectories(selectedPath))
            Catch ex As Exception
                ' Safely show the error message on the UI thread
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Function

    Private Sub ScanDirectories(selectedPath As String)
        If My.Settings.ActivationStatus = True Then
            Try
                ' Get directories in the selected path
                Dim directories As String() = Directory.GetDirectories(selectedPath, "*.*", SearchOption.TopDirectoryOnly)
                For Each strDir As String In directories
                    ' Get files in the directory
                    Dim files As String() = Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                    For Each strFile As String In files
                        ' Safely update the UI from a background thread
                        Invoke(New Action(Sub() frmScan.ListBox1.Items.Add(strFile)))
                    Next
                Next
            Catch ex As Exception
                ' Handle exceptions (e.g., access denied) appropriately
                Invoke(New Action(Sub() MessageBox.Show("An error occurred while scanning: " & ex.Message)))
            End Try
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If My.Settings.ActivationStatus = True Then
            frmScan.ShowDialog()

            If frmScan.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                frmScan.ListBox1.Items.Clear()
                MyButton1.Enabled = True
            Else
                Exit Sub
            End If

            On Error Resume Next
            For Each strFile As String In System.IO.Directory.GetFiles(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
                frmScan.ListBox1.Items.Add(strFile)
            Next
            frmScan.Timer1.Start()
        Else
            Form1.CtlPremium1.BringToFront()
            Form1.CtlPremium1.Visible = True
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If My.Settings.ActivationStatus = True Then
            Form1.btnPrivacy.PerformClick()
        Else
            Form1.CtlPremium1.BringToFront()
            Form1.CtlPremium1.Visible = True
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(MyStrings.HelpLink)
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If isActive = False Then
            isActive = True
            MyButton1.Text = "Disabled"
            MyButton1.BottomColor = Color.Crimson
            MyButton1.TopColor = Color.OrangeRed
            MyFunctions.Disable_Firewall()

        ElseIf isActive = True Then
            isActive = False
            MyButton1.Text = "Enabled"
            MyButton1.BottomColor = Color.DodgerBlue
            MyButton1.TopColor = Color.RoyalBlue
            MyFunctions.Enable_Firewall()
        End If
    End Sub

    Private Sub ctlDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.Firewall = True Then
            isActive = True
            MyButton1.BottomColor = Color.Crimson
            MyButton1.TopColor = Color.OrangeRed
            MyButton1.Text = "Disabled"

        ElseIf My.Settings.Firewall = False Then
            isActive = False
            MyButton1.BottomColor = Color.DodgerBlue
            MyButton1.TopColor = Color.RoyalBlue
            MyButton1.Text = "Enabled"
        End If
    End Sub
End Class
