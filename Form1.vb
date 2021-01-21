Public Class Form1

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'step 1:declare variables
        Dim bagels As Integer
        Dim cost As Double
        Const price1 As Double = 0.85
        Const price2 As Double = 0.6
        'step 2:
        bagels = CInt(txtBagels.Text)
        'setp 3: making calculations using if...else
        If bagels < 10 Then 'if bagels= 0=9
            cost = price1 * bagels
            lblPrice.Text = CStr(price1)
        Else 'if bagels=10+
            cost = price2 * bagels
            lblPrice.Text = CStr(price2)
        End If
        lblCost.Text = CStr(cost)
    End Sub
End Class
