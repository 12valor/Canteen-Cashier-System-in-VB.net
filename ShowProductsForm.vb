Public Class ShowProductsForm

    Private Sub ShowProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMockData()
    End Sub

    Private Sub LoadMockData()
        Dim dt As New DataTable()

        dt.Columns.Add("QR Code")
        dt.Columns.Add("Product Name")
        dt.Columns.Add("Price")
        dt.Columns.Add("Type")
        dt.Columns.Add("Quantity")

        dt.Rows.Add("QR001", "Choco Chips", "25.00", "Snack", "100")
        dt.Rows.Add("QR002", "Mineral Water", "15.00", "Drink", "200")
        dt.Rows.Add("QR003", "Notebook", "45.00", "School Supply", "50")

        dvgProducts.DataSource = dt
    End Sub

    ' Optional: Handle clicks in DataGridView rows (e.g. future edit/delete)
    Private Sub dvgProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgProducts.CellContentClick
        ' Example: get selected QR code
        If e.RowIndex >= 0 Then
            Dim selectedQR As String = dvgProducts.Rows(e.RowIndex).Cells("QR Code").Value.ToString()
            MessageBox.Show("You clicked on QR: " & selectedQR)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
