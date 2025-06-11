<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellProductForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQRInput = New System.Windows.Forms.TextBox()
        Me.txtQtyInput = New System.Windows.Forms.TextBox()
        Me.btnNextProduct = New System.Windows.Forms.Button()
        Me.btnCalculateOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(54, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Product QR:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Product Quantity:"
        '
        'txtQRInput
        '
        Me.txtQRInput.Location = New System.Drawing.Point(211, 31)
        Me.txtQRInput.Name = "txtQRInput"
        Me.txtQRInput.Size = New System.Drawing.Size(100, 22)
        Me.txtQRInput.TabIndex = 2
        '
        'txtQtyInput
        '
        Me.txtQtyInput.Location = New System.Drawing.Point(210, 77)
        Me.txtQtyInput.Name = "txtQtyInput"
        Me.txtQtyInput.Size = New System.Drawing.Size(100, 22)
        Me.txtQtyInput.TabIndex = 3
        '
        'btnNextProduct
        '
        Me.btnNextProduct.Location = New System.Drawing.Point(57, 131)
        Me.btnNextProduct.Name = "btnNextProduct"
        Me.btnNextProduct.Size = New System.Drawing.Size(111, 41)
        Me.btnNextProduct.TabIndex = 4
        Me.btnNextProduct.Text = "Next"
        Me.btnNextProduct.UseVisualStyleBackColor = True
        '
        'btnCalculateOrder
        '
        Me.btnCalculateOrder.Location = New System.Drawing.Point(199, 131)
        Me.btnCalculateOrder.Name = "btnCalculateOrder"
        Me.btnCalculateOrder.Size = New System.Drawing.Size(111, 41)
        Me.btnCalculateOrder.TabIndex = 5
        Me.btnCalculateOrder.Text = "Calculate"
        Me.btnCalculateOrder.UseVisualStyleBackColor = True
        '
        'SellProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 204)
        Me.Controls.Add(Me.btnCalculateOrder)
        Me.Controls.Add(Me.btnNextProduct)
        Me.Controls.Add(Me.txtQtyInput)
        Me.Controls.Add(Me.txtQRInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SellProductForm"
        Me.Text = "SellProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQRInput As TextBox
    Friend WithEvents txtQtyInput As TextBox
    Friend WithEvents btnNextProduct As Button
    Friend WithEvents btnCalculateOrder As Button
End Class
