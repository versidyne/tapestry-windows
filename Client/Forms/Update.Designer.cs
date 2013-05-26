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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Update : System.Windows.Forms.Form
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
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			base.Load += new System.EventHandler(Update_Load);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1Output = new System.Windows.Forms.Label();
			this.Label2Output = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel1Output = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(12, 165);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(460, 23);
			this.ProgressBar1.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(12, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(82, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Current Version:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(12, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(77, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Latest Version:";
			//
			//Label1Output
			//
			this.Label1Output.AutoSize = true;
			this.Label1Output.Location = new System.Drawing.Point(100, 10);
			this.Label1Output.Name = "Label1Output";
			this.Label1Output.Size = new System.Drawing.Size(13, 13);
			this.Label1Output.TabIndex = 2;
			this.Label1Output.Text = "0";
			//
			//Label2Output
			//
			this.Label2Output.AutoSize = true;
			this.Label2Output.Location = new System.Drawing.Point(100, 35);
			this.Label2Output.Name = "Label2Output";
			this.Label2Output.Size = new System.Drawing.Size(13, 13);
			this.Label2Output.TabIndex = 2;
			this.Label2Output.Text = "0";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(12, 60);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(101, 23);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "Check for Update";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(12, 95);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(101, 23);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Download Update";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(12, 130);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(101, 23);
			this.Button3.TabIndex = 3;
			this.Button3.Text = "Install Update";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//StatusStrip1
			//
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripStatusLabel1, this.ToolStripStatusLabel1Output});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 205);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(484, 22);
			this.StatusStrip1.TabIndex = 4;
			this.StatusStrip1.Text = "StatusStrip1";
			//
			//ToolStripStatusLabel1
			//
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
			this.ToolStripStatusLabel1.Text = "Current Action:";
			//
			//ToolStripStatusLabel1Output
			//
			this.ToolStripStatusLabel1Output.Name = "ToolStripStatusLabel1Output";
			this.ToolStripStatusLabel1Output.Size = new System.Drawing.Size(36, 17);
			this.ToolStripStatusLabel1Output.Text = "None";
			//
			//Update
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 227);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2Output);
			this.Controls.Add(this.Label1Output);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ProgressBar1);
			this.Name = "Update";
			this.Text = "Update";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1Output;
		internal System.Windows.Forms.Label Label2Output;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1Output;
	}
	
}
