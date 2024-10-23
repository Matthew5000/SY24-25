Imports System.Security.Cryptography.Pkcs

Public Class Form1
    Dim time As Integer
    Dim score As Integer
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Dim count As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PaceX(Enemy3, Platform2, 6)
        PaceX(Enemy2, Platform1, 6)
        Track(Tracker, Avatar)
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
            Avatar.Refresh()
            count = count + 1
            score += 50
        ElseIf Avatar.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            PictureBox4.Visible = False
            Avatar.Refresh()
            count = count + 1
            score += 50
        ElseIf Avatar.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            PictureBox11.Visible = False
            count = count + 1
            score += 50
        ElseIf Avatar.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            PictureBox13.Visible = False
            count = count + 1
            score += 50
        ElseIf Avatar.Bounds.IntersectsWith(Enemy2.Bounds) Then
            score -= 50
        ElseIf Avatar.Bounds.IntersectsWith(Enemy3.Bounds) Then
            score -= 50
        ElseIf Avatar.Bounds.IntersectsWith(tracker.Bounds) Then
            score -= 50
        End If
        If count >= 8 Then
            Reset.Visible = True
            PictureBox5.Visible = True
            Reset.ForeColor = Color.Green
        End If
        If score <= -50 Then
            Reset.Visible = True
            PictureBox14.Visible = True
        End If

    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If

        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)

    End Sub


    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        Return IntersectsWith(p, tag, Nothing)
    End Function
    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub




    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        time += 1
        TimeLabel.Text = time

        score -= 1
        ScoreLabel.Text = score
    End Sub


    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        time = 0
        score = 0
        PictureBox2.Visible = True
        PictureBox4.Visible = True
        PictureBox11.Visible = True
        PictureBox13.Visible = True
        PictureBox5.Visible = False
        PictureBox14.Visible = False
        Avatar.Location = New Point(560, 325)
        Tracker.Location = New Point(704, 172)
        Reset.Visible = False
    End Sub


End Class
