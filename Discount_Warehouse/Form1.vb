'Joshua Pickenpaugh
'October 26th, 2016
'List box discounts, module use, format return from module to currency.

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the app:
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the txt and lbl:
        txtPrice.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populates the list box with discount amounts:
        lstDiscount.Items.Add("10")
        lstDiscount.Items.Add("15")
        lstDiscount.Items.Add("20")
        lstDiscount.Items.Add("25")
        lstDiscount.Items.Add("30")
        lstDiscount.Items.Add("35")
        lstDiscount.Items.Add("40")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Variables for user input:
        Dim decAmount As Decimal
        Dim decDiscount As Decimal

        'Parse user input to decimal-type:
        Decimal.TryParse(txtPrice.Text, decAmount)
        Decimal.TryParse(lstDiscount.SelectedItem.ToString, decDiscount)

        'Calculates and displays:
        lblTotal.Text = Format(GetTotal(decAmount, decDiscount), "Currency")
    End Sub
End Class
