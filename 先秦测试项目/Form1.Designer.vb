<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.maintab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.maintab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'maintab
        '
        Me.maintab.Controls.Add(Me.TabPage1)
        Me.maintab.Controls.Add(Me.TabPage2)
        Me.maintab.Location = New System.Drawing.Point(12, 12)
        Me.maintab.Name = "maintab"
        Me.maintab.SelectedIndex = 0
        Me.maintab.Size = New System.Drawing.Size(960, 577)
        Me.maintab.TabIndex = 0
        Me.maintab.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PictureBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(952, 551)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "文明起源"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(799, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "显示答案"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(635, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "猜对三个即可过关"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(642, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "开始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(723, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 83)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(638, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "请猜图中的字符"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(105, 105)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(393, 333)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(952, 551)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "春秋争霸"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label17.Location = New System.Drawing.Point(677, 436)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 27)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "???"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label16.Location = New System.Drawing.Point(668, 366)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 27)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "???"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label15.Location = New System.Drawing.Point(413, 434)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 27)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "???"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label14.Location = New System.Drawing.Point(252, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 27)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "???"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label13.Location = New System.Drawing.Point(178, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 27)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "???"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label12.Location = New System.Drawing.Point(584, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 27)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "???"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(596, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 27)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "???"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(560, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 27)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "???"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(530, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 27)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "???"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(477, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 27)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "???"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(480, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "???"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(518, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "???"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(413, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "???"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(271, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "???"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.先秦测试项目.My.Resources.Resources.map
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(940, 539)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 601)
        Me.Controls.Add(Me.maintab)
        Me.Name = "Main"
        Me.Text = "先秦文化"
        Me.maintab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents maintab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
