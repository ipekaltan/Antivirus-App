Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices

Public Class frmScan
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Hide()
    End Sub
    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ListBox1.Items.Clear()
            MyButton1.Enabled = True
        Else
            Exit Sub
        End If

        On Error Resume Next
        For Each strFile As String In System.IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
            ListBox1.Items.Add(strFile)
        Next
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = CInt(Conversions.ToString(ListBox1.Items.Count))
        lblTotal.Text = Conversions.ToString(ListBox1.Items.Count)
        ListBox1.Enabled = False
        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                lblDirectory.Text = ListBox1.SelectedItem.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("main.db").ToString
                ProgressBar1.Increment(1)
                lblVirus.Text = Conversions.ToString(ListBox2.Items.Count)
                lblTotal.Text = Conversions.ToString(ProgressBar1.Value)
                scanbox.Text = read.ToString
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim fs As FileStream = New FileStream(CStr(ListBox1.SelectedItem), FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(fs)
                fs.Close()
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashbyte As Byte
                For Each hashbyte In hash
                    buff.Append(String.Format("{0:X2}", hashbyte))
                Next

                If scanbox.Text.Contains(buff.ToString) Then
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            ListBox1.Enabled = True
            Timer1.Stop()
            If ListBox2.Items.Count > 0 Then
                MessageBox.Show("Scanning has been completed. There was " & vbCrLf & ListBox2.Items.Count & " viruses detected. Please review the list and choose an action.", CStr(MessageBoxButtons.OK))
                MyButton1.Enabled = False
                MyButton3.Enabled = True
                MyButton4.Enabled = True
                Exit Sub
            End If
            MessageBox.Show("Scanning has been completed. " & vbCrLf & ListBox2.Items.Count & " No virus was found ", CStr(MessageBoxButtons.OK))
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If MessageBox.Show("Are you sure you want to abort the scannig?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Timer1.Stop()
            If ListBox2.Items.Count > 0 Then
                MsgBox("Scanning has been completed. There was " & vbCrLf & ListBox2.Items.Count & " viruses detected. Please review the list and choose an action.", CStr(MessageBoxButtons.OK))
                Timer1.Stop()
                ProgressBar1.Value = 0
                MyButton1.Enabled = False
                MyButton3.Enabled = True
                MyButton4.Enabled = True
            Else
                MessageBox.Show("Scanning has been completed. " & vbCrLf & ListBox2.Items.Count & " No virus was found ", CStr(MessageBoxButtons.OK))
                Timer1.Stop()
                ProgressBar1.Value = 0
                MyButton1.Enabled = False
            End If
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FolderBrowserDialog1.SelectedPath = "C:\"

        On Error Resume Next
        For Each strDir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly)
            For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                ListBox1.Items.Add(strFile)
            Next
        Next

        MyButton1.Enabled = False
        MyButton3.Enabled = True
        MyButton4.Enabled = True

        Timer1.Start()
        ProgressBar1.Visible = False
    End Sub

    Public Sub New()
        InitializeComponent()
        ' MouseDown event handler'ını panelinize ekleyin
        AddHandler HeaderPanel.MouseDown, AddressOf frmScan_MouseDown
    End Sub

    Private Sub frmScan_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HTCAPTION, 0)
        End If
    End Sub

    Private Sub MyButton3_Click(sender As Object, e As EventArgs) Handles MyButton3.Click
        ListBox2.Enabled = False
        ListBox2.SelectedIndex = -1
        If ListBox2.Items.Count = 0 Then
            MessageBox.Show("Are you sure?", CStr(MessageBoxButtons.OK))
        Else
            Exit Sub
        End If

        While ListBox2.Items.Count - 1 = ListBox1.SelectedIndex = False
            ListBox2.SelectedIndex += 1
            File.Delete(CStr(ListBox2.SelectedItem))
            If ListBox2.Items.Count = ListBox2.SelectedIndex + 1 Then
                ListBox2.Items.Clear()
                ListBox2.Enabled = True
                MessageBox.Show("All viruses have been removed. Your computer is now secured.", CStr(MessageBoxButtons.OK))
                ProgressBar1.Value = 0
                MyButton1.Enabled = False
                MyButton3.Enabled = False
                MyButton4.Enabled = False
                Exit Sub
            End If
        End While
    End Sub

    Private Sub MyButton4_Click(sender As Object, e As EventArgs) Handles MyButton4.Click
        If MessageBox.Show("Are you sure you want to ignore all items?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox2.Items.Clear()
            ListBox2.Enabled = True
            ProgressBar1.Value = 0
            MyButton1.Enabled = False
            MyButton3.Enabled = False
            MyButton4.Enabled = False
        End If
    End Sub
End Class