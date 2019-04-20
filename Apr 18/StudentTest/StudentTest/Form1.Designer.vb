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
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCurrentCredits = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCredits = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddCredit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd3 = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(578, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStudentName
        '
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentName.Location = New System.Drawing.Point(664, 12)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentCredits
        '
        Me.lblCurrentCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentCredits.Location = New System.Drawing.Point(664, 40)
        Me.lblCurrentCredits.Name = "lblCurrentCredits"
        Me.lblCurrentCredits.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrentCredits.TabIndex = 3
        Me.lblCurrentCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(578, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Credits:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCredits
        '
        Me.lblTotalCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCredits.Location = New System.Drawing.Point(664, 68)
        Me.lblTotalCredits.Name = "lblTotalCredits"
        Me.lblTotalCredits.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCredits.TabIndex = 5
        Me.lblTotalCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(578, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Credits:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddCredit
        '
        Me.btnAddCredit.Location = New System.Drawing.Point(770, 12)
        Me.btnAddCredit.Name = "btnAddCredit"
        Me.btnAddCredit.Size = New System.Drawing.Size(82, 23)
        Me.btnAddCredit.TabIndex = 6
        Me.btnAddCredit.Text = "Add Credit"
        Me.btnAddCredit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(770, 68)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset Credits"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAdd3
        '
        Me.btnAdd3.Location = New System.Drawing.Point(770, 39)
        Me.btnAdd3.Name = "btnAdd3"
        Me.btnAdd3.Size = New System.Drawing.Size(82, 23)
        Me.btnAdd3.TabIndex = 8
        Me.btnAdd3.Text = "Add 3 Credits"
        Me.btnAdd3.UseVisualStyleBackColor = True
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(12, 12)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.Size = New System.Drawing.Size(560, 79)
        Me.dgvStudents.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 106)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.btnAdd3)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAddCredit)
        Me.Controls.Add(Me.lblTotalCredits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCurrentCredits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Student Test"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblCurrentCredits As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalCredits As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddCredit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAdd3 As Button
    Friend WithEvents dgvStudents As DataGridView
End Class
