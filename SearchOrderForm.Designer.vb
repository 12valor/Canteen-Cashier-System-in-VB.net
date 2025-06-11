<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOrderForm
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
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelOrderDetails = New System.Windows.Forms.Panel()
        Me.lblTotalChange = New System.Windows.Forms.Label()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.lblTotalPayment = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.panelOrderDetails.SuspendLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(153, 37)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderId.TabIndex = 0
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.Location = New System.Drawing.Point(259, 34)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(100, 25)
        Me.btnSearchOrder.TabIndex = 1
        Me.btnSearchOrder.Text = "Search"
        Me.btnSearchOrder.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Order ID:"
        '
        'panelOrderDetails
        '
        Me.panelOrderDetails.Controls.Add(Me.lblTotalChange)
        Me.panelOrderDetails.Controls.Add(Me.dgvOrderDetails)
        Me.panelOrderDetails.Controls.Add(Me.lblTotalPayment)
        Me.panelOrderDetails.Controls.Add(Me.lblOrderTotal)
        Me.panelOrderDetails.Location = New System.Drawing.Point(2, 67)
        Me.panelOrderDetails.Name = "panelOrderDetails"
        Me.panelOrderDetails.Size = New System.Drawing.Size(357, 435)
        Me.panelOrderDetails.TabIndex = 3
        '
        'lblTotalChange
        '
        Me.lblTotalChange.AutoSize = True
        Me.lblTotalChange.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalChange.Location = New System.Drawing.Point(27, 399)
        Me.lblTotalChange.Name = "lblTotalChange"
        Me.lblTotalChange.Size = New System.Drawing.Size(97, 17)
        Me.lblTotalChange.TabIndex = 9
        Me.lblTotalChange.Text = "lblTotalChange"
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOrderDetails.Location = New System.Drawing.Point(19, 20)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersWidth = 51
        Me.dgvOrderDetails.RowTemplate.Height = 24
        Me.dgvOrderDetails.Size = New System.Drawing.Size(335, 313)
        Me.dgvOrderDetails.TabIndex = 0
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = True
        Me.lblTotalPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.Location = New System.Drawing.Point(27, 374)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(105, 17)
        Me.lblTotalPayment.TabIndex = 8
        Me.lblTotalPayment.Text = "lblTotalPayment"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotal.Location = New System.Drawing.Point(27, 349)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(86, 17)
        Me.lblOrderTotal.TabIndex = 7
        Me.lblOrderTotal.Text = "lblOrderTotal"
        '
        'SearchOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(371, 522)
        Me.Controls.Add(Me.panelOrderDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchOrder)
        Me.Controls.Add(Me.txtOrderId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SearchOrderForm"
        Me.Text = "SearchOrderForm"
        Me.panelOrderDetails.ResumeLayout(False)
        Me.panelOrderDetails.PerformLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents btnSearchOrder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents panelOrderDetails As Panel
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents lblTotalPayment As Label
    Friend WithEvents lblTotalChange As Label
End Class
