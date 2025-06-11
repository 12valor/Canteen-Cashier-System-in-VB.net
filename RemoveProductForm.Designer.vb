<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveProductForm
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
        Me.RemoveProductBtn = New System.Windows.Forms.Button()
        Me.txtRemoveProduct = New System.Windows.Forms.TextBox()
        Me.panelConfirmRemove = New System.Windows.Forms.Panel()
        Me.lblProductQty = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductType = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmRemove = New System.Windows.Forms.Button()
        Me.btnCancelRemove = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelConfirmRemove.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Product QR:"
        '
        'RemoveProductBtn
        '
        Me.RemoveProductBtn.Location = New System.Drawing.Point(31, 104)
        Me.RemoveProductBtn.Name = "RemoveProductBtn"
        Me.RemoveProductBtn.Size = New System.Drawing.Size(232, 41)
        Me.RemoveProductBtn.TabIndex = 1
        Me.RemoveProductBtn.Text = "Remove Product"
        Me.RemoveProductBtn.UseVisualStyleBackColor = True
        '
        'txtRemoveProduct
        '
        Me.txtRemoveProduct.Location = New System.Drawing.Point(163, 62)
        Me.txtRemoveProduct.Name = "txtRemoveProduct"
        Me.txtRemoveProduct.Size = New System.Drawing.Size(100, 22)
        Me.txtRemoveProduct.TabIndex = 2
        '
        'panelConfirmRemove
        '
        Me.panelConfirmRemove.Controls.Add(Me.Label6)
        Me.panelConfirmRemove.Controls.Add(Me.lblProductQty)
        Me.panelConfirmRemove.Controls.Add(Me.lblProductPrice)
        Me.panelConfirmRemove.Controls.Add(Me.lblProductType)
        Me.panelConfirmRemove.Controls.Add(Me.lblProductName)
        Me.panelConfirmRemove.Controls.Add(Me.Label5)
        Me.panelConfirmRemove.Controls.Add(Me.Label4)
        Me.panelConfirmRemove.Controls.Add(Me.Label3)
        Me.panelConfirmRemove.Controls.Add(Me.Label2)
        Me.panelConfirmRemove.Controls.Add(Me.btnConfirmRemove)
        Me.panelConfirmRemove.Controls.Add(Me.btnCancelRemove)
        Me.panelConfirmRemove.Location = New System.Drawing.Point(31, 170)
        Me.panelConfirmRemove.Name = "panelConfirmRemove"
        Me.panelConfirmRemove.Size = New System.Drawing.Size(258, 268)
        Me.panelConfirmRemove.TabIndex = 3
        '
        'lblProductQty
        '
        Me.lblProductQty.AutoSize = True
        Me.lblProductQty.Location = New System.Drawing.Point(144, 179)
        Me.lblProductQty.Name = "lblProductQty"
        Me.lblProductQty.Size = New System.Drawing.Size(87, 16)
        Me.lblProductQty.TabIndex = 9
        Me.lblProductQty.Text = "lblProductQty"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(144, 147)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(98, 16)
        Me.lblProductPrice.TabIndex = 8
        Me.lblProductPrice.Text = "lblProductPrice"
        '
        'lblProductType
        '
        Me.lblProductType.AutoSize = True
        Me.lblProductType.Location = New System.Drawing.Point(144, 116)
        Me.lblProductType.Name = "lblProductType"
        Me.lblProductType.Size = New System.Drawing.Size(99, 16)
        Me.lblProductType.TabIndex = 7
        Me.lblProductType.Text = "lblProductType"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(144, 85)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(104, 16)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "lblProductName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Product Qty:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        '
        'btnConfirmRemove
        '
        Me.btnConfirmRemove.Location = New System.Drawing.Point(134, 233)
        Me.btnConfirmRemove.Name = "btnConfirmRemove"
        Me.btnConfirmRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmRemove.TabIndex = 1
        Me.btnConfirmRemove.Text = "Confirm"
        Me.btnConfirmRemove.UseVisualStyleBackColor = True
        '
        'btnCancelRemove
        '
        Me.btnCancelRemove.Location = New System.Drawing.Point(19, 233)
        Me.btnCancelRemove.Name = "btnCancelRemove"
        Me.btnCancelRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelRemove.TabIndex = 0
        Me.btnCancelRemove.Text = "Cancel"
        Me.btnCancelRemove.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PRODUCT DETAILS"
        '
        'SubRemoveProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 450)
        Me.Controls.Add(Me.panelConfirmRemove)
        Me.Controls.Add(Me.txtRemoveProduct)
        Me.Controls.Add(Me.RemoveProductBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SubRemoveProductForm"
        Me.Text = "SubRemoveProductsForm"
        Me.panelConfirmRemove.ResumeLayout(False)
        Me.panelConfirmRemove.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RemoveProductBtn As Button
    Friend WithEvents txtRemoveProduct As TextBox
    Friend WithEvents panelConfirmRemove As Panel
    Friend WithEvents btnConfirmRemove As Button
    Friend WithEvents btnCancelRemove As Button
    Friend WithEvents lblProductQty As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductType As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
