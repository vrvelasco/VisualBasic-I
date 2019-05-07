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
        Me.btnRaiseMax = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lstGraduates = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStudentName
        '
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentName.Location = New System.Drawing.Point(126, 166)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(196, 23)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentCredits
        '
        Me.lblCurrentCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentCredits.Location = New System.Drawing.Point(126, 199)
        Me.lblCurrentCredits.Name = "lblCurrentCredits"
        Me.lblCurrentCredits.Size = New System.Drawing.Size(196, 23)
        Me.lblCurrentCredits.TabIndex = 3
        Me.lblCurrentCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Credits:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCredits
        '
        Me.lblTotalCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCredits.Location = New System.Drawing.Point(126, 231)
        Me.lblTotalCredits.Name = "lblTotalCredits"
        Me.lblTotalCredits.Size = New System.Drawing.Size(196, 23)
        Me.lblTotalCredits.TabIndex = 5
        Me.lblTotalCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(40, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Credits:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddCredit
        '
        Me.btnAddCredit.Location = New System.Drawing.Point(328, 167)
        Me.btnAddCredit.Name = "btnAddCredit"
        Me.btnAddCredit.Size = New System.Drawing.Size(82, 23)
        Me.btnAddCredit.TabIndex = 6
        Me.btnAddCredit.Text = "Add Credit"
        Me.btnAddCredit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(328, 232)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset Credits"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAdd3
        '
        Me.btnAdd3.Location = New System.Drawing.Point(328, 199)
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
        Me.dgvStudents.Size = New System.Drawing.Size(560, 116)
        Me.dgvStudents.TabIndex = 9
        '
        'btnAdd3All
        '
        Me.btnAdd3All.Location = New System.Drawing.Point(416, 199)
        Me.btnAdd3All.Name = "btnAdd3All"
        Me.btnAdd3All.Size = New System.Drawing.Size(75, 24)
        Me.btnAdd3All.TabIndex = 14
        Me.btnAdd3All.Text = "Add 3 To All"
        Me.btnAdd3All.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Location = New System.Drawing.Point(416, 232)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(75, 23)
        Me.btnResetAll.TabIndex = 15
        Me.btnResetAll.Text = "Reset All"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(416, 166)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 24)
        Me.btnAddNew.TabIndex = 16
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Image = Global.StudentTest.My.Resources.Resources.control_double_down_icon
        Me.btnLast.Location = New System.Drawing.Point(9, 231)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(30, 23)
        Me.btnLast.TabIndex = 13
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = Global.StudentTest.My.Resources.Resources.control_up_icon
        Me.btnPrevious.Location = New System.Drawing.Point(9, 190)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(30, 20)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = Global.StudentTest.My.Resources.Resources.control_down_icon
        Me.btnNext.Location = New System.Drawing.Point(9, 210)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 20)
        Me.btnNext.TabIndex = 11
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Image = Global.StudentTest.My.Resources.Resources.control_double_up_icon
        Me.btnFirst.Location = New System.Drawing.Point(9, 165)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(30, 24)
        Me.btnFirst.TabIndex = 10
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(497, 167)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRaiseMax
        '
        Me.btnRaiseMax.Location = New System.Drawing.Point(497, 232)
        Me.btnRaiseMax.Name = "btnRaiseMax"
        Me.btnRaiseMax.Size = New System.Drawing.Size(75, 23)
        Me.btnRaiseMax.TabIndex = 18
        Me.btnRaiseMax.Text = "Raise Max"
        Me.btnRaiseMax.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Search for:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(74, 138)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(498, 20)
        Me.txtSearch.TabIndex = 20
        '
        'lstGraduates
        '
        Me.lstGraduates.FormattingEnabled = True
        Me.lstGraduates.Location = New System.Drawing.Point(7, 20)
        Me.lstGraduates.Name = "lstGraduates"
        Me.lstGraduates.Size = New System.Drawing.Size(185, 212)
        Me.lstGraduates.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstGraduates)
        Me.GroupBox1.Location = New System.Drawing.Point(578, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 243)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graduates"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(497, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 262)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRaiseMax)
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
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Student Test"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnRaiseMax As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstGraduates As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
End Class
