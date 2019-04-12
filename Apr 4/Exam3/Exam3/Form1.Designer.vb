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
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.grpControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(55, 19)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 20)
        Me.txtItem.TabIndex = 0
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(55, 45)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(6, 71)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(149, 25)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter Sale"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(12, 122)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(163, 256)
        Me.lstReceipt.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(19, 22)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "Item:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(3, 48)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 5
        Me.lblAmount.Text = "Amount:"
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.txtItem)
        Me.grpControls.Controls.Add(Me.lblAmount)
        Me.grpControls.Controls.Add(Me.txtAmount)
        Me.grpControls.Controls.Add(Me.lblItem)
        Me.grpControls.Controls.Add(Me.btnEnter)
        Me.grpControls.Location = New System.Drawing.Point(12, 12)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(163, 104)
        Me.grpControls.TabIndex = 0
        Me.grpControls.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 387)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.lstReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Sales Receipt"
        Me.grpControls.ResumeLayout(False)
        Me.grpControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents lblItem As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents grpControls As GroupBox
End Class
