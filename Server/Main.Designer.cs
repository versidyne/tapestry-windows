// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis_Server
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
			NetSocket.ConnectionRequest += new Versidyne.Network.NetSock.ConnectionRequestEventHandler(NetSocketConnection);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
			this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
			this.DisconnectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DisconnectAllToolStripMenuItem.Click += new System.EventHandler(this.DisconnectAllToolStripMenuItem_Click);
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InformationToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
			this.ConsoleBox = new System.Windows.Forms.RichTextBox();
			this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.MenuStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.ActionsToolStripMenuItem, this.ViewToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(214, 24);
			this.MenuStrip1.TabIndex = 1;
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
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//ActionsToolStripMenuItem
			//
			this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.StartToolStripMenuItem, this.StopToolStripMenuItem, this.DisconnectAllToolStripMenuItem});
			this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
			this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.ActionsToolStripMenuItem.Text = "Actions";
			//
			//StartToolStripMenuItem
			//
			this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
			this.StartToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.StartToolStripMenuItem.Text = "Start";
			//
			//StopToolStripMenuItem
			//
			this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
			this.StopToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.StopToolStripMenuItem.Text = "Stop";
			//
			//DisconnectAllToolStripMenuItem
			//
			this.DisconnectAllToolStripMenuItem.Name = "DisconnectAllToolStripMenuItem";
			this.DisconnectAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.DisconnectAllToolStripMenuItem.Text = "Disconnect All";
			//
			//ViewToolStripMenuItem
			//
			this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.InformationToolStripMenuItem});
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.ViewToolStripMenuItem.Text = "View";
			//
			//InformationToolStripMenuItem
			//
			this.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
			this.InformationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.InformationToolStripMenuItem.Text = "Information";
			//
			//ConsoleBox
			//
			this.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConsoleBox.Location = new System.Drawing.Point(0, 24);
			this.ConsoleBox.Name = "ConsoleBox";
			this.ConsoleBox.Size = new System.Drawing.Size(214, 331);
			this.ConsoleBox.TabIndex = 5;
			this.ConsoleBox.Text = "";
			//
			//NotifyIcon1
			//
			this.NotifyIcon1.ContextMenuStrip = this.ContextMenuStrip1;
			this.NotifyIcon1.Icon = (System.Drawing.Icon) (resources.GetObject("NotifyIcon1.Icon"));
			this.NotifyIcon1.Text = "Vexis Server";
			this.NotifyIcon1.Visible = true;
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ShowToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(104, 26);
			//
			//ShowToolStripMenuItem
			//
			this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
			this.ShowToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.ShowToolStripMenuItem.Text = "Show";
			//
			//StatusStrip1
			//
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel1, this.ToolStripStatusLabel2});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 355);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(214, 22);
			this.StatusStrip1.TabIndex = 7;
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
			this.ToolStripStatusLabel2.Size = new System.Drawing.Size(78, 17);
			this.ToolStripStatusLabel2.Text = "Not Listening";
			//
			//Main
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 377);
			this.Controls.Add(this.ConsoleBox);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.StatusStrip1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Main";
			this.Text = "Vexis Server";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DisconnectAllToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem InformationToolStripMenuItem;
		internal System.Windows.Forms.RichTextBox ConsoleBox;
		internal System.Windows.Forms.NotifyIcon NotifyIcon1;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
		internal System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
		
	}
	
}
