Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy, Avatar, 5, 5)
        follow(Enemy3, Avatar, 7, 7)
        pace(Enemy2, Platform1, 5)
    End Sub
    Sub pace(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag
        If e.Location.X > p.Location.X Then
            e.Location += New Point(speed * dir, 0)
            dir = -dir
        Else e.Location += New Point(-speed * dir, 0)
        End If



    End Sub
    Sub follow(E As PictureBox, A As PictureBox, xspeed As Integer, yspeed As Integer)

        If E.Location.Y < A.Location.Y Then
            move(E, 0, yspeed)
        Else
            move(E, 0, -yspeed)
        End If
        If E.Location.X < A.Location.X Then
            move(E, xspeed, 0)
        Else
            move(E, -xspeed, 0)
        End If
    End Sub
    Private Sub Form1_Keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 20, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -20, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 20)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -20)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        Avatar.Refresh()
        If Avatar.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            PictureBox2.Visible = False
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
    End Sub

End Class
