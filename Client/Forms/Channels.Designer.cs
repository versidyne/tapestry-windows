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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Channels : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(Channels_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Channels));
			this.ChannelList = new System.Windows.Forms.ListView();
			this.ChannelImages = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			//
			//ChannelList
			//
			this.ChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChannelList.Location = new System.Drawing.Point(0, 0);
			this.ChannelList.Name = "ChannelList";
			this.ChannelList.Size = new System.Drawing.Size(284, 264);
			this.ChannelList.SmallImageList = this.ChannelImages;
			this.ChannelList.TabIndex = 0;
			this.ChannelList.UseCompatibleStateImageBehavior = false;
			this.ChannelList.View = System.Windows.Forms.View.List;
			//
			//ChannelImages
			//
			this.ChannelImages.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ChannelImages.ImageStream"));
			this.ChannelImages.TransparentColor = System.Drawing.Color.Transparent;
			this.ChannelImages.Images.SetKeyName(0, "comment.png");
			this.ChannelImages.Images.SetKeyName(1, "lock.png");
			//
			//Channels
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 264);
			this.Controls.Add(this.ChannelList);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "Channels";
			this.Text = "Channels";
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.ListView ChannelList;
		internal System.Windows.Forms.ImageList ChannelImages;
	}
	
}
