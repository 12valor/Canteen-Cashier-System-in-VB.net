<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProductForm
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
        Me.updQr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updFormBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UPDATE PRODUCT"
        '
        'updQr
        '
        Me.updQr.Location = New System.Drawing.Point(148, 66)
        Me.updQr.Name = "updQr"
        Me.updQr.Size = New System.Drawing.Size(141, 22)
        Me.updQr.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "QR Code:"
        '
        'updFormBtn
        '
        Me.updFormBtn.Location = New System.Drawing.Point(148, 141)
        Me.updFormBtn.Name = "updFormBtn"
        Me.updFormBtn.Size = New System.Drawing.Size(75, 23)
        Me.updFormBtn.TabIndex = 8
        Me.updFormBtn.Text = "Enter"
        Me.updFormBtn.UseVisualStyleBackColor = True
        '
        'UpdateProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 218)
        Me.Controls.Add(Me.updFormBtn)
        Me.Controls.Add(Me.updQr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateProductForm"
        Me.Text = "UpdateProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents updQr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents updFormBtn As Button
End Class
