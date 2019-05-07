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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumPackage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStateSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblNumPackage)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Package Information"
        '
        'lblNumPackage
        '
        Me.lblNumPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNumPackage.Location = New System.Drawing.Point(11, 31)
        Me.lblNumPackage.Name = "lblNumPackage"
        Me.lblNumPackage.Size = New System.Drawing.Size(138, 25)
        Me.lblNumPackage.TabIndex = 0
        Me.lblNumPackage.Text = "Package #"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "State:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(54, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(54, 84)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(210, 20)
        Me.txtCity.TabIndex = 2
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(54, 110)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(29, 20)
        Me.txtState.TabIndex = 3
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(7, 150)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 23)
        Me.btnFirst.TabIndex = 1
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(73, 150)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 23)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(139, 150)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(205, 150)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(60, 23)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lstResults)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtStateSearch)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search By State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "State:"
        '
        'txtStateSearch
        '
        Me.txtStateSearch.Location = New System.Drawing.Point(44, 28)
        Me.txtStateSearch.MaxLength = 2
        Me.txtStateSearch.Name = "txtStateSearch"
        Me.txtStateSearch.Size = New System.Drawing.Size(29, 20)
        Me.txtStateSearch.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(83, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(9, 91)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(149, 82)
        Me.lstResults.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Package Search Results:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 205)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Package Distribution System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumPackage As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStateSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstResults As ListBox
End Class
