Public Class Form1
    Dim second As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        second = second + 1
        If second = 1 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 2 Then
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            UpperMid.BackColor = SystemColors.Control
            UpperLeft.BackColor = SystemColors.Control

        ElseIf second = 3 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerRight.BackColor = SystemColors.Control

        ElseIf second = 4 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 5 Then
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 6 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            UpperRight.BackColor = SystemColors.Control

        ElseIf second = 7 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red

        ElseIf second = 8 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperLeft.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 9 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 10 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 11 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = SystemColors.Control
            UpperRight.BackColor = Color.Red

        ElseIf second = 12 Then
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            UpperLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 13 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerRight.BackColor = SystemColors.Control


        ElseIf second = 14 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 15 Then
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 16 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            UpperRight.BackColor = SystemColors.Control

        ElseIf second = 17 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red

        ElseIf second = 18 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperLeft.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 19 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 20 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 21 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = SystemColors.Control
            UpperRight.BackColor = Color.Red

        ElseIf second = 22 Then
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            UpperLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 23 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerRight.BackColor = SystemColors.Control


        ElseIf second = 24 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 25 Then
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 26 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            UpperRight.BackColor = SystemColors.Control

        ElseIf second = 27 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red

        ElseIf second = 28 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperLeft.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 29 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 30 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 31 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = SystemColors.Control
            UpperRight.BackColor = Color.Red

        ElseIf second = 32 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = SystemColors.Control
            UpperRight.BackColor = Color.Red

        ElseIf second = 33 Then
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            UpperLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 34 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerRight.BackColor = SystemColors.Control


        ElseIf second = 35 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = SystemColors.Control

        ElseIf second = 36 Then
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperMid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 37 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            UpperRight.BackColor = SystemColors.Control

        ElseIf second = 38 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red

        ElseIf second = 39 Then
            UpperMid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            UpperLeft.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = SystemColors.Control
            LowerMid.BackColor = SystemColors.Control

        ElseIf second = 40 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = Color.Red
            LowerLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        ElseIf second = 41 Then
            UpperMid.BackColor = Color.Red
            UpperLeft.BackColor = Color.Red
            Mid.BackColor = Color.Red
            LowerRight.BackColor = Color.Red
            LowerMid.BackColor = SystemColors.Control
            LowerLeft.BackColor = SystemColors.Control
            Mid.BackColor = Color.Red
            UpperRight.BackColor = Color.Red

        End If

    End Sub
End Class
