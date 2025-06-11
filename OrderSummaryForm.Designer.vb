<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSummaryForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.PanelOrderDetails = New System.Windows.Forms.Panel()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.lblTotalOrderPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.PanelOrderDetails.SuspendLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Payment:"
        '
        'txtPayment
        '
        Me.txtPayment.AcceptsReturn = True
        Me.txtPayment.Location = New System.Drawing.Point(131, 21)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(100, 22)
        Me.txtPayment.TabIndex = 3
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.Location = New System.Drawing.Point(30, 88)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(201, 23)
        Me.btnConfirmPayment.TabIndex = 4
        Me.btnConfirmPayment.Text = "Confirm Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'PanelOrderDetails
        '
        Me.PanelOrderDetails.Controls.Add(Me.lblChange)
        Me.PanelOrderDetails.Controls.Add(Me.lblPayment)
        Me.PanelOrderDetails.Controls.Add(Me.dgvOrderDetails)
        Me.PanelOrderDetails.Location = New System.Drawing.Point(30, 117)
        Me.PanelOrderDetails.Name = "PanelOrderDetails"
        Me.PanelOrderDetails.Size = New System.Drawing.Size(546, 494)
        Me.PanelOrderDetails.TabIndex = 5
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetails.Location = New System.Drawing.Point(0, 16)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.RowHeadersWidth = 51
        Me.dgvOrderDetails.RowTemplate.Height = 24
        Me.dgvOrderDetails.Size = New System.Drawing.Size(532, 342)
        Me.dgvOrderDetails.TabIndex = 0
        '
        'lblTotalOrderPrice
        '
        Me.lblTotalOrderPrice.AutoSize = True
        Me.lblTotalOrderPrice.Location = New System.Drawing.Point(114, 60)
        Me.lblTotalOrderPrice.Name = "lblTotalOrderPrice"
        Me.lblTotalOrderPrice.Size = New System.Drawing.Size(117, 16)
        Me.lblTotalOrderPrice.TabIndex = 6
        Me.lblTotalOrderPrice.Text = "lblTotalOrderPrice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Price:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(20, 381)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(74, 16)
        Me.lblPayment.TabIndex = 1
        Me.lblPayment.Text = "lblPayment"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(24, 411)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(68, 16)
        Me.lblChange.TabIndex = 2
        Me.lblChange.Text = "lblChange"
        '
        'OrderSummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 668)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalOrderPrice)
        Me.Controls.Add(Me.PanelOrderDetails)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label2)
        Me.Name = "OrderSummaryForm"
        Me.Text = "OrderSummaryForm"
        Me.PanelOrderDetails.ResumeLayout(False)
        Me.PanelOrderDetails.PerformLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents PanelOrderDetails As Panel
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents lblTotalOrderPrice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblPayment As Label
End Class
