<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Channels
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Channels))
        Me.ChannelList = New System.Windows.Forms.ListView
        Me.ChannelImages = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ChannelList
        '
        Me.ChannelList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelList.Location = New System.Drawing.Point(0, 0)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(284, 264)
        Me.ChannelList.SmallImageList = Me.ChannelImages
        Me.ChannelList.TabIndex = 0
        Me.ChannelList.UseCompatibleStateImageBehavior = False
        Me.ChannelList.View = System.Windows.Forms.View.List
        '
        'ChannelImages
        '
        Me.ChannelImages.ImageStream = CType(resources.GetObject("ChannelImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ChannelImages.TransparentColor = System.Drawing.Color.Transparent
        Me.ChannelImages.Images.SetKeyName(0, "comment.png")
        Me.ChannelImages.Images.SetKeyName(1, "lock.png")
        '
        'Channels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.ChannelList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Channels"
        Me.Text = "Channels"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChannelList As System.Windows.Forms.ListView
    Friend WithEvents ChannelImages As System.Windows.Forms.ImageList
End Class
