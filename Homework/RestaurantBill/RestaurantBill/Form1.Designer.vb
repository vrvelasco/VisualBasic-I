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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(168, 12)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 72)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "Compute Total Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(12, 90)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(231, 95)
        Me.lstBill.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How many pizza slices?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "How many fries?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "How many soft drinks?"
        '
        'txtPizza
        '
        Me.txtPizza.Location = New System.Drawing.Point(137, 12)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(25, 20)
        Me.txtPizza.TabIndex = 5
        Me.txtPizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(137, 38)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(25, 20)
        Me.txtFries.TabIndex = 6
        Me.txtFries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(137, 64)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(25, 20)
        Me.txtDrinks.TabIndex = 7
        Me.txtDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 195)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.btnCompute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCompute As Button
    Friend WithEvents lstBill As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents txtDrinks As TextBox
End Class
