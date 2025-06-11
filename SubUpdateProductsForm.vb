Public Class SubUpdateProductsForm
    Private qrCodeValue As String

    ' Constructor that accepts QR Code
    Public Sub New(qrCode As String)
        InitializeComponent()
        qrCodeValue = qrCode
    End Sub

    Private Sub SubUpdateProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pretend you pulled this from a database using qrCodeValue
        lblOldName.Text = "Choco Chips"
        lblOldPrice.Text = "25.00"
        lblOldType.Text = "Snack"
        lblOldQty.Text = "150"

        ' Optionally copy values to textboxes too
        updName.Text = lblOldName.Text
        updPrice.Text = lblOldPrice.Text
        updType.Text = lblOldType.Text
        updQty.Text = lblOldQty.Text
    End Sub

    Private Sub updProductFinal_Click(sender As Object, e As EventArgs) Handles updProductFinal.Click
        Dim newName As String = updName.Text.Trim()
        Dim newPrice As String = updPrice.Text.Trim()
        Dim newType As String = updType.Text.Trim()
        Dim newQty As String = updQty.Text.Trim()

        ' Display all entered data (you'll replace this with SQL UPDATE later)
        Dim result As String = "QR Code: " & qrCodeValue & vbCrLf &
                               "New Name: " & newName & vbCrLf &
                               "New Price: " & newPrice & vbCrLf &
                               "New Type: " & newType & vbCrLf &
                               "New Quantity: " & newQty

        MessageBox.Show(result, "Updated Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Later: add SQL UPDATE here
    End Sub

End Class
