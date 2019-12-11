Public Class HospitalCharges
    Private ReadOnly baseCharge As Integer = 350
    Private length As Integer
    Private medication As Double
    Private charge As Double
    Private fees As Double
    Private physical As Double
    Private Function CalcStayCharges()
        Return baseCharge * length
    End Function

    Private Function CalcMiscCharges()
        Return medication + charge + fees + physical
    End Function

    Private Function CalcTotalCharges()
        Return CalcStayCharges() + CalcMiscCharges()
    End Function

    Private Function ValidateInputFields()
        If IsNumeric(txtLength.Text) And IsNumeric(txtMedication.Text) And IsNumeric(txtCharges.Text) And IsNumeric(txtFees.Text) And IsNumeric(txtPhysical.Text) Then
            length = txtLength.Text
            medication = txtMedication.Text
            charge = txtCharges.Text
            fees = txtFees.Text
            physical = txtPhysical.Text
            If length < 0 And medication < 0 And charge < 0 And fees < 0 And physical < 0 Then
                Return False
            End If
        Else
            Return False
        End If

        Return True
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If ValidateInputFields() = False Then
            MessageBox.Show("You entered invalid input!")
            Exit Sub
        End If

        lblTotalCost.Text = CalcTotalCharges()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCharges.Clear()
        txtFees.Clear()
        txtLength.Clear()
        txtMedication.Clear()
        txtPhysical.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class