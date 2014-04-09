/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 4/8/2014
 * Time: 11:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Steam_Account_Manager
{
	partial class form_notes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_notes));
			this.text_notes = new System.Windows.Forms.TextBox();
			this.button_save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// text_notes
			// 
			this.text_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.text_notes.Location = new System.Drawing.Point(0, 1);
			this.text_notes.Multiline = true;
			this.text_notes.Name = "text_notes";
			this.text_notes.Size = new System.Drawing.Size(368, 270);
			this.text_notes.TabIndex = 0;
			// 
			// button_save
			// 
			this.button_save.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button_save.Location = new System.Drawing.Point(0, 272);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(368, 31);
			this.button_save.TabIndex = 1;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.Button_saveClick);
			// 
			// form_notes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 303);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.text_notes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "form_notes";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Notes";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox text_notes;
		private System.Windows.Forms.Button button_save;
	}
}
