<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubUpdateProductsForm
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
        Me.updName = New System.Windows.Forms.TextBox()
        Me.updPrice = New System.Windows.Forms.TextBox()
        Me.updType = New System.Windows.Forms.TextBox()
        Me.updQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updProductFinal = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOldPrice = New System.Windows.Forms.Label()
        Me.lblOldType = New System.Windows.Forms.Label()
        Me.lblOldQty = New System.Windows.Forms.Label()
        Me.lblOldName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'updName
        '
        Me.updName.Location = New System.Drawing.Point(373, 47)
        Me.updName.Name = "updName"
        Me.updName.Size = New System.Drawing.Size(100, 22)
        Me.updName.TabIndex = 0
        '
        'updPrice
        '
        Me.updPrice.Location = New System.Drawing.Point(373, 96)
        Me.updPrice.Name = "updPrice"
        Me.updPrice.Size = New System.Drawing.Size(100, 22)
        Me.updPrice.TabIndex = 1
        '
        'updType
        '
        Me.updType.Location = New System.Drawing.Point(373, 139)
        Me.updType.Name = "updType"
        Me.updType.Size = New System.Drawing.Size(100, 22)
        Me.updType.TabIndex = 2
        '
        'updQty
        '
        Me.updQty.Location = New System.Drawing.Point(373, 180)
        Me.updQty.Name = "updQty"
        Me.updQty.Size = New System.Drawing.Size(100, 22)
        Me.updQty.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NEW NAME:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NEW PRICE:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NEW TYPE:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(268, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "NEW QTY:"
        '
        'updProductFinal
        '
        Me.updProductFinal.Location = New System.Drawing.Point(327, 229)
        Me.updProductFinal.Name = "updProductFinal"
        Me.updProductFinal.Size = New System.Drawing.Size(146, 30)
        Me.updProductFinal.TabIndex = 8
        Me.updProductFinal.Text = "Update"
        Me.updProductFinal.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(30, 47)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(99, 20)
        Me.label.TabIndex = 9
        Me.label.Text = "OLD NAME:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "OLD PRICE:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "OLD TYPE:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "OLD QTY:"
        '
        'lblOldPrice
        '
        Me.lblOldPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPrice.Location = New System.Drawing.Point(135, 93)
        Me.lblOldPrice.Name = "lblOldPrice"
        Me.lblOldPrice.Size = New System.Drawing.Size(109, 20)
        Me.lblOldPrice.TabIndex = 14
        Me.lblOldPrice.Text = "lblOldPrice"
        '
        'lblOldType
        '
        Me.lblOldType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldType.Location = New System.Drawing.Point(135, 139)
        Me.lblOldType.Name = "lblOldType"
        Me.lblOldType.Size = New System.Drawing.Size(109, 20)
        Me.lblOldType.TabIndex = 15
        Me.lblOldType.Text = "lblOldType"
        '
        'lblOldQty
        '
        Me.lblOldQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldQty.Location = New System.Drawing.Point(135, 182)
        Me.lblOldQty.Name = "lblOldQty"
        Me.lblOldQty.Size = New System.Drawing.Size(109, 20)
        Me.lblOldQty.TabIndex = 16
        Me.lblOldQty.Text = "lblOldQty"
        '
        'lblOldName
        '
        Me.lblOldName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldName.Location = New System.Drawing.Point(135, 44)
        Me.lblOldName.Name = "lblOldName"
        Me.lblOldName.Size = New System.Drawing.Size(109, 20)
        Me.lblOldName.TabIndex = 17
        Me.lblOldName.Text = "lblOldName"
        '
        'SubUpdateProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 305)
        Me.Controls.Add(Me.lblOldName)
        Me.Controls.Add(Me.lblOldQty)
        Me.Controls.Add(Me.lblOldType)
        Me.Controls.Add(Me.lblOldPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.updProductFinal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.updQty)
        Me.Controls.Add(Me.updType)
        Me.Controls.Add(Me.updPrice)
        Me.Controls.Add(Me.updName)
        Me.Name = "SubUpdateProductsForm"
        Me.Text = "SubUpdateProductsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updName As TextBox
    Friend WithEvents updPrice As TextBox
    Friend WithEvents updType As TextBox
    Friend WithEvents updQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents updProductFinal As Button
    Friend WithEvents label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOldPrice As Label
    Friend WithEvents lblOldType As Label
    Friend WithEvents lblOldQty As Label
    Friend WithEvents lblOldName As Label
End Class
