﻿Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "chimica sostanza che in soluzione libera ioni idrogeno Maschile Acido Plurale Acidi"

        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile,geologia (specialmente con iniziale maiuscola) piano del Giurassico inferiore tipicamente rappresentato nelle marne e nei calcari ferruginosi del bacino di Parigi"

        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile e femminile, (obsoleto) contabile, esperto di calcoli, Plurale Abachisti o Abachiste"

        End Select
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = Int(Rnd() * 2)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile, antico pallottoliere o altro primitivo strumento per far di conto,"
            Case 1
                TextBox1.Text = "il coronamento del capitello della colonna negli ordini architettonici classici; per analogia, la parte terminale superiore di mensole e balaustre"


        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile, famigliare padre Maschile Plurale Babbi"


        End Select
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo femminile, calzatura turca dal calcagno alto, scarpetta da casa di stoffa o pelle morbida, Plurale Babbucce"




        End Select
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile, zoologia scimmia africana addomesticabile, con muso canino, pelame verdognolo, coda lunga, occhi cerchiati di chiaro (famiglia: Cercopitecidi), in senso figurato persona sciocca, Plurale Babbuini"



        End Select
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "participio passato di Cabalare e aggettivo"

        End Select
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = Int(Rnd() * 1)
        Select Case TextBox1.Text
            Case 0
                TextBox1.Text = "sostantivo maschile, francese locale notturno con spettacoli di varietà"

        End Select
    End Sub
End Class

