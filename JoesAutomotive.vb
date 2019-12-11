Public Class JoesAutomotive
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If validateInput() = False Then
            MessageBox.Show("You entered invalid input!")
            Exit Sub
        End If

        lblTotalFees.Text = TotalCharges()
        lblParts.Text = txtParts.Text
        lblServicesLabor.Text = txtLabor.Text
        lblTax.Text = TaxCharges()

    End Sub

    Private Function validateInput()
        If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) Then
            If txtLabor.Text < 0 And txtParts.Text < 0 Then
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Private Function OilLubeCharges()
        Dim temp As Integer = 0
        temp += If(chkOil.Checked, 25, 0)
        temp += If(chkLube.Checked, 18, 0)
        Return temp
    End Function

    Private Function FlushCharges()
        Dim temp As Integer = 0
        temp += If(chkRadiator.Checked, 30, 0)
        temp += If(chkTransmission.Checked, 20, 0)
        Return temp
    End Function

    Private Function MiscCharges()
        Dim temp As Integer = 0
        temp += If(chkInspection.Checked, 15, 0)
        temp += If(chkReplaceMuffer.Checked, 100, 0)
        temp += If(chkTire.Checked, 20, 0)
        Return temp
    End Function

    Private Function OtherCharges()
        Dim temp As Double = 0
        temp += CDbl(txtLabor.Text)
        temp += CDbl(txtParts.Text)
        Return temp
    End Function
    Private Function TaxCharges()
        Return 6 / 100 * CDbl(txtParts.Text)
    End Function
    Private Function TotalCharges()
        Return FlushCharges() + TaxCharges() + OilLubeCharges() + MiscCharges() + OtherCharges()
    End Function
    Private Sub ClearOilLube()
        For Each chkBoxObj In Me.grpOil.Controls
            If TypeOf chkBoxObj Is CheckBox Then
                Dim chkBox As CheckBox = chkBoxObj
                chkBox.Checked = False
            End If

        Next
    End Sub

    Private Sub ClearFlushes()
        For Each chkBoxObj In Me.grpFlushes.Controls
            If TypeOf chkBoxObj Is CheckBox Then
                Dim chkBox As CheckBox = chkBoxObj
                chkBox.Checked = False
            End If

        Next
    End Sub

    Private Sub ClearMisc()
        For Each chkBoxObj In Me.grpMisc.Controls
            If TypeOf chkBoxObj Is CheckBox Then
                Dim chkBox As CheckBox = chkBoxObj
                chkBox.Checked = False
            End If

        Next
    End Sub

    Private Sub ClearOther()
        txtLabor.Clear()
        txtLabor.Clear()

    End Sub

    Private Sub ClearFees()
        lblParts.Text = ""
        lblServicesLabor.Text = ""
        lblTax.Text = ""
        lblTotalFees.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFees()
        ClearFlushes()
        ClearMisc()
        ClearOilLube()
        ClearOther()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class