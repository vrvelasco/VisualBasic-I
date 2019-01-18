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
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.btnFindCity = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCities
        '
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 16
        Me.lstCities.Items.AddRange(New Object() {"Chicago", "San Francisco", "Miami", "Phoenix", "New York", "Philadelphia"})
        Me.lstCities.Location = New System.Drawing.Point(16, 15)
        Me.lstCities.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(159, 116)
        Me.lstCities.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(217, 15)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(164, 23)
        Me.txtCity.TabIndex = 1
        '
        'btnFindCity
        '
        Me.btnFindCity.Location = New System.Drawing.Point(217, 50)
        Me.btnFindCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFindCity.Name = "btnFindCity"
        Me.btnFindCity.Size = New System.Drawing.Size(165, 28)
        Me.btnFindCity.TabIndex = 2
        Me.btnFindCity.Text = "Find a City"
        Me.btnFindCity.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(217, 92)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(165, 28)
        Me.lblResult.TabIndex = 3
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 154)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnFindCity)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lstCities)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Searching For Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCities As ListBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents btnFindCity As Button
    Friend WithEvents lblResult As Label
End Class
