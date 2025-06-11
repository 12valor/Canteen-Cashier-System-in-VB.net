Public Class SellProductForm
    ' No need for local list anymore
    Private Sub btnNextProduct_Click(sender As Object, e As EventArgs) Handles btnNextProduct.Click
        Dim qr = txtQRInput.Text.Trim()
        Dim qty As Integer

        If qr = "" Or Not Integer.TryParse(txtQtyInput.Text.Trim(), qty) Then
            MessageBox.Show("Please enter a valid QR and quantity.")
            Return
        End If

        Dim unitPrice As Decimal = GetPriceFromQR(qr)
        If unitPrice = 0 Then
            MessageBox.Show("Invalid QR code.")
            Return
        End If

        OrderItemManager.OrderItems.Add(New OrderItem With {
            .ProductName = qr,
            .Quantity = qty,
            .UnitPrice = unitPrice
        })

        txtQRInput.Clear()
        txtQtyInput.Clear()
        txtQRInput.Focus()
    End Sub

    Private Sub btnCalculateOrder_Click(sender As Object, e As EventArgs) Handles btnCalculateOrder.Click
        ' Attempt to add final product (if any input remains)
        Dim qr = txtQRInput.Text.Trim()
        Dim qtyText = txtQtyInput.Text.Trim()
        Dim qty As Integer

        If qr <> "" AndAlso Integer.TryParse(qtyText, qty) AndAlso qty > 0 Then
            Dim unitPrice As Decimal = GetPriceFromQR(qr)
            If unitPrice = 0 Then
                MessageBox.Show("Invalid QR code.")
                Return
            End If

            OrderItemManager.OrderItems.Add(New OrderItem With {
                .ProductName = qr,
                .Quantity = qty,
                .UnitPrice = unitPrice
            })
        End If

        ' 🔥 Final check
        If OrderItemManager.OrderItems Is Nothing OrElse OrderItemManager.OrderItems.Count = 0 Then
            MessageBox.Show("No products added.")
            Return
        End If

        ' ✅ Go to summary
        Dim summaryForm As New OrderSummaryForm()
        summaryForm.Show()
        Me.Hide()
    End Sub

    Private Function GetPriceFromQR(qr As String) As Decimal
        Select Case qr.ToLower()
            Case "juice" : Return 25
            Case "sandwich" : Return 30
            Case Else : Return 0
        End Select
    End Function

    Private Sub SellProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
