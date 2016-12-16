Public Class asteroide

    Dim vBxy(9, 2) As Integer
    Dim vAxy(9, 2) As Integer
    Dim btmp As PictureBox
    Dim atmp As PictureBox
    Dim rnd As New Random()
    Dim VectorBasura(9) As PictureBox
    Dim VectorAsteroide(9) As PictureBox
    Dim suma As Integer = 0
    Public Property X As Integer = 0
    Public Property Y As Integer = 0

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        btnIniciar.Visible = False
        Cohete.Visible = True

        TimerCohete.Enabled = True
        TimerBasura.Enabled = True
        TimerAsteroide.Enabled = True

    End Sub

    Sub Timer1Tick(sender As Object, e As EventArgs)
        Dim rnd As Random

        Cohete.Location = New Point(Cohete.Location.X + X, Cohete.Location.Y + Y)
        If Cohete.Bounds.IntersectsWith(btnIniciar.Bounds) Then
            TimerCohete.Enabled = False
        End If
        If Cohete.Location.X <= 0 Then
            Cohete.Location = New Point(0, Cohete.Location.Y)
            X = -X
        End If
        If Cohete.Location.Y <= 0 Then
            Cohete.Location = New Point(0, Cohete.Location.Y)
            Y = -Y
        End If

    End Sub

    Sub form_Key(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        MessageBox.Show("tecla: " + e.KeyChar.ToString())
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                'MessageBox.Show ("Arriba")
                Y -= 1
            Case Keys.Down
                'MessageBox.Show ("Abajo")
                Y += 1
            Case Keys.Left
                'MessageBox.Show ("Abajo")
                X -= 1
            Case Keys.Right
                'MessageBox.Show ("Abajo")
                X += 1
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function



End Class
