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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOne.Location = New System.Drawing.Point(31, 28)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(100, 22)
        Me.txtOne.TabIndex = 2
        Me.txtOne.Text = "One"
        Me.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTwo
        '
        Me.txtTwo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTwo.Location = New System.Drawing.Point(31, 59)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(100, 22)
        Me.txtTwo.TabIndex = 3
        Me.txtTwo.Text = "Two"
        Me.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThree
        '
        Me.txtThree.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThree.Location = New System.Drawing.Point(31, 90)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(100, 22)
        Me.txtThree.TabIndex = 4
        Me.txtThree.Text = "Three"
        Me.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Image = Global.Assignment1.My.Resources.Resources.right
        Me.btnRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRight.Location = New System.Drawing.Point(147, 72)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(85, 40)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "Right"
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Image = Global.Assignment1.My.Resources.Resources.left
        Me.btnLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeft.Location = New System.Drawing.Point(147, 28)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(85, 40)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "Left"
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 139)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "One, Two, Three"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents txtOne As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents txtThree As TextBox
End Class
