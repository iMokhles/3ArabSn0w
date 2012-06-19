Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports System
Imports System.Management

Public Class cinjectgui
    Dim cinject As New Process
    Dim aName As String = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
    Dim aPath As String = System.IO.Path.GetDirectoryName(aName)
    Dim msg As String
    Dim title As String
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult
    Dim oForm As aboutus
    Dim oForm2 As Owners
    Dim oForm3 As HereUs
    Dim oForm4 As options

    Private Sub cinjectgui_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cinject.StartInfo.FileName = "cmd.exe"
        cinject.StartInfo.RedirectStandardInput = True
        cinject.StartInfo.UseShellExecute = False
        cinject.StartInfo.CreateNoWindow = True
        cinject.StartInfo.RedirectStandardOutput = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles info.Click

    End Sub

    Private Sub داعمينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles داعمينToolStripMenuItem.Click
        oForm2 = New Owners()
        oForm2.Show()
    End Sub

    Private Sub تبرعللمطورToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub حولالمطورToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حولالمطورToolStripMenuItem.Click
        oForm = New aboutus()
        oForm.Show()
    End Sub

    Private Sub حولالبرنامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حولالبرنامجToolStripMenuItem.Click
        oForm3 = New HereUs
        oForm3.Show()
    End Sub

    Private Sub حولToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حولToolStripMenuItem.Click

    End Sub

    Private Sub غلقالبرنامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles غلقالبرنامجToolStripMenuItem.Click
        ' Close this window
        Me.Close()
    End Sub

    Private Sub تصغيرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تصغيرToolStripMenuItem.Click
        ' Minimize this window
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://twitter.com/#!/sonadoor")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://twitter.com/#!/iMokhles")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        info.Text = "...... تم البدأ"

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        Label9.Text = "1"
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "Y.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        info.Text = "قم بتوصيل جهازك بالكمبيوتر و إضغط على قم بالجيلبريك"
        Button2.Visible = False
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        oForm4 = New options
        oForm4.Show()
    End Sub

    Private Sub cmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button1.Text = "...... تم البدأ" Then
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 100
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label9.Text += 1
        If Label9.Text = "1" Then
            info.Text = "Beginning jailbreak ..."
            ProgressBar1.Value = 10
        End If
        If Label9.Text = "3" Then
            info.Text = "Uploading jb files ..."
            ProgressBar1.Value = 20
        End If

        If Label9.Text = "4" Then
            info.Text = "Hiding media ..."
            ProgressBar1.Value = 30
        End If
        If Label9.Text = "6" Then
            info.Text = "Getting backup ..."
            ProgressBar1.Value = 40
        End If
        If Label9.Text = "8" Then
            info.Text = "Modifying backup (stage 1) ..."
            ProgressBar1.Value = 45

        End If
        If Label9.Text = "12" Then
            info.Text = "Restoring from modified backup (this may take a while) ..."
            ProgressBar1.Value = 55
        End If
        If Label9.Text = "16" Then
            info.Text = "Sending jailbreak data ... Your device will appear to be restoring a backup."
            ProgressBar1.Value = 60
        End If
        If Label9.Text = "24" Then
            info.Text = "Fetching racoon..."
            ProgressBar1.Value = 65
        End If
        If Label9.Text = "26" Then
            info.Text = "Patching racoon..."
            ProgressBar1.Value = 70

        End If
        If Label9.Text = "27" Then
            info.Text = "Modifying backup (stage 2)..."
            ProgressBar1.Value = 80

        End If
        If Label9.Text = "29" Then
            info.Text = "Restoring from modified backup..."
            ProgressBar1.Value = 83


        End If
        If Label9.Text = "31" Then
            info.Text = "Unhiding media..."
            ProgressBar1.Value = 86

        End If


        If Label9.Text = "33" Then
            info.Text = "Rebooting ..."
            ProgressBar1.Value = 90
        End If

    End Sub
End Class
