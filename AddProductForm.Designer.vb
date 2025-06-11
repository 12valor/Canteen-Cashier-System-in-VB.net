<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQR = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.AddProductButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD PRODUCT FORM"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QR Code:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PR Name:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PR Type:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 42)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PR QTY:"
        '
        'txtQR
        '
        Me.txtQR.Location = New System.Drawing.Point(127, 51)
        Me.txtQR.Name = "txtQR"
        Me.txtQR.Size = New System.Drawing.Size(141, 22)
        Me.txtQR.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 22)
        Me.txtName.TabIndex = 6
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(127, 139)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(141, 22)
        Me.txtType.TabIndex = 7
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(127, 181)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(141, 22)
        Me.txtQty.TabIndex = 8
        '
        'AddProductButton
        '
        Me.AddProductButton.Location = New System.Drawing.Point(127, 230)
        Me.AddProductButton.Name = "AddProductButton"
        Me.AddProductButton.Size = New System.Drawing.Size(75, 23)
        Me.AddProductButton.TabIndex = 9
        Me.AddProductButton.Text = "Confirm"
        Me.AddProductButton.UseVisualStyleBackColor = True
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 331)
        Me.Controls.Add(Me.AddProductButton)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtQR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddProductForm"
        Me.Text = "AddProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQR As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents AddProductButton As Button
End Class
