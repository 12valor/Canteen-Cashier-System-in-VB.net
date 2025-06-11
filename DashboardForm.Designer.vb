<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnShowProducts = New System.Windows.Forms.Button()
        Me.btnSellProduct = New System.Windows.Forms.Button()
        Me.btnSearchOrderId = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProduct.Location = New System.Drawing.Point(39, 49)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(175, 44)
        Me.btnAddProduct.TabIndex = 0
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateProduct.Location = New System.Drawing.Point(247, 49)
        Me.btnUpdateProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(175, 44)
        Me.btnUpdateProduct.TabIndex = 1
        Me.btnUpdateProduct.Text = "Update Product"
        Me.btnUpdateProduct.UseVisualStyleBackColor = False
        '
        'btnShowProducts
        '
        Me.btnShowProducts.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShowProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnShowProducts.Location = New System.Drawing.Point(39, 111)
        Me.btnShowProducts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowProducts.Name = "btnShowProducts"
        Me.btnShowProducts.Size = New System.Drawing.Size(175, 44)
        Me.btnShowProducts.TabIndex = 2
        Me.btnShowProducts.Text = "Show Products"
        Me.btnShowProducts.UseVisualStyleBackColor = False
        '
        'btnSellProduct
        '
        Me.btnSellProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSellProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSellProduct.Location = New System.Drawing.Point(247, 171)
        Me.btnSellProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSellProduct.Name = "btnSellProduct"
        Me.btnSellProduct.Size = New System.Drawing.Size(175, 44)
        Me.btnSellProduct.TabIndex = 5
        Me.btnSellProduct.Text = "Sell Product"
        Me.btnSellProduct.UseVisualStyleBackColor = False
        '
        'btnSearchOrderId
        '
        Me.btnSearchOrderId.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearchOrderId.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchOrderId.Location = New System.Drawing.Point(39, 171)
        Me.btnSearchOrderId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchOrderId.Name = "btnSearchOrderId"
        Me.btnSearchOrderId.Size = New System.Drawing.Size(175, 44)
        Me.btnSearchOrderId.TabIndex = 4
        Me.btnSearchOrderId.Text = "Search Order ID"
        Me.btnSearchOrderId.UseVisualStyleBackColor = False
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoveProduct.Location = New System.Drawing.Point(247, 111)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(175, 44)
        Me.btnRemoveProduct.TabIndex = 3
        Me.btnRemoveProduct.Text = "Remove Product"
        Me.btnRemoveProduct.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(39, 244)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(383, 47)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate Daily Summary"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 354)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnSellProduct)
        Me.Controls.Add(Me.btnSearchOrderId)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.btnShowProducts)
        Me.Controls.Add(Me.btnUpdateProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DashboardForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnShowProducts As Button
    Friend WithEvents btnSellProduct As Button
    Friend WithEvents btnSearchOrderId As Button
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents btnGenerate As Button
End Class
