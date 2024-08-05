Imports System.ComponentModel
Imports System.IO

Public Class ctlPrivacy

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MyFunctions.username = "freevpn"
        MyFunctions.host = "83.170.115.92"
        MyFunctions.password = "account"
        MyFunctions.locations = "USA"
        PictureBox1.Image = PictureBox4.Image
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MyFunctions.username = "free"
        MyFunctions.host = "65.111.173.161"
        MyFunctions.password = "1234"
        MyFunctions.locations = "Germany"
        PictureBox1.Image = PictureBox2.Image
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MyFunctions.username = "free"
        MyFunctions.host = "108.163.169.44"
        MyFunctions.password = "Canada"
        PictureBox1.Image = PictureBox3.Image
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Try
            Dim vpnFolderPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector"

            ' Ensure the directory exists
            If Not IO.Directory.Exists(vpnFolderPath) Then
                IO.Directory.CreateDirectory(vpnFolderPath)
            End If

            ' Write connection.pbk file
            IO.File.WriteAllText(vpnFolderPath & "\connection.pbk", "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & MyFunctions.host)

            ' Write connection.bat file
            IO.File.WriteAllText(vpnFolderPath & "\connection.bat", "rasdial ""VPN"" " & MyFunctions.username & " " & MyFunctions.password & " /phonebook:" & """" & vpnFolderPath & "\connection.pbk""")

            ' Start the connection process
            Dim connect As New System.Diagnostics.Process()
            connect.StartInfo.FileName = vpnFolderPath & "\connection.bat"
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            connect.Start()
            connect.WaitForExit()

            ' Check if the process exited successfully
            If connect.ExitCode = 0 Then
                Label2.Text = "CONNECTED - Your IP is " & MyFunctions.host
                Label2.ForeColor = Color.Green
                PictureBox8.Image = My.Resources.connected
                Label1.Text = "You are connected to " & MyFunctions.locations
                MyButton2.Enabled = False
                MyButton1.Enabled = True
                Panel1.Visible = False
            Else
                Label2.Text = "FAILED TO CONNECT"
                Label2.ForeColor = Color.Red
            End If
        Catch ex As FileNotFoundException
            MessageBox.Show("File not found: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Win32Exception
            MessageBox.Show("A system error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Try
            Dim vpnFolderPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector"

            ' Write disconnect.bat file
            IO.File.WriteAllText(vpnFolderPath & "\disconnect.bat", "rasdial /d")

            ' Start the disconnect process
            Dim connect As New System.Diagnostics.Process()
            connect.StartInfo.FileName = vpnFolderPath & "\disconnect.bat"
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            connect.Start()
            connect.WaitForExit()

            ' Check if the process exited successfully
            If connect.ExitCode = 0 Then
                Label2.Text = "VPN DISCONNECTED"
                Label2.ForeColor = Color.White
                PictureBox8.Image = My.Resources.disconnected
                Label1.Text = "Choose Country"
                MyButton2.Enabled = True
                MyButton1.Enabled = False
                Panel1.Visible = True
            Else
                Label2.Text = "FAILED TO DISCONNECT"
                Label2.ForeColor = Color.Red
            End If
        Catch ex As FileNotFoundException
            MessageBox.Show("File not found: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Win32Exception
            MessageBox.Show("A system error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
