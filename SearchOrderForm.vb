Public Class SearchOrderForm
    Private Sub SearchOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelOrderDetails.Visible = False

        ' Setup DataGridView
        dgvOrderDetails.Columns.Clear()
        dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOrderDetails.RowHeadersVisible = False
        dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgvOrderDetails.Columns.Add("Product", "Product")
        dgvOrderDetails.Columns.Add("Quantity", "Qty")
        dgvOrderDetails.Columns.Add("UnitPrice", "Unit Price")
        dgvOrderDetails.Columns.Add("Total", "Total Price")
    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        Dim orderId As String = txtOrderId.Text.Trim()

        If orderId = "" Then
            MessageBox.Show("Please enter an Order ID.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Clear previous results
        dgvOrderDetails.Rows.Clear()

        ' Simulated result for Order ID "ORD123"
        If orderId = "ORD123" Then
            ' Add example rows
            dgvOrderDetails.Rows.Add("Jerow", "2", "25", "50")
            dgvOrderDetails.Rows.Add("Shedrack", "1", "15", "15")
            dgvOrderDetails.Rows.Add("Byron", "3", "30", "90")

            ' Compute total
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvOrderDetails.Rows
                total += Convert.ToDecimal(row.Cells("Total").Value)
            Next

            lblOrderTotal.Text = "Order Total: ₱" & total.ToString("0.00")
            lblTotalPayment.Text = "Payment: ₱200"
            lblTotalChange.Text = "Change: ₱" & (200 - total).ToString("0.00")

            panelOrderDetails.Visible = True
        Else
            MessageBox.Show("Order ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            panelOrderDetails.Visible = False
        End If
    End Sub
End Class
