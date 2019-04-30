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
        Me.dgvEmployeeList = New System.Windows.Forms.DataGridView()
        Me.btnRaise = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmployeeNum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployeeList
        '
        Me.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeList.Location = New System.Drawing.Point(12, 12)
        Me.dgvEmployeeList.Name = "dgvEmployeeList"
        Me.dgvEmployeeList.Size = New System.Drawing.Size(360, 175)
        Me.dgvEmployeeList.TabIndex = 0
        '
        'btnRaise
        '
        Me.btnRaise.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaise.Location = New System.Drawing.Point(9, 133)
        Me.btnRaise.Name = "btnRaise"
        Me.btnRaise.Size = New System.Drawing.Size(222, 37)
        Me.btnRaise.TabIndex = 1
        Me.btnRaise.Text = "Give All Employees 10% Raise"
        Me.btnRaise.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Employees:"
        '
        'lblEmployeeNum
        '
        Me.lblEmployeeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeNum.Location = New System.Drawing.Point(137, 29)
        Me.lblEmployeeNum.Name = "lblEmployeeNum"
        Me.lblEmployeeNum.Size = New System.Drawing.Size(49, 23)
        Me.lblEmployeeNum.TabIndex = 3
        Me.lblEmployeeNum.Text = "#"
        Me.lblEmployeeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Annual Salary:"
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.SystemColors.Control
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalary.Location = New System.Drawing.Point(123, 79)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(100, 23)
        Me.lblSalary.TabIndex = 5
        Me.lblSalary.Text = "$"
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSalary)
        Me.GroupBox1.Controls.Add(Me.btnRaise)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblEmployeeNum)
        Me.GroupBox1.Location = New System.Drawing.Point(383, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 181)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnRaise
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 197)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvEmployeeList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Employees"
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmployeeList As DataGridView
    Friend WithEvents btnRaise As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmployeeNum As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
