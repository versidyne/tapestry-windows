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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Info : System.Windows.Forms.Form
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
			this.InfoBox = new System.Windows.Forms.TabControl();
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Info_FormClosing);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.ConnectionBox = new System.Windows.Forms.ListBox();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.ReceivedBox = new System.Windows.Forms.RichTextBox();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.ErrorBox = new System.Windows.Forms.RichTextBox();
			this.InfoBox.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.SuspendLayout();
			//
			//InfoBox
			//
			this.InfoBox.Controls.Add(this.TabPage1);
			this.InfoBox.Controls.Add(this.TabPage2);
			this.InfoBox.Controls.Add(this.TabPage3);
			this.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InfoBox.Location = new System.Drawing.Point(0, 0);
			this.InfoBox.Name = "InfoBox";
			this.InfoBox.SelectedIndex = 0;
			this.InfoBox.Size = new System.Drawing.Size(284, 270);
			this.InfoBox.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.ConnectionBox);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(276, 244);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Connections";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//ConnectionBox
			//
			this.ConnectionBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConnectionBox.FormattingEnabled = true;
			this.ConnectionBox.Location = new System.Drawing.Point(3, 3);
			this.ConnectionBox.Name = "ConnectionBox";
			this.ConnectionBox.Size = new System.Drawing.Size(270, 238);
			this.ConnectionBox.TabIndex = 0;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.ReceivedBox);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(276, 244);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Received";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//ReceivedBox
			//
			this.ReceivedBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReceivedBox.Location = new System.Drawing.Point(3, 3);
			this.ReceivedBox.Name = "ReceivedBox";
			this.ReceivedBox.Size = new System.Drawing.Size(270, 238);
			this.ReceivedBox.TabIndex = 3;
			this.ReceivedBox.Text = "";
			//
			//TabPage3
			//
			this.TabPage3.Controls.Add(this.ErrorBox);
			this.TabPage3.Location = new System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new System.Drawing.Size(276, 244);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "Errors";
			this.TabPage3.UseVisualStyleBackColor = true;
			//
			//ErrorBox
			//
			this.ErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ErrorBox.Location = new System.Drawing.Point(3, 3);
			this.ErrorBox.Name = "ErrorBox";
			this.ErrorBox.Size = new System.Drawing.Size(270, 238);
			this.ErrorBox.TabIndex = 4;
			this.ErrorBox.Text = "";
			//
			//Info
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 270);
			this.Controls.Add(this.InfoBox);
			this.Name = "Info";
			this.Text = "Info";
			this.InfoBox.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TabControl InfoBox;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.RichTextBox ReceivedBox;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.RichTextBox ErrorBox;
		internal System.Windows.Forms.ListBox ConnectionBox;
	}
	
}
