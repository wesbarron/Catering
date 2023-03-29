'Program: Catering - Wesley Barron
'Purpose: To Calculate the cost of a party platter with a loyalty points program.

Option Strict On
Option Explicit On

Public Class frmCatering
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxPoints.Text = ""
        txtBoxPoints.Focus()
        lblTotal.Text = ""
        radBtnGourmet.Checked = True
        radBtnPinwheel.Checked = False
        radBtnVeggie.Checked = False
        radBtnSausage.Checked = False
        radBtnFruit.Checked = False
        radBtnPrePay.Checked = True
        radBtnPayPickup.Checked = False
    End Sub

    Private Sub frmCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtBoxPoints.Text) Then
            intPoints = Convert.ToInt32(txtBoxPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            MsgBox(intPoints)

            If radBtnGourmet.Checked Then
                decCost = 49.99D
                strOrder = "Gourmet Cheese"
            ElseIf radBtnPinwheel.Checked Then
                decCost = 59.99D
                strOrder = "Pinwheel Wrap"
            ElseIf radBtnVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radBtnSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radBtnFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radBtnPrePay.Checked Then
                strPay = " using" & vbCrLf & "Pre-Pay"
            ElseIf radBtnPayPickup.Checked Then
                strPay = " with" & vbCrLf & "Pay upon Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            MsgBox(intPoints)

            decPoints = (intPoints * cdecDiscount) / 100
            MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFinal = decCost * (1 - decPoints)
            MsgBox(decFinal)

            lblTotal.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()

        End If
    End Sub
End Class
