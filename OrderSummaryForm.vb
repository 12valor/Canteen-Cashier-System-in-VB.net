Public Class OrderSummaryForm
    ' Remove the local OrderItems list
    Private totalOrderPrice As Decimal
    Private orderId As String
    Private purchaseDate As DateTime = DateTime.Now

    Private Sub OrderSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOrderDetails.Visible = False
        dgvOrderDetails.Rows.Clear()
        dgvOrderDetails.Columns.Clear()

        ' Generate unique order ID
        orderId = "ORD" & DateTime.Now.ToString("yyyyMMddHHmmss")

        ' Use the shared OrderItems list
        If OrderItemManager.OrderItems Is Nothing OrElse OrderItemManager.OrderItems.Count = 0 Then
            MessageBox.Show("No order items provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        totalOrderPrice = OrderItemManager.OrderItems.Sum(Function(item) item.Quantity * item.UnitPrice)
        lblTotalOrderPrice.Text = $"Total Price: ₱{totalOrderPrice:0.00}"

        ' Setup DataGridView
        With dgvOrderDetails
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .Columns.Add("OrderID", "Order ID")
            .Columns.Add("ProductName", "Product")
            .Columns.Add("Quantity", "Qty")
            .Columns.Add("UnitPrice", "Price per Item")
            .Columns.Add("TotalPerProduct", "Total per Product")
            .Columns.Add("PurchaseDate", "Purchase Date")
        End With
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        Dim paymentAmount As Decimal

        If Not Decimal.TryParse(txtPayment.Text, paymentAmount) OrElse paymentAmount < totalOrderPrice Then
            MessageBox.Show("Please enter a valid payment amount (must be at least the total price).", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim change = paymentAmount - totalOrderPrice

        ' Fill DataGridView with actual data
        dgvOrderDetails.Rows.Clear()
        For Each item In OrderItemManager.OrderItems
            dgvOrderDetails.Rows.Add(
                orderId,
                item.ProductName,
                item.Quantity,
                $"₱{item.UnitPrice:0.00}",
                $"₱{item.Quantity * item.UnitPrice:0.00}",
                purchaseDate.ToString("yyyy-MM-dd HH:mm:ss")
            )
        Next

        dgvOrderDetails.Visible = True

        lblPayment.Text = $"PAYMENT: ₱{paymentAmount:0.00}"
        lblChange.Text = $"CHANGE: ₱{change:0.00}"
    End Sub
End Class
