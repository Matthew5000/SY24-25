Public Class Form1
    Dim time As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy, Avatar, 5, 5)
        PaceX(Enemy3, Platform2, 2)
        PaceX(Enemy2, Platform1, 5)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width / 2 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height / 2 Then
            e.Tag = dir * -1
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
        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
    End Sub
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If p.Bounds.IntersectsWith(obj.Bounds) And UCase(obj.Tag) = UCase(tag) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        time += 1
        TimeLabel.Text = time
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
