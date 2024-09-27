<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy = New PictureBox()
        Enemy3 = New PictureBox()
        Platform1 = New PictureBox()
        Platform2 = New PictureBox()
        TimeLabel = New Label()
        TimerLabel = New Label()
        Timer2 = New Timer(components)
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox11 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(704, 190)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(71, 68)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download__1_
        PictureBox2.Location = New Point(106, 327)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 89)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = My.Resources.Resources.mixed_fruit_transparent_background_png
        Enemy2.Location = New Point(209, 69)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(71, 66)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 2
        Enemy2.TabStop = False
        Enemy2.Tag = "-1"
        ' 
        ' Enemy
        ' 
        Enemy.Image = My.Resources.Resources.pngtree_vegetables_and_fruits_in_a_basket_made_with_generative_ai_png_image_7110313
        Enemy.Location = New Point(2, 382)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(71, 66)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 3
        Enemy.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = My.Resources.Resources._106_1066363_healthy_food_png_healthy_food_cartoon_png
        Enemy3.Location = New Point(106, 369)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(65, 47)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        Enemy3.Tag = "-1"
        ' 
        ' Platform1
        ' 
        Platform1.BackColor = Color.Black
        Platform1.Image = My.Resources.Resources.pngtree_white_plate_on_white_background_round_photo_png_image_14364824
        Platform1.Location = New Point(209, 141)
        Platform1.Name = "Platform1"
        Platform1.Size = New Size(237, 26)
        Platform1.SizeMode = PictureBoxSizeMode.StretchImage
        Platform1.TabIndex = 5
        Platform1.TabStop = False
        Platform1.Tag = "wall"
        ' 
        ' Platform2
        ' 
        Platform2.BackColor = Color.Transparent
        Platform2.Image = My.Resources.Resources.pngtree_white_plate_on_white_background_round_photo_png_image_143648241
        Platform2.Location = New Point(106, 422)
        Platform2.Name = "Platform2"
        Platform2.Size = New Size(251, 26)
        Platform2.SizeMode = PictureBoxSizeMode.StretchImage
        Platform2.TabIndex = 6
        Platform2.TabStop = False
        Platform2.Tag = "wall"
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TimeLabel.ForeColor = Color.Transparent
        TimeLabel.Location = New Point(756, 9)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(19, 32)
        TimeLabel.TabIndex = 7
        TimeLabel.Text = " "
        ' 
        ' TimerLabel
        ' 
        TimerLabel.AutoSize = True
        TimerLabel.ForeColor = Color.Transparent
        TimerLabel.Location = New Point(733, 9)
        TimerLabel.Name = "TimerLabel"
        TimerLabel.Size = New Size(0, 20)
        TimerLabel.TabIndex = 8
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(704, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 32)
        Label1.TabIndex = 9
        Label1.Text = "Time"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Highlight
        PictureBox1.Location = New Point(287, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(159, 136)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        PictureBox1.Tag = "wall"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.Highlight
        PictureBox3.Location = New Point(439, 141)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 240)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        PictureBox3.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.Highlight
        PictureBox5.Location = New Point(79, 312)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(31, 136)
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        PictureBox5.Tag = "wall"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.Highlight
        PictureBox6.Location = New Point(667, 12)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(31, 136)
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        PictureBox6.Tag = "wall"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.Highlight
        PictureBox7.Location = New Point(466, 141)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(232, 26)
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        PictureBox7.Tag = "wall"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.Highlight
        PictureBox8.Location = New Point(79, 89)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(31, 136)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        PictureBox8.Tag = "wall"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Black
        PictureBox9.Image = My.Resources.Resources.pngtree_white_plate_on_white_background_round_photo_png_image_14364824
        PictureBox9.Location = New Point(23, 69)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(162, 26)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 17
        PictureBox9.TabStop = False
        PictureBox9.Tag = "wall"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = SystemColors.Highlight
        PictureBox10.Location = New Point(106, 190)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(183, 35)
        PictureBox10.TabIndex = 18
        PictureBox10.TabStop = False
        PictureBox10.Tag = "wall"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Toast
        PictureBox4.Location = New Point(57, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(86, 54)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = My.Resources.Resources.YWM1ZjIzMzItMmVkOS00NDQyLTkwOWUtMzJlYzZkNzAzNWIy_box_combo_website_484x424_0
        PictureBox11.Location = New Point(237, 26)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(164, 109)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 20
        PictureBox11.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.Raising_Canes_max_1200x675
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(TimerLabel)
        Controls.Add(TimeLabel)
        Controls.Add(Platform2)
        Controls.Add(Platform1)
        Controls.Add(Enemy3)
        Controls.Add(Enemy)
        Controls.Add(Enemy2)
        Controls.Add(PictureBox2)
        Controls.Add(Avatar)
        ForeColor = Color.Black
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform1, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents Platform2 As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TimerLabel As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox

End Class
