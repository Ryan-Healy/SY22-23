<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Purchasebutton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.expTextBox = New System.Windows.Forms.TextBox()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Cancelbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Fee = New System.Windows.Forms.Label()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Full Name"
        '
        'Purchasebutton
        '
        Me.Purchasebutton.Location = New System.Drawing.Point(577, 434)
        Me.Purchasebutton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Purchasebutton.Name = "Purchasebutton"
        Me.Purchasebutton.Size = New System.Drawing.Size(120, 50)
        Me.Purchasebutton.TabIndex = 1
        Me.Purchasebutton.Text = "Purchase"
        Me.Purchasebutton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(183, 45)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(259, 40)
        Me.NameTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CC#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exp Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 30)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Amount"
        '
        'expTextBox
        '
        Me.expTextBox.Location = New System.Drawing.Point(183, 222)
        Me.expTextBox.Name = "expTextBox"
        Me.expTextBox.Size = New System.Drawing.Size(259, 40)
        Me.expTextBox.TabIndex = 7
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(183, 131)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(259, 40)
        Me.CCTextBox.TabIndex = 8
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(183, 309)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(259, 40)
        Me.ZipTextBox.TabIndex = 9
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(183, 388)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(259, 40)
        Me.AmountTextBox.TabIndex = 10
        '
        'Cancelbutton
        '
        Me.Cancelbutton.Location = New System.Drawing.Point(775, 434)
        Me.Cancelbutton.Name = "Cancelbutton"
        Me.Cancelbutton.Size = New System.Drawing.Size(102, 50)
        Me.Cancelbutton.TabIndex = 11
        Me.Cancelbutton.Text = "Cancel"
        Me.Cancelbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._3rd_project.My.Resources.Resources.VISA
        Me.PictureBox1.Location = New System.Drawing.Point(497, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Fee
        '
        Me.Fee.AutoSize = True
        Me.Fee.Location = New System.Drawing.Point(109, 466)
        Me.Fee.Name = "Fee"
        Me.Fee.Size = New System.Drawing.Size(40, 30)
        Me.Fee.TabIndex = 13
        Me.Fee.Text = "Fee"
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(183, 463)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(259, 40)
        Me.FeeTextBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 843)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.Fee)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancelbutton)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.expTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Purchasebutton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Myanmar Text", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "My app"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Purchasebutton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents expTextBox As TextBox
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Cancelbutton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Fee As Label
    Friend WithEvents FeeTextBox As TextBox
End Class
