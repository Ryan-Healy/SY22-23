﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxtoys = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Amount Of Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxtoys
        '
        Me.TextBoxtoys.Location = New System.Drawing.Point(533, 152)
        Me.TextBoxtoys.Name = "TextBoxtoys"
        Me.TextBoxtoys.Size = New System.Drawing.Size(251, 22)
        Me.TextBoxtoys.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "All $1.00 here at Ryan's Dollar Store"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.The_Dollar_Store.My.Resources.Resources.Toys
        Me.PictureBox1.Location = New System.Drawing.Point(51, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 346)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(587, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 406)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxtoys)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form5"
        Me.Text = "Toys"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxtoys As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
