﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hospital As New HospitalCharges
        hospital.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim joe As New JoesAutomotive
        joe.Show()
    End Sub
End Class
