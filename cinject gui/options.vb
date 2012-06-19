Imports System.Net
Imports System.IO
Imports System.Text

Public Class options
    Dim cinject As New Process
    Dim aName As String = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
    Dim aPath As String = System.IO.Path.GetDirectoryName(aName)
    Dim msg As String
    Dim title As String
    Dim style As MsgBoxStyle
    Dim response As MsgBoxResult

    Private Sub cinjectgui_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cinject.StartInfo.FileName = "cmd.exe"
        cinject.StartInfo.RedirectStandardInput = True
        cinject.StartInfo.UseShellExecute = False
        cinject.StartInfo.CreateNoWindow = True
        cinject.StartInfo.RedirectStandardOutput = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://twitter.com/#!/iMokhles")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        info.Text = "...... تم البدأ"

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "..... يقوم بعمل باك اب الان"
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "B.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
        info.Text = ". برجاء الانتظار حتى يتم الانتهاء"
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles info.Click

    End Sub

    Private Sub cmd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        info.Text = "...... تم البدأ"

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "..... يقوم بإعادة الباك اب"
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "R.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
        info.Text = ". برجاء الانتظار حتى يتم الانتهاء"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        info.Text = "...... تم البدأ"

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "..... يقوم بإخفاء الصور"
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "H.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
        info.Text = ". برجاء الانتظار حتى يتم الانتهاء"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        info.Text = "...... تم البدأ"

        cinject.Start()

        Dim myStreamWriter As StreamWriter = cinject.StandardInput

        info.Text = "..... يقوم بإعادة الباك اب"
        myStreamWriter.WriteLine("cd " & aPath & "\scripts" & vbNewLine & "U.bat" & vbNewLine)
        cinject.WaitForExit()
        cmd.Text = cinject.StandardOutput.ReadToEnd
        info.Text = ". برجاء الانتظار حتى يتم الانتهاء"
    End Sub
End Class