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
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform1, ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox2.Image = My.Resources.Resources.YWM1ZjIzMzItMmVkOS00NDQyLTkwOWUtMzJlYzZkNzAzNWIy_box_combo_website_484x424_0
        PictureBox2.Location = New Point(2, 190)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 89)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = My.Resources.Resources.mixed_fruit_transparent_background_png
        Enemy2.Location = New Point(327, 78)
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
        Enemy.Location = New Point(327, 294)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(71, 66)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 3
        Enemy.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = My.Resources.Resources._106_1066363_healthy_food_png_healthy_food_cartoon_png
        Enemy3.Location = New Point(157, 210)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(82, 69)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        ' 
        ' Platform1
        ' 
        Platform1.BackColor = Color.Purple
        Platform1.Location = New Point(284, 141)
        Platform1.Name = "Platform1"
        Platform1.Size = New Size(162, 26)
        Platform1.SizeMode = PictureBoxSizeMode.StretchImage
        Platform1.TabIndex = 5
        Platform1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform1 As PictureBox

End Class
