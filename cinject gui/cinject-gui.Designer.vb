<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cinjectgui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cinjectgui))
        Me.info = New System.Windows.Forms.Label()
        Me.cmd = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.إعداداتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.غلقالبرنامجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تصغيرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولالبرنامجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.حولالمطورToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.داعمينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.Location = New System.Drawing.Point(103, 227)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(408, 31)
        Me.info.TabIndex = 2
        Me.info.Text = "قم بتوصيل جهازك بالكمبيوتر و اضغط على زر قم بالجيلبريك"
        Me.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd
        '
        Me.cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmd.ForeColor = System.Drawing.SystemColors.Info
        Me.cmd.Location = New System.Drawing.Point(12, 335)
        Me.cmd.Multiline = True
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(408, 117)
        Me.cmd.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إعداداتToolStripMenuItem, Me.حولToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(452, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'إعداداتToolStripMenuItem
        '
        Me.إعداداتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.غلقالبرنامجToolStripMenuItem, Me.تصغيرToolStripMenuItem})
        Me.إعداداتToolStripMenuItem.Name = "إعداداتToolStripMenuItem"
        Me.إعداداتToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.إعداداتToolStripMenuItem.Text = "إعدادات"
        '
        'غلقالبرنامجToolStripMenuItem
        '
        Me.غلقالبرنامجToolStripMenuItem.Name = "غلقالبرنامجToolStripMenuItem"
        Me.غلقالبرنامجToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.غلقالبرنامجToolStripMenuItem.Text = "غلق البرنامج"
        '
        'تصغيرToolStripMenuItem
        '
        Me.تصغيرToolStripMenuItem.Name = "تصغيرToolStripMenuItem"
        Me.تصغيرToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.تصغيرToolStripMenuItem.Text = "تصغير"
        '
        'حولToolStripMenuItem
        '
        Me.حولToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حولالبرنامجToolStripMenuItem, Me.حولالمطورToolStripMenuItem, Me.داعمينToolStripMenuItem})
        Me.حولToolStripMenuItem.Name = "حولToolStripMenuItem"
        Me.حولToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.حولToolStripMenuItem.Text = "حول البرنامج"
        '
        'حولالبرنامجToolStripMenuItem
        '
        Me.حولالبرنامجToolStripMenuItem.Name = "حولالبرنامجToolStripMenuItem"
        Me.حولالبرنامجToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.حولالبرنامجToolStripMenuItem.Text = "حول البرنامج"
        '
        'حولالمطورToolStripMenuItem
        '
        Me.حولالمطورToolStripMenuItem.Name = "حولالمطورToolStripMenuItem"
        Me.حولالمطورToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.حولالمطورToolStripMenuItem.Text = "حول المطور"
        '
        'داعمينToolStripMenuItem
        '
        Me.داعمينToolStripMenuItem.Name = "داعمينToolStripMenuItem"
        Me.داعمينToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.داعمينToolStripMenuItem.Text = "داعمين"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 172)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "عرب سنو اول برنامج جيلبريك عربي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "أداة الجيلبريك غير المقيد للاصدار 5.1.1 و 5.0.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "برجاء القيام بباك اب للجهاز قبل عمل الجيلبريك"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "مكتشفى الثغرات"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "@pod2g, @planetbeing, @saurik, @pimskeks," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " @p0sixninja, @MuscleNerd, @xvolks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "الواجهه و اللوجو"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(392, 198)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(55, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SonaDoor"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(337, 198)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(49, 13)
        Me.LinkLabel2.TabIndex = 16
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "iMokhles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "جيلبريك 5.1.1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 26)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "إنتهى"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 26)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "الاعدادات"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(127, 271)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(212, 26)
        Me.ProgressBar1.TabIndex = 20
        '
        'Timer2
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Label7"
        '
        'cinjectgui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(452, 309)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cinjectgui"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3ArabSn0w.. By : iMokhles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents cmd As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents إعداداتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents غلقالبرنامجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تصغيرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حولToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حولالبرنامجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حولالمطورToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents داعمينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
