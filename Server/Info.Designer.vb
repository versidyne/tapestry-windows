<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Me.InfoBox = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ConnectionBox = New System.Windows.Forms.ListBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReceivedBox = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ErrorBox = New System.Windows.Forms.RichTextBox
        Me.InfoBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoBox
        '
        Me.InfoBox.Controls.Add(Me.TabPage1)
        Me.InfoBox.Controls.Add(Me.TabPage2)
        Me.InfoBox.Controls.Add(Me.TabPage3)
        Me.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoBox.Location = New System.Drawing.Point(0, 0)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.SelectedIndex = 0
        Me.InfoBox.Size = New System.Drawing.Size(284, 270)
        Me.InfoBox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ConnectionBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(276, 244)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connections"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ConnectionBox
        '
        Me.ConnectionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConnectionBox.FormattingEnabled = True
        Me.ConnectionBox.Location = New System.Drawing.Point(3, 3)
        Me.ConnectionBox.Name = "ConnectionBox"
        Me.ConnectionBox.Size = New System.Drawing.Size(270, 238)
        Me.ConnectionBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReceivedBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(276, 244)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Received"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReceivedBox
        '
        Me.ReceivedBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceivedBox.Location = New System.Drawing.Point(3, 3)
        Me.ReceivedBox.Name = "ReceivedBox"
        Me.ReceivedBox.Size = New System.Drawing.Size(270, 238)
        Me.ReceivedBox.TabIndex = 3
        Me.ReceivedBox.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ErrorBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(276, 244)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Errors"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ErrorBox
        '
        Me.ErrorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorBox.Location = New System.Drawing.Point(3, 3)
        Me.ErrorBox.Name = "ErrorBox"
        Me.ErrorBox.Size = New System.Drawing.Size(270, 238)
        Me.ErrorBox.TabIndex = 4
        Me.ErrorBox.Text = ""
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 270)
        Me.Controls.Add(Me.InfoBox)
        Me.Name = "Info"
        Me.Text = "Info"
        Me.InfoBox.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfoBox As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReceivedBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ErrorBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ConnectionBox As System.Windows.Forms.ListBox
End Class
