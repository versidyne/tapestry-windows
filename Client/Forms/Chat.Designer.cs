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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Chat : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
			this.ChannelTabs = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(Chat_Load);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Chat_FormClosing);
			base.Resize += new System.EventHandler(Chat_Resize);
			this.ChannelTab = new System.Windows.Forms.TabPage();
			this.MainContainer = new System.Windows.Forms.SplitContainer();
			this.ChatOutput = new System.Windows.Forms.RichTextBox();
			this.ChatOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ChatOutput_LinkClicked);
			this.InputContainer = new System.Windows.Forms.SplitContainer();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.FontToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.FontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.CutToolStripButton.Click += new System.EventHandler(this.CutToolStripButton_Click);
			this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
			this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.PasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripButton_Click);
			this.UserInput = new System.Windows.Forms.RichTextBox();
			this.UserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInput_KeyDown);
			this.UserInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.UserInput_DragEnter);
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.FontDialog1 = new System.Windows.Forms.FontDialog();
			this.ChannelTabs.SuspendLayout();
			this.ChannelTab.SuspendLayout();
			this.MainContainer.Panel1.SuspendLayout();
			this.MainContainer.Panel2.SuspendLayout();
			this.MainContainer.SuspendLayout();
			this.InputContainer.Panel1.SuspendLayout();
			this.InputContainer.Panel2.SuspendLayout();
			this.InputContainer.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//ChannelTabs
			//
			this.ChannelTabs.Controls.Add(this.ChannelTab);
			this.ChannelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChannelTabs.Location = new System.Drawing.Point(0, 0);
			this.ChannelTabs.Name = "ChannelTabs";
			this.ChannelTabs.SelectedIndex = 0;
			this.ChannelTabs.Size = new System.Drawing.Size(422, 304);
			this.ChannelTabs.TabIndex = 0;
			this.ChannelTabs.TabStop = false;
			//
			//ChannelTab
			//
			this.ChannelTab.Controls.Add(this.MainContainer);
			this.ChannelTab.Location = new System.Drawing.Point(4, 22);
			this.ChannelTab.Name = "ChannelTab";
			this.ChannelTab.Padding = new System.Windows.Forms.Padding(3);
			this.ChannelTab.Size = new System.Drawing.Size(414, 278);
			this.ChannelTab.TabIndex = 0;
			this.ChannelTab.Text = "Unknown Channel";
			this.ChannelTab.UseVisualStyleBackColor = true;
			//
			//MainContainer
			//
			this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainContainer.Location = new System.Drawing.Point(3, 3);
			this.MainContainer.Name = "MainContainer";
			this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//MainContainer.Panel1
			//
			this.MainContainer.Panel1.Controls.Add(this.ChatOutput);
			//
			//MainContainer.Panel2
			//
			this.MainContainer.Panel2.Controls.Add(this.InputContainer);
			this.MainContainer.Size = new System.Drawing.Size(408, 272);
			this.MainContainer.SplitterDistance = 199;
			this.MainContainer.TabIndex = 0;
			this.MainContainer.TabStop = false;
			//
			//ChatOutput
			//
			this.ChatOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChatOutput.Font = new System.Drawing.Font("Calibri", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ChatOutput.Location = new System.Drawing.Point(0, 0);
			this.ChatOutput.Name = "ChatOutput";
			this.ChatOutput.Size = new System.Drawing.Size(408, 199);
			this.ChatOutput.TabIndex = 0;
			this.ChatOutput.TabStop = false;
			this.ChatOutput.Text = "";
			//
			//InputContainer
			//
			this.InputContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InputContainer.IsSplitterFixed = true;
			this.InputContainer.Location = new System.Drawing.Point(0, 0);
			this.InputContainer.Name = "InputContainer";
			this.InputContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			//
			//InputContainer.Panel1
			//
			this.InputContainer.Panel1.Controls.Add(this.ToolStrip1);
			//
			//InputContainer.Panel2
			//
			this.InputContainer.Panel2.Controls.Add(this.UserInput);
			this.InputContainer.Size = new System.Drawing.Size(408, 69);
			this.InputContainer.SplitterDistance = 25;
			this.InputContainer.SplitterWidth = 1;
			this.InputContainer.TabIndex = 0;
			this.InputContainer.TabStop = false;
			//
			//ToolStrip1
			//
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FontToolStripButton, this.ToolStripSeparator2, this.CutToolStripButton, this.CopyToolStripButton, this.PasteToolStripButton});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.Size = new System.Drawing.Size(408, 25);
			this.ToolStrip1.TabIndex = 4;
			this.ToolStrip1.Text = "ToolStrip1";
			//
			//FontToolStripButton
			//
			this.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.FontToolStripButton.Image = (System.Drawing.Image) (resources.GetObject("FontToolStripButton.Image"));
			this.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FontToolStripButton.Name = "FontToolStripButton";
			this.FontToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.FontToolStripButton.Text = "Font";
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			//
			//CutToolStripButton
			//
			this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CutToolStripButton.Image = (System.Drawing.Image) (resources.GetObject("CutToolStripButton.Image"));
			this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CutToolStripButton.Name = "CutToolStripButton";
			this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.CutToolStripButton.Text = "C&ut";
			//
			//CopyToolStripButton
			//
			this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyToolStripButton.Image = (System.Drawing.Image) (resources.GetObject("CopyToolStripButton.Image"));
			this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CopyToolStripButton.Name = "CopyToolStripButton";
			this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.CopyToolStripButton.Text = "&Copy";
			//
			//PasteToolStripButton
			//
			this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PasteToolStripButton.Image = (System.Drawing.Image) (resources.GetObject("PasteToolStripButton.Image"));
			this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PasteToolStripButton.Name = "PasteToolStripButton";
			this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.PasteToolStripButton.Text = "&Paste";
			//
			//UserInput
			//
			this.UserInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserInput.Font = new System.Drawing.Font("Calibri", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.UserInput.Location = new System.Drawing.Point(0, 0);
			this.UserInput.Name = "UserInput";
			this.UserInput.Size = new System.Drawing.Size(408, 43);
			this.UserInput.TabIndex = 3;
			this.UserInput.Text = "";
			//
			//OpenFileDialog
			//
			this.OpenFileDialog.FileName = "OpenFileDialog1";
			//
			//Chat
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 304);
			this.Controls.Add(this.ChannelTabs);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Name = "Chat";
			this.Text = "Chat";
			this.ChannelTabs.ResumeLayout(false);
			this.ChannelTab.ResumeLayout(false);
			this.MainContainer.Panel1.ResumeLayout(false);
			this.MainContainer.Panel2.ResumeLayout(false);
			this.MainContainer.ResumeLayout(false);
			this.InputContainer.Panel1.ResumeLayout(false);
			this.InputContainer.Panel1.PerformLayout();
			this.InputContainer.Panel2.ResumeLayout(false);
			this.InputContainer.ResumeLayout(false);
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TabControl ChannelTabs;
		internal System.Windows.Forms.TabPage ChannelTab;
		internal System.Windows.Forms.SplitContainer MainContainer;
		internal System.Windows.Forms.RichTextBox ChatOutput;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog;
		internal System.Windows.Forms.SplitContainer InputContainer;
		internal System.Windows.Forms.ToolStrip ToolStrip1;
		internal System.Windows.Forms.ToolStripButton FontToolStripButton;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripButton CutToolStripButton;
		internal System.Windows.Forms.ToolStripButton CopyToolStripButton;
		internal System.Windows.Forms.ToolStripButton PasteToolStripButton;
		internal System.Windows.Forms.RichTextBox UserInput;
		internal System.Windows.Forms.FontDialog FontDialog1;
	}
	
}
