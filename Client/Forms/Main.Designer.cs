// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
//using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Main : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Main_Load);
			base.Resize += new System.EventHandler(Main_Resize);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Main_FormClosing);
			NetSocket.DataArrival += new Versidyne.Network.NetSock.DataArrivalEventHandler(NetSocketData);
			NetSocket.SocketError += new Versidyne.Network.NetSock.SocketErrorEventHandler(NetSocketError);
			NetSocket.Connection += new Versidyne.Network.NetSock.ConnectionEventHandler(NetSocketConnection);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
			this.EditToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem2.Click += new System.EventHandler(this.EditToolStripMenuItem2_Click);
			this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
			this.PluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PluginsToolStripMenuItem.Click += new System.EventHandler(this.PluginsToolStripMenuItem_Click);
			this.SecurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OnToolStripMenuItem.Click += new System.EventHandler(this.OnToolStripMenuItem_Click);
			this.OffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OffToolStripMenuItem.Click += new System.EventHandler(this.OffToolStripMenuItem_Click);
			this.CustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CustomToolStripMenuItem.Click += new System.EventHandler(this.CustomToolStripMenuItem_Click);
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChannelsToolStripMenuItem.Click += new System.EventHandler(this.ChannelsToolStripMenuItem_Click);
			this.ChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChatToolStripMenuItem.Click += new System.EventHandler(this.ChatToolStripMenuItem_Click);
			this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
			this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
			this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.BuddyList = new System.Windows.Forms.ListView();
			this.UsernameField = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.StatusImages = new System.Windows.Forms.ImageList(this.components);
			this.MenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.TrayMenu.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.EditToolStripMenuItem, this.ViewToolStripMenuItem, this.HelpToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(214, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("ExitToolStripMenuItem.Image"));
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//EditToolStripMenuItem
			//
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ContactsToolStripMenuItem, this.PluginsToolStripMenuItem, this.SecurityToolStripMenuItem});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.EditToolStripMenuItem.Text = "Edit";
			//
			//ContactsToolStripMenuItem
			//
			this.ContactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AddToolStripMenuItem, this.DeleteToolStripMenuItem1, this.EditToolStripMenuItem2, this.RefreshToolStripMenuItem});
			this.ContactsToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("ContactsToolStripMenuItem.Image"));
			this.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem";
			this.ContactsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ContactsToolStripMenuItem.Text = "Associates";
			//
			//AddToolStripMenuItem
			//
			this.AddToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("AddToolStripMenuItem.Image"));
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.AddToolStripMenuItem.Text = "Add";
			//
			//DeleteToolStripMenuItem1
			//
			this.DeleteToolStripMenuItem1.Image = (System.Drawing.Image) (resources.GetObject("DeleteToolStripMenuItem1.Image"));
			this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
			this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.DeleteToolStripMenuItem1.Text = "Delete";
			//
			//EditToolStripMenuItem2
			//
			this.EditToolStripMenuItem2.Image = (System.Drawing.Image) (resources.GetObject("EditToolStripMenuItem2.Image"));
			this.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2";
			this.EditToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.EditToolStripMenuItem2.Text = "Edit";
			//
			//RefreshToolStripMenuItem
			//
			this.RefreshToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("RefreshToolStripMenuItem.Image"));
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			//
			//PluginsToolStripMenuItem
			//
			this.PluginsToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("PluginsToolStripMenuItem.Image"));
			this.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem";
			this.PluginsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.PluginsToolStripMenuItem.Text = "Plugins";
			//
			//SecurityToolStripMenuItem
			//
			this.SecurityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.EncryptionToolStripMenuItem});
			this.SecurityToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("SecurityToolStripMenuItem.Image"));
			this.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem";
			this.SecurityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.SecurityToolStripMenuItem.Text = "Security";
			//
			//EncryptionToolStripMenuItem
			//
			this.EncryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.OnToolStripMenuItem, this.OffToolStripMenuItem, this.CustomToolStripMenuItem});
			this.EncryptionToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("EncryptionToolStripMenuItem.Image"));
			this.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem";
			this.EncryptionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.EncryptionToolStripMenuItem.Text = "Encryption";
			//
			//OnToolStripMenuItem
			//
			this.OnToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("OnToolStripMenuItem.Image"));
			this.OnToolStripMenuItem.Name = "OnToolStripMenuItem";
			this.OnToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.OnToolStripMenuItem.Text = "On";
			//
			//OffToolStripMenuItem
			//
			this.OffToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("OffToolStripMenuItem.Image"));
			this.OffToolStripMenuItem.Name = "OffToolStripMenuItem";
			this.OffToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.OffToolStripMenuItem.Text = "Off";
			//
			//CustomToolStripMenuItem
			//
			this.CustomToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("CustomToolStripMenuItem.Image"));
			this.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem";
			this.CustomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.CustomToolStripMenuItem.Text = "Custom";
			//
			//ViewToolStripMenuItem
			//
			this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ChannelsToolStripMenuItem, this.ChatToolStripMenuItem, this.LoginToolStripMenuItem, this.LogoutToolStripMenuItem});
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.ViewToolStripMenuItem.Text = "View";
			//
			//ChannelsToolStripMenuItem
			//
			this.ChannelsToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("ChannelsToolStripMenuItem.Image"));
			this.ChannelsToolStripMenuItem.Name = "ChannelsToolStripMenuItem";
			this.ChannelsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ChannelsToolStripMenuItem.Text = "Channels";
			//
			//ChatToolStripMenuItem
			//
			this.ChatToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("ChatToolStripMenuItem.Image"));
			this.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem";
			this.ChatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ChatToolStripMenuItem.Text = "Chat";
			//
			//LoginToolStripMenuItem
			//
			this.LoginToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("LoginToolStripMenuItem.Image"));
			this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
			this.LoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.LoginToolStripMenuItem.Text = "Login";
			//
			//LogoutToolStripMenuItem
			//
			this.LogoutToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("LogoutToolStripMenuItem.Image"));
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.LogoutToolStripMenuItem.Text = "Logout";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.UpdateToolStripMenuItem, this.AboutToolStripMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			//
			//UpdateToolStripMenuItem
			//
			this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
			this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.UpdateToolStripMenuItem.Text = "Update";
			//
			//AboutToolStripMenuItem
			//
			this.AboutToolStripMenuItem.Image = (System.Drawing.Image) (resources.GetObject("AboutToolStripMenuItem.Image"));
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.AboutToolStripMenuItem.Text = "About";
			//
			//StatusStrip1
			//
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel1, this.ToolStripStatusLabel2});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 355);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(214, 22);
			this.StatusStrip1.TabIndex = 2;
			this.StatusStrip1.Text = "StatusStrip1";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
			this.ToolStripStatusLabel1.Text = "Status: ";
			//
			//ToolStripStatusLabel2
			//
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new System.Drawing.Size(79, 17);
			this.ToolStripStatusLabel2.Text = "Disconnected";
			//
			//TrayMenu
			//
			this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ShowToolStripMenuItem, this.ExitToolStripMenuItem1});
			this.TrayMenu.Name = "ContextMenuStrip1";
			this.TrayMenu.Size = new System.Drawing.Size(104, 48);
			//
			//ShowToolStripMenuItem
			//
			this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
			this.ShowToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.ShowToolStripMenuItem.Text = "Show";
			//
			//ExitToolStripMenuItem1
			//
			this.ExitToolStripMenuItem1.Image = (System.Drawing.Image) (resources.GetObject("ExitToolStripMenuItem1.Image"));
			this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
			this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
			this.ExitToolStripMenuItem1.Text = "Exit";
			//
			//TrayIcon
			//
			this.TrayIcon.ContextMenuStrip = this.TrayMenu;
			this.TrayIcon.Icon = (System.Drawing.Icon) (resources.GetObject("TrayIcon.Icon"));
			this.TrayIcon.Text = "Vexis";
			this.TrayIcon.Visible = true;
			//
			//BuddyList
			//
			this.BuddyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.UsernameField});
			this.BuddyList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BuddyList.Location = new System.Drawing.Point(0, 24);
			this.BuddyList.Name = "BuddyList";
			this.BuddyList.Size = new System.Drawing.Size(214, 331);
			this.BuddyList.SmallImageList = this.StatusImages;
			this.BuddyList.TabIndex = 3;
			this.BuddyList.UseCompatibleStateImageBehavior = false;
			this.BuddyList.View = System.Windows.Forms.View.List;
			//
			//UsernameField
			//
			this.UsernameField.Text = "";
			this.UsernameField.Width = 300;
			//
			//StatusImages
			//
			this.StatusImages.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("StatusImages.ImageStream"));
			this.StatusImages.TransparentColor = System.Drawing.Color.Transparent;
			this.StatusImages.Images.SetKeyName(0, "status_offline.png");
			this.StatusImages.Images.SetKeyName(1, "status_online.png");
			this.StatusImages.Images.SetKeyName(2, "status_away.png");
			this.StatusImages.Images.SetKeyName(3, "status_busy.png");
			//
			//Main
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 377);
			this.Controls.Add(this.BuddyList);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Main";
			this.Text = "Vexis";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.TrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ContactsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ChannelsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ChatToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
		internal System.Windows.Forms.ContextMenuStrip TrayMenu;
		internal System.Windows.Forms.NotifyIcon TrayIcon;
		internal System.Windows.Forms.ToolStripMenuItem SecurityToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem EncryptionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OnToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OffToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CustomToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem PluginsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
		internal System.Windows.Forms.ListView BuddyList;
		internal System.Windows.Forms.ColumnHeader UsernameField;
		internal System.Windows.Forms.ImageList StatusImages;
		internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem2;
		internal System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
		
	}
	
}
