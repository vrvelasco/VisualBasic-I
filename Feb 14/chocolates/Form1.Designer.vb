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
        Me.txtChocPerBox = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstChocolates = New System.Windows.Forms.ListBox()
        Me.picChoc = New System.Windows.Forms.PictureBox()
        CType(Me.picChoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtChocPerBox
        '
        Me.txtChocPerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChocPerBox.Location = New System.Drawing.Point(126, 14)
        Me.txtChocPerBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtChocPerBox.Name = "txtChocPerBox"
        Me.txtChocPerBox.Size = New System.Drawing.Size(21, 23)
        Me.txtChocPerBox.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(153, 14)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(117, 22)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dozen per Box"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstChocolates
        '
        Me.lstChocolates.FormattingEnabled = True
        Me.lstChocolates.Location = New System.Drawing.Point(153, 40)
        Me.lstChocolates.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstChocolates.Name = "lstChocolates"
        Me.lstChocolates.Size = New System.Drawing.Size(119, 173)
        Me.lstChocolates.TabIndex = 6
        '
        'picChoc
        '
        Me.picChoc.Image = Global.Chocolates.My.Resources.Resources.chocolates2
        Me.picChoc.Location = New System.Drawing.Point(22, 40)
        Me.picChoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picChoc.Name = "picChoc"
        Me.picChoc.Size = New System.Drawing.Size(124, 172)
        Me.picChoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoc.TabIndex = 7
        Me.picChoc.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 222)
        Me.Controls.Add(Me.picChoc)
        Me.Controls.Add(Me.lstChocolates)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtChocPerBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Milk Chocolates"
        CType(Me.picChoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChocPerBox As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstChocolates As System.Windows.Forms.ListBox
    Friend WithEvents picChoc As System.Windows.Forms.PictureBox

End Class
