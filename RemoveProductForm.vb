Public Class RemoveProductForm

    ' Called when the form loads
    Private Sub RemoveProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelConfirmRemove.Visible = False
        ClearProductDetails()
        btnConfirmRemove.Enabled = False ' Disable confirm initially
    End Sub

    ' When "Search/Remove" button is clicked
    Private Sub RemoveProductBtn_Click(sender As Object, e As EventArgs) Handles RemoveProductBtn.Click
        Dim qrInput As String = txtRemoveProduct.Text.Trim()

        If qrInput = "" Then
            MessageBox.Show("Please enter a QR code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TODO: Replace this with actual DB query logic
        If qrInput = "12345" Then
            ' Simulated product data
            lblProductName.Text = "NAME: Choco Chips"
            lblProductType.Text = "TYPE: Snack"
            lblProductPrice.Text = "PRICE: ₱25.00"
            lblProductQty.Text = "QTY: 100"

            panelConfirmRemove.Visible = True
            btnConfirmRemove.Enabled = True
        Else
            MessageBox.Show("QR code not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            panelConfirmRemove.Visible = False
            ClearProductDetails()
            btnConfirmRemove.Enabled = False
        End If
    End Sub

    ' Cancel button (inside panel)
    Private Sub btnCancelRemove_Click(sender As Object, e As EventArgs) Handles btnCancelRemove.Click
        panelConfirmRemove.Visible = False
        txtRemoveProduct.Clear()
        ClearProductDetails()
        btnConfirmRemove.Enabled = False
    End Sub

    ' Confirm removal button (inside panel)
    Private Sub btnConfirmRemove_Click(sender As Object, e As EventArgs) Handles btnConfirmRemove.Click
        ' TODO: Add database delete command here
        MessageBox.Show("Product has been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        panelConfirmRemove.Visible = False
        txtRemoveProduct.Clear()
        ClearProductDetails()
        btnConfirmRemove.Enabled = False
    End Sub

    ' Helper to clear product detail labels
    Private Sub ClearProductDetails()
        lblProductName.Text = ""
        lblProductType.Text = ""
        lblProductPrice.Text = ""
        lblProductQty.Text = ""
    End Sub

End Class
