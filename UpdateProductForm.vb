Public Class UpdateProductForm

    Private Sub updFormBtn_Click(sender As Object, e As EventArgs) Handles updFormBtn.Click
        Dim qrCode As String = updQr.Text.Trim()

        'check
        If qrCode = " " Then
            MessageBox.Show("Enter Valid QR Code.", "Input Needed", MessageBoxButtons.OK)
        End If
        'open SubUpdateProductForm and pass QR
        Dim SubForm As New SubUpdateProductsForm(qrCode)
        SubForm.ShowDialog()

    End Sub

    Private Sub UpdateProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class