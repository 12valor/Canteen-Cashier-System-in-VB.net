Public Class DailySummaryForm

    ' Sample OrderItem class for mock data
    Public Class OrderItem
        Public Property OrderID As String
        Public Property ProductName As String
        Public Property Quantity As Integer
        Public Property UnitPrice As Decimal
        Public Property PurchaseDate As Date
    End Class

    Private mockOrders As New List(Of OrderItem)

    Private Sub DailySummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup columns only once
        SetupSummaryTable()

        ' Add mock data
        mockOrders = New List(Of OrderItem) From {
            New OrderItem With {.OrderID = "ORD001", .ProductName = "Juice", .Quantity = 2, .UnitPrice = 25, .PurchaseDate = #6/9/2025#},
            New OrderItem With {.OrderID = "ORD002", .ProductName = "Sandwich", .Quantity = 1, .UnitPrice = 30, .PurchaseDate = #6/9/2025#},
            New OrderItem With {.OrderID = "ORD003", .ProductName = "Juice", .Quantity = 3, .UnitPrice = 25, .PurchaseDate = #6/11/2025#},
            New OrderItem With {.OrderID = "ORD004", .ProductName = "Water", .Quantity = 1, .UnitPrice = 15, .PurchaseDate = #6/11/2025#}
        }
    End Sub

    Private Sub SetupSummaryTable()
        dgvSummary.Rows.Clear()
        dgvSummary.Columns.Clear()
        dgvSummary.Columns.Add("OrderID", "Order ID")
        dgvSummary.Columns.Add("ProductName", "Product")
        dgvSummary.Columns.Add("Quantity", "Qty")
        dgvSummary.Columns.Add("UnitPrice", "Price per Item")
        dgvSummary.Columns.Add("TotalPerProduct", "Total")
    End Sub

    Private Sub LoadSummaryForDate(selectedDate As Date)
        dgvSummary.Rows.Clear()

        Dim filteredOrders = mockOrders.Where(Function(o) o.PurchaseDate.Date = selectedDate).ToList()
        Dim totalSales As Decimal = 0

        For Each order In filteredOrders
            Dim total = order.Quantity * order.UnitPrice
            dgvSummary.Rows.Add(
                order.OrderID,
                order.ProductName,
                order.Quantity,
                "₱" & order.UnitPrice.ToString("0.00"),
                "₱" & total.ToString("0.00")
            )
            totalSales += total
        Next

        lblTotalSales.Text = "Total Sales: ₱" & totalSales.ToString("0.00")
    End Sub

    Private Sub btnLoadSummary_Click(sender As Object, e As EventArgs) Handles btnLoadSummary.Click
        LoadSummaryForDate(dtpSummaryDate.Value.Date)
    End Sub

End Class
