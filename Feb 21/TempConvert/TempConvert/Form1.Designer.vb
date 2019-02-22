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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtFahr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(182, 10)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Degrees F."
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(12, 45)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(245, 102)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFahr
        '
        Me.txtFahr.Location = New System.Drawing.Point(76, 12)
        Me.txtFahr.Name = "txtFahr"
        Me.txtFahr.Size = New System.Drawing.Size(100, 20)
        Me.txtFahr.TabIndex = 0
        '
        'Form1
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 159)
        Me.Controls.Add(Me.txtFahr)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtFahr As TextBox
End Class
