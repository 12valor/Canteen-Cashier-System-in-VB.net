Public Class AddProductForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        'variables
        Dim qrCode As String = txtQR.Text.Trim()
        Dim productName As String = txtName.Text.Trim()
        Dim productType As String = txtType.Text.Trim()
        Dim quantity As String = txtQty.Text.Trim()
        'pang format
        Dim message As String = "Product Details:" & vbCrLf &
                                "QR Code: " & qrCode & vbCrLf &
                                "Product Name: " & productName & vbCrLf &
                                "Product Type: " & productType & vbCrLf &
                                "Quantity: " & quantity
        'msgbox
        MessageBox.Show(message, "Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class