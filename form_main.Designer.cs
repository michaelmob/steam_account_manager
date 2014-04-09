/*
 * Created by SharpDevelop.
 * User: Mike
 * Date: 4/8/2014
 * Time: 6:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Steam_Account_Manager
{
	partial class form_main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
			this.contextmenu_accounts = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.shutdownSteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tab_options = new System.Windows.Forms.TabPage();
			this.link_github = new System.Windows.Forms.LinkLabel();
			this.about = new System.Windows.Forms.Label();
			this.text_steam_location = new System.Windows.Forms.TextBox();
			this.label_steam_location = new System.Windows.Forms.Label();
			this.button_get_steam_process = new System.Windows.Forms.Button();
			this.tab_accounts = new System.Windows.Forms.TabPage();
			this.list_accounts = new System.Windows.Forms.ListView();
			this.column_username = new System.Windows.Forms.ColumnHeader();
			this.column_password = new System.Windows.Forms.ColumnHeader();
			this.column_last_login = new System.Windows.Forms.ColumnHeader();
			this.column_notes = new System.Windows.Forms.ColumnHeader();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.contextmenu_accounts.SuspendLayout();
			this.tab_options.SuspendLayout();
			this.tab_accounts.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextmenu_accounts
			// 
			this.contextmenu_accounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.loginToolStripMenuItem,
			this.notesToolStripMenuItem,
			this.toolStripMenuItem1,
			this.deleteToolStripMenuItem,
			this.toolStripMenuItem2,
			this.shutdownSteamToolStripMenuItem,
			this.addAccountToolStripMenuItem});
			this.contextmenu_accounts.Name = "contextmenu_accounts";
			this.contextmenu_accounts.Size = new System.Drawing.Size(165, 126);
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.loginToolStripMenuItem.Text = "Login";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItemClick);
			// 
			// notesToolStripMenuItem
			// 
			this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
			this.notesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.notesToolStripMenuItem.Text = "Notes";
			this.notesToolStripMenuItem.Click += new System.EventHandler(this.NotesToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.deleteToolStripMenuItem.Text = "Delete Account";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
			// 
			// shutdownSteamToolStripMenuItem
			// 
			this.shutdownSteamToolStripMenuItem.Name = "shutdownSteamToolStripMenuItem";
			this.shutdownSteamToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.shutdownSteamToolStripMenuItem.Text = "Shutdown Steam";
			this.shutdownSteamToolStripMenuItem.Click += new System.EventHandler(this.ShutdownSteamToolStripMenuItemClick);
			// 
			// addAccountToolStripMenuItem
			// 
			this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
			this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.addAccountToolStripMenuItem.Text = "Add Account";
			this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItemClick);
			// 
			// tab_options
			// 
			this.tab_options.Controls.Add(this.link_github);
			this.tab_options.Controls.Add(this.about);
			this.tab_options.Controls.Add(this.text_steam_location);
			this.tab_options.Controls.Add(this.label_steam_location);
			this.tab_options.Controls.Add(this.button_get_steam_process);
			this.tab_options.Location = new System.Drawing.Point(4, 22);
			this.tab_options.Name = "tab_options";
			this.tab_options.Padding = new System.Windows.Forms.Padding(3);
			this.tab_options.Size = new System.Drawing.Size(631, 418);
			this.tab_options.TabIndex = 1;
			this.tab_options.Text = "Options";
			this.tab_options.UseVisualStyleBackColor = true;
			// 
			// link_github
			// 
			this.link_github.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
			this.link_github.Location = new System.Drawing.Point(139, 82);
			this.link_github.Name = "link_github";
			this.link_github.Size = new System.Drawing.Size(39, 30);
			this.link_github.TabIndex = 6;
			this.link_github.TabStop = true;
			this.link_github.Text = "Github";
			this.link_github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.link_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_githubLinkClicked);
			// 
			// about
			// 
			this.about.Location = new System.Drawing.Point(8, 82);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(125, 30);
			this.about.TabIndex = 5;
			this.about.Text = "Created by Mike Tarkus";
			this.about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_steam_location
			// 
			this.text_steam_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.text_steam_location.Location = new System.Drawing.Point(8, 27);
			this.text_steam_location.Name = "text_steam_location";
			this.text_steam_location.Size = new System.Drawing.Size(615, 20);
			this.text_steam_location.TabIndex = 4;
			// 
			// label_steam_location
			// 
			this.label_steam_location.Location = new System.Drawing.Point(8, 11);
			this.label_steam_location.Name = "label_steam_location";
			this.label_steam_location.Size = new System.Drawing.Size(615, 13);
			this.label_steam_location.TabIndex = 2;
			this.label_steam_location.Text = "Steam Process Location:";
			// 
			// button_get_steam_process
			// 
			this.button_get_steam_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.button_get_steam_process.Location = new System.Drawing.Point(8, 48);
			this.button_get_steam_process.Name = "button_get_steam_process";
			this.button_get_steam_process.Size = new System.Drawing.Size(615, 31);
			this.button_get_steam_process.TabIndex = 1;
			this.button_get_steam_process.Text = "Get Steam Process";
			this.button_get_steam_process.UseVisualStyleBackColor = true;
			this.button_get_steam_process.Click += new System.EventHandler(this.Button_get_steam_processClick);
			// 
			// tab_accounts
			// 
			this.tab_accounts.Controls.Add(this.list_accounts);
			this.tab_accounts.Location = new System.Drawing.Point(4, 22);
			this.tab_accounts.Name = "tab_accounts";
			this.tab_accounts.Padding = new System.Windows.Forms.Padding(3);
			this.tab_accounts.Size = new System.Drawing.Size(631, 418);
			this.tab_accounts.TabIndex = 0;
			this.tab_accounts.Text = "Accounts";
			this.tab_accounts.UseVisualStyleBackColor = true;
			// 
			// list_accounts
			// 
			this.list_accounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.column_username,
			this.column_password,
			this.column_last_login,
			this.column_notes});
			this.list_accounts.ContextMenuStrip = this.contextmenu_accounts;
			this.list_accounts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_accounts.FullRowSelect = true;
			this.list_accounts.GridLines = true;
			this.list_accounts.Location = new System.Drawing.Point(3, 3);
			this.list_accounts.Name = "list_accounts";
			this.list_accounts.Size = new System.Drawing.Size(625, 412);
			this.list_accounts.TabIndex = 0;
			this.list_accounts.UseCompatibleStateImageBehavior = false;
			this.list_accounts.View = System.Windows.Forms.View.Details;
			// 
			// column_username
			// 
			this.column_username.Text = "Username";
			this.column_username.Width = 150;
			// 
			// column_password
			// 
			this.column_password.Text = "Password";
			this.column_password.Width = 150;
			// 
			// column_last_login
			// 
			this.column_last_login.Text = "Last login";
			this.column_last_login.Width = 150;
			// 
			// column_notes
			// 
			this.column_notes.Text = "Notes";
			this.column_notes.Width = 150;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_accounts);
			this.tabControl1.Controls.Add(this.tab_options);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(639, 444);
			this.tabControl1.TabIndex = 1;
			// 
			// form_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 444);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "form_main";
			this.Text = "Steam Account Manager";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextmenu_accounts.ResumeLayout(false);
			this.tab_options.ResumeLayout(false);
			this.tab_options.PerformLayout();
			this.tab_accounts.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel link_github;
		private System.Windows.Forms.Label about;
		private System.Windows.Forms.TextBox text_steam_location;
		private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
		private System.Windows.Forms.Label label_steam_location;
		private System.Windows.Forms.Button button_get_steam_process;
		private System.Windows.Forms.ListView list_accounts;
		private System.Windows.Forms.ColumnHeader column_username;
		private System.Windows.Forms.ColumnHeader column_password;
		private System.Windows.Forms.ColumnHeader column_last_login;
		private System.Windows.Forms.ColumnHeader column_notes;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_accounts;
		private System.Windows.Forms.TabPage tab_options;
		private System.Windows.Forms.ContextMenuStrip contextmenu_accounts;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem shutdownSteamToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
	}
}
