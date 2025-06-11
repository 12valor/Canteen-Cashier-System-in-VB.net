<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailySummaryForm
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
        Me.dtpSummaryDate = New System.Windows.Forms.DateTimePicker()
        Me.btnLoadSummary = New System.Windows.Forms.Button()
        Me.dgvSummary = New System.Windows.Forms.DataGridView()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpSummaryDate
        '
        Me.dtpSummaryDate.Location = New System.Drawing.Point(22, 57)
        Me.dtpSummaryDate.Name = "dtpSummaryDate"
        Me.dtpSummaryDate.Size = New System.Drawing.Size(240, 22)
        Me.dtpSummaryDate.TabIndex = 0
        '
        'btnLoadSummary
        '
        Me.btnLoadSummary.Location = New System.Drawing.Point(22, 98)
        Me.btnLoadSummary.Name = "btnLoadSummary"
        Me.btnLoadSummary.Size = New System.Drawing.Size(240, 48)
        Me.btnLoadSummary.TabIndex = 1
        Me.btnLoadSummary.Text = "Load Summary"
        Me.btnLoadSummary.UseVisualStyleBackColor = True
        '
        'dgvSummary
        '
        Me.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSummary.Location = New System.Drawing.Point(291, 57)
        Me.dgvSummary.Name = "dgvSummary"
        Me.dgvSummary.RowHeadersWidth = 51
        Me.dgvSummary.RowTemplate.Height = 24
        Me.dgvSummary.Size = New System.Drawing.Size(632, 239)
        Me.dgvSummary.TabIndex = 2
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(288, 312)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(11, 16)
        Me.lblTotalSales.TabIndex = 4
        Me.lblTotalSales.Text = "-"
        '
        'DailySummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 393)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.dgvSummary)
        Me.Controls.Add(Me.btnLoadSummary)
        Me.Controls.Add(Me.dtpSummaryDate)
        Me.Name = "DailySummaryForm"
        Me.Text = "DailySummaryForm"
        CType(Me.dgvSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpSummaryDate As DateTimePicker
    Friend WithEvents btnLoadSummary As Button
    Friend WithEvents dgvSummary As DataGridView
    Friend WithEvents lblTotalSales As Label
End Class
