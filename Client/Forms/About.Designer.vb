<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Button1 = New System.Windows.Forms.Button
        Me.DescriptionBox = New System.Windows.Forms.RichTextBox
        Me.LabelProductName = New System.Windows.Forms.Label
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.LabelCopyright = New System.Windows.Forms.Label
        Me.LabelCompanyName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DescriptionBox
        '
        Me.DescriptionBox.Location = New System.Drawing.Point(12, 112)
        Me.DescriptionBox.Name = "DescriptionBox"
        Me.DescriptionBox.ReadOnly = True
        Me.DescriptionBox.Size = New System.Drawing.Size(257, 123)
        Me.DescriptionBox.TabIndex = 1
        Me.DescriptionBox.Text = ""
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(12, 9)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(39, 13)
        Me.LabelProductName.TabIndex = 2
        Me.LabelProductName.Text = "Label1"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(12, 34)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(39, 13)
        Me.LabelVersion.TabIndex = 3
        Me.LabelVersion.Text = "Label2"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(12, 59)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(39, 13)
        Me.LabelCopyright.TabIndex = 4
        Me.LabelCopyright.Text = "Label3"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(12, 84)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(39, 13)
        Me.LabelCompanyName.TabIndex = 5
        Me.LabelCompanyName.Text = "Label4"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 266)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DescriptionBox As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
End Class
