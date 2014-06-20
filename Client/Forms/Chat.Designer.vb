<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.ChannelTabs = New System.Windows.Forms.TabControl
        Me.ChannelTab = New System.Windows.Forms.TabPage
        Me.MainContainer = New System.Windows.Forms.SplitContainer
        Me.ChatOutput = New System.Windows.Forms.RichTextBox
        Me.InputContainer = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.UserInput = New System.Windows.Forms.RichTextBox
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ChannelTabs.SuspendLayout()
        Me.ChannelTab.SuspendLayout()
        Me.MainContainer.Panel1.SuspendLayout()
        Me.MainContainer.Panel2.SuspendLayout()
        Me.MainContainer.SuspendLayout()
        Me.InputContainer.Panel1.SuspendLayout()
        Me.InputContainer.Panel2.SuspendLayout()
        Me.InputContainer.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChannelTabs
        '
        Me.ChannelTabs.Controls.Add(Me.ChannelTab)
        Me.ChannelTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelTabs.Location = New System.Drawing.Point(0, 0)
        Me.ChannelTabs.Name = "ChannelTabs"
        Me.ChannelTabs.SelectedIndex = 0
        Me.ChannelTabs.Size = New System.Drawing.Size(422, 304)
        Me.ChannelTabs.TabIndex = 0
        Me.ChannelTabs.TabStop = False
        '
        'ChannelTab
        '
        Me.ChannelTab.Controls.Add(Me.MainContainer)
        Me.ChannelTab.Location = New System.Drawing.Point(4, 22)
        Me.ChannelTab.Name = "ChannelTab"
        Me.ChannelTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ChannelTab.Size = New System.Drawing.Size(414, 278)
        Me.ChannelTab.TabIndex = 0
        Me.ChannelTab.Text = "Unknown Channel"
        Me.ChannelTab.UseVisualStyleBackColor = True
        '
        'MainContainer
        '
        Me.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainContainer.Location = New System.Drawing.Point(3, 3)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainContainer.Panel1
        '
        Me.MainContainer.Panel1.Controls.Add(Me.ChatOutput)
        '
        'MainContainer.Panel2
        '
        Me.MainContainer.Panel2.Controls.Add(Me.InputContainer)
        Me.MainContainer.Size = New System.Drawing.Size(408, 272)
        Me.MainContainer.SplitterDistance = 199
        Me.MainContainer.TabIndex = 0
        Me.MainContainer.TabStop = False
        '
        'ChatOutput
        '
        Me.ChatOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChatOutput.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChatOutput.Location = New System.Drawing.Point(0, 0)
        Me.ChatOutput.Name = "ChatOutput"
        Me.ChatOutput.Size = New System.Drawing.Size(408, 199)
        Me.ChatOutput.TabIndex = 0
        Me.ChatOutput.TabStop = False
        Me.ChatOutput.Text = ""
        '
        'InputContainer
        '
        Me.InputContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputContainer.IsSplitterFixed = True
        Me.InputContainer.Location = New System.Drawing.Point(0, 0)
        Me.InputContainer.Name = "InputContainer"
        Me.InputContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'InputContainer.Panel1
        '
        Me.InputContainer.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'InputContainer.Panel2
        '
        Me.InputContainer.Panel2.Controls.Add(Me.UserInput)
        Me.InputContainer.Size = New System.Drawing.Size(408, 69)
        Me.InputContainer.SplitterDistance = 25
        Me.InputContainer.SplitterWidth = 1
        Me.InputContainer.TabIndex = 0
        Me.InputContainer.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripButton, Me.ToolStripSeparator2, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(408, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'UserInput
        '
        Me.UserInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserInput.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInput.Location = New System.Drawing.Point(0, 0)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(408, 43)
        Me.UserInput.TabIndex = 3
        Me.UserInput.Text = ""
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 304)
        Me.Controls.Add(Me.ChannelTabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chat"
        Me.Text = "Chat"
        Me.ChannelTabs.ResumeLayout(False)
        Me.ChannelTab.ResumeLayout(False)
        Me.MainContainer.Panel1.ResumeLayout(False)
        Me.MainContainer.Panel2.ResumeLayout(False)
        Me.MainContainer.ResumeLayout(False)
        Me.InputContainer.Panel1.ResumeLayout(False)
        Me.InputContainer.Panel1.PerformLayout()
        Me.InputContainer.Panel2.ResumeLayout(False)
        Me.InputContainer.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChannelTabs As System.Windows.Forms.TabControl
    Friend WithEvents ChannelTab As System.Windows.Forms.TabPage
    Friend WithEvents MainContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ChatOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents InputContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FontToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserInput As System.Windows.Forms.RichTextBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
