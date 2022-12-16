Public Class Form1
    Dim Ore, Minuti, Secondi As Integer

    Private Sub BtnStart_Click(sender As System.Object, e As System.EventArgs) Handles BtnStart.Click
        Timer1.Start()
    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click
        Timer1.Stop()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Secondi < 59 Then
            Secondi = Secondi + 1
            LblSecondi.Text = Secondi
        Else
            Secondi = 0
            LblSecondi.Text = Secondi
            If Minuti < 59 Then
                Minuti = Minuti + 1
                LblMinuti.Text = Minuti
            Else
                Minuti = 0
                LblMinuti.Text = Minuti
                If Ore < 23 Then
                    Ore = Ore + 1
                    LblOre.Text = Ore
                End If
            End If
        End If
    End Sub
End Class
