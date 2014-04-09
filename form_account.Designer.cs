/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 4/8/2014
 * Time: 7:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Steam_Account_Manager
{
	partial class form_account
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_account));
			this.label_username = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.text_password = new System.Windows.Forms.MaskedTextBox();
			this.text_username = new System.Windows.Forms.TextBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_username
			// 
			this.label_username.Location = new System.Drawing.Point(7, 5);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(59, 23);
			this.label_username.TabIndex = 0;
			this.label_username.Text = "Username:";
			this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_password
			// 
			this.label_password.Location = new System.Drawing.Point(7, 31);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(59, 23);
			this.label_password.TabIndex = 1;
			this.label_password.Text = "Password:";
			this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// text_password
			// 
			this.text_password.Location = new System.Drawing.Point(72, 33);
			this.text_password.Name = "text_password";
			this.text_password.PromptChar = '0';
			this.text_password.Size = new System.Drawing.Size(193, 20);
			this.text_password.TabIndex = 2;
			this.text_password.UseSystemPasswordChar = true;
			// 
			// text_username
			// 
			this.text_username.Location = new System.Drawing.Point(72, 7);
			this.text_username.Name = "text_username";
			this.text_username.Size = new System.Drawing.Size(193, 20);
			this.text_username.TabIndex = 1;
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(190, 59);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(75, 23);
			this.button_add.TabIndex = 3;
			this.button_add.Text = "Add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.Button_addClick);
			// 
			// button_cancel
			// 
			this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_cancel.Location = new System.Drawing.Point(109, 59);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 4;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.Button_cancelClick);
			// 
			// form_account
			// 
			this.AcceptButton = this.button_add;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button_cancel;
			this.ClientSize = new System.Drawing.Size(276, 89);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_add);
			this.Controls.Add(this.text_username);
			this.Controls.Add(this.text_password);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_username);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "form_account";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Account";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form_accountLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_username;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.MaskedTextBox text_password;
		private System.Windows.Forms.TextBox text_username;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_cancel;
	}
}
