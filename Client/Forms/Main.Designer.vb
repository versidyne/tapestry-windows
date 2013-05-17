<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChannelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BuddyList = New System.Windows.Forms.ListView()
        Me.UsernameField = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusImages = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(214, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactsToolStripMenuItem, Me.PluginsToolStripMenuItem, Me.SecurityToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.EditToolStripMenuItem2, Me.RefreshToolStripMenuItem})
        Me.ContactsToolStripMenuItem.Image = CType(resources.GetObject("ContactsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = CType(resources.GetObject("AddToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Image = CType(resources.GetObject("DeleteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Image = CType(resources.GetObject("EditToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PluginsToolStripMenuItem
        '
        Me.PluginsToolStripMenuItem.Image = CType(resources.GetObject("PluginsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem"
        Me.PluginsToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.PluginsToolStripMenuItem.Text = "Plugins"
        '
        'SecurityToolStripMenuItem
        '
        Me.SecurityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncryptionToolStripMenuItem})
        Me.SecurityToolStripMenuItem.Image = CType(resources.GetObject("SecurityToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem"
        Me.SecurityToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SecurityToolStripMenuItem.Text = "Security"
        '
        'EncryptionToolStripMenuItem
        '
        Me.EncryptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.EncryptionToolStripMenuItem.Image = CType(resources.GetObject("EncryptionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem"
        Me.EncryptionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EncryptionToolStripMenuItem.Text = "Encryption"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Image = CType(resources.GetObject("OnToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Image = CType(resources.GetObject("OffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Image = CType(resources.GetObject("CustomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChannelsToolStripMenuItem, Me.ChatToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ChannelsToolStripMenuItem
        '
        Me.ChannelsToolStripMenuItem.Image = CType(resources.GetObject("ChannelsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChannelsToolStripMenuItem.Name = "ChannelsToolStripMenuItem"
        Me.ChannelsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ChannelsToolStripMenuItem.Text = "Channels"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Image = CType(resources.GetObject("ChatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(214, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel1.Text = "Status: "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel2.Text = "Disconnected"
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.TrayMenu.Name = "ContextMenuStrip1"
        Me.TrayMenu.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Vexis"
        Me.TrayIcon.Visible = True
        '
        'BuddyList
        '
        Me.BuddyList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UsernameField})
        Me.BuddyList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuddyList.Location = New System.Drawing.Point(0, 24)
        Me.BuddyList.Name = "BuddyList"
        Me.BuddyList.Size = New System.Drawing.Size(214, 331)
        Me.BuddyList.SmallImageList = Me.StatusImages
        Me.BuddyList.TabIndex = 3
        Me.BuddyList.UseCompatibleStateImageBehavior = False
        Me.BuddyList.View = System.Windows.Forms.View.List
        '
        'UsernameField
        '
        Me.UsernameField.Text = ""
        Me.UsernameField.Width = 300
        '
        'StatusImages
        '
        Me.StatusImages.ImageStream = CType(resources.GetObject("StatusImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StatusImages.TransparentColor = System.Drawing.Color.Transparent
        Me.StatusImages.Images.SetKeyName(0, "status_offline.png")
        Me.StatusImages.Images.SetKeyName(1, "status_online.png")
        Me.StatusImages.Images.SetKeyName(2, "status_away.png")
        Me.StatusImages.Images.SetKeyName(3, "status_busy.png")
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 377)
        Me.Controls.Add(Me.BuddyList)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Vexis"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChannelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents SecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncryptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PluginsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuddyList As System.Windows.Forms.ListView
    Friend WithEvents UsernameField As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusImages As System.Windows.Forms.ImageList
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
