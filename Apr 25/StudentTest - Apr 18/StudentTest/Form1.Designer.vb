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
        Me.btnAdd3All = New System.Windows.Forms.Button()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(611, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStudentName
        '
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentName.Location = New System.Drawing.Point(697, 12)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentCredits
        '
        Me.lblCurrentCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentCredits.Location = New System.Drawing.Point(697, 45)
        Me.lblCurrentCredits.Name = "lblCurrentCredits"
        Me.lblCurrentCredits.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrentCredits.TabIndex = 3
        Me.lblCurrentCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(611, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Credits:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCredits
        '
        Me.lblTotalCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCredits.Location = New System.Drawing.Point(697, 77)
        Me.lblTotalCredits.Name = "lblTotalCredits"
        Me.lblTotalCredits.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCredits.TabIndex = 5
        Me.lblTotalCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(611, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Credits:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddCredit
        '
        Me.btnAddCredit.Location = New System.Drawing.Point(803, 12)
        Me.btnAddCredit.Name = "btnAddCredit"
        Me.btnAddCredit.Size = New System.Drawing.Size(82, 23)
        Me.btnAddCredit.TabIndex = 6
        Me.btnAddCredit.Text = "Add Credit"
        Me.btnAddCredit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(803, 77)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset Credits"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAdd3
        '
        Me.btnAdd3.Location = New System.Drawing.Point(803, 44)
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
        Me.dgvStudents.Size = New System.Drawing.Size(560, 88)
        Me.dgvStudents.TabIndex = 9
        '
        'btnAdd3All
        '
        Me.btnAdd3All.Location = New System.Drawing.Point(891, 45)
        Me.btnAdd3All.Name = "btnAdd3All"
        Me.btnAdd3All.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd3All.TabIndex = 14
        Me.btnAdd3All.Text = "Add 3 To All"
        Me.btnAdd3All.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Location = New System.Drawing.Point(891, 77)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(75, 23)
        Me.btnResetAll.TabIndex = 15
        Me.btnResetAll.Text = "Reset All"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(891, 11)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 16
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Image = Global.StudentTest.My.Resources.Resources.control_double_down_icon
        Me.btnLast.Location = New System.Drawing.Point(580, 77)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(30, 23)
        Me.btnLast.TabIndex = 13
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = Global.StudentTest.My.Resources.Resources.control_up_icon
        Me.btnPrevious.Location = New System.Drawing.Point(580, 36)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(30, 20)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.StudentTest.My.Resources.Resources.control_down_icon
        Me.btnNext.Location = New System.Drawing.Point(580, 56)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 20)
        Me.btnNext.TabIndex = 11
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Image = Global.StudentTest.My.Resources.Resources.control_double_up_icon
        Me.btnFirst.Location = New System.Drawing.Point(580, 11)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(30, 24)
        Me.btnFirst.TabIndex = 10
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(972, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 88)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 112)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnResetAll)
        Me.Controls.Add(Me.btnAdd3All)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
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
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnAdd3All As Button
    Friend WithEvents btnResetAll As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnRemove As Button
End Class
