Public Class DashboardForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim updateForm As New UpdateProductForm()
        updateForm.ShowDialog()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim addForm As New AddProductForm()
        addForm.ShowDialog()
    End Sub

    Private Sub btnShowProducts_Click(sender As Object, e As EventArgs) Handles btnShowProducts.Click
        Dim showForm As New ShowProductsForm()
        showForm.ShowDialog()
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        Dim removeForm As New RemoveProductForm()
        removeForm.ShowDialog()
    End Sub

    Private Sub btnSearchOrderId_Click(sender As Object, e As EventArgs) Handles btnSearchOrderId.Click
        Dim searchForm As New SearchOrderForm()
        searchForm.ShowDialog()
    End Sub

    Private Sub btnSellProduct_Click(sender As Object, e As EventArgs) Handles btnSellProduct.Click
        Dim sellForm As New SellProductForm()
        sellForm.Show()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim summaryForm As New DailySummaryForm()
        summaryForm.ShowDialog()
    End Sub
End Class