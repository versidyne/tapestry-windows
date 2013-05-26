// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports


namespace Vexis
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Plugins : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(Plugins_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plugins));
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ListView1 = new System.Windows.Forms.ListView();
			this.EnableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
			this.DisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem.Click += new System.EventHandler(this.DisableToolStripMenuItem_Click);
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.EnableToolStripMenuItem, this.DisableToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(153, 70);
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "brick.png");
			//
			//ListView1
			//
			this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
			this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListView1.LargeImageList = this.ImageList1;
			this.ListView1.Location = new System.Drawing.Point(0, 0);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new System.Drawing.Size(284, 264);
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.TabIndex = 1;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = System.Windows.Forms.View.List;
			//
			//EnableToolStripMenuItem
			//
			this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
			this.EnableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.EnableToolStripMenuItem.Text = "Enable";
			//
			//DisableToolStripMenuItem
			//
			this.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem";
			this.DisableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.DisableToolStripMenuItem.Text = "Disable";
			//
			//Plugins
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 264);
			this.Controls.Add(this.ListView1);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "Plugins";
			this.Text = "Plugins";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.ListView ListView1;
		internal System.Windows.Forms.ToolStripMenuItem EnableToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DisableToolStripMenuItem;
	}
	
}
