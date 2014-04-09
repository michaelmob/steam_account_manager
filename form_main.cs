using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Steam_Account_Manager
{
	
	public partial class form_main : Form
	{
		
		public form_main()
		{
			InitializeComponent();
		}
		
		string find_steam_location() {
			foreach (Process Proc in Process.GetProcessesByName("Steam"))
			{
			    string fullpath = Proc.MainModule.FileName;
			    return fullpath;
			}
			
			return null;
		}
		
		string base64_encode(string str) {
			return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(str));
		}
		
		string base64_decode(string str) {
			return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(str));
		}
		
		void kill_steam() {
			try {
				Process[] proc = Process.GetProcessesByName("Steam");
				proc[0].Kill();
			} catch { }
		}
		
		void login_steam(string steam_location, string username, string password) {
			Process.Start(steam_location, " -login " + username + " " + base64_decode(password));
		}
		
		void write_settings() {
			string output = "";
			
			foreach(ListViewItem item in list_accounts.Items) {
				for(int i = 0; i < item.SubItems.Count; i++)
					output += item.SubItems[i].Text.Replace("|", "/") + "|";
				output += Environment.NewLine;
			}
			
			File.WriteAllText("save.dat", output);
		}
		
		void read_settings() {
			if(!File.Exists("save.dat"))
				return;
			
			var file = new StreamReader("save.dat");
			string line;
			
			while((line = file.ReadLine()) != null)
			{
				string[] data = line.Split('|');
				
        		var item = new ListViewItem(data); 
        		list_accounts.Items.Add(item);
			}
			
			file.Close();
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			read_settings();
			Button_get_steam_processClick(sender, e);
		}
		
		void LoginToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			if(list_accounts.SelectedItems.Count == 1) {
				list_accounts.SelectedItems[0].SubItems[2].Text = DateTime.Now.ToString("dd/MM/yyyy");
				kill_steam();
				login_steam(text_steam_location.Text, list_accounts.SelectedItems[0].SubItems[0].Text, list_accounts.SelectedItems[0].SubItems[1].Text);
			}
			
			write_settings();
		}
		
		void Button_get_steam_processClick(object sender, System.EventArgs e)
		{
			string steam_location = find_steam_location();
			if(steam_location != null)
				text_steam_location.Text = steam_location;
			else
				MessageBox.Show("Steam is not running.", "Error");
		}
		
		void AddAccountToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			var form_account = new form_account();
			if (form_account.ShowDialog(this) == DialogResult.OK) {
				string[] row = { form_account.username, base64_encode(form_account.password), "", "" };
        		var item = new ListViewItem(row); 
        		list_accounts.Items.Add(item);
				write_settings();
			}
		}
		void DeleteToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			foreach(ListViewItem item in list_accounts.SelectedItems) {
				item.Remove();
			}
			
			write_settings();
		}
		void NotesToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			if(list_accounts.SelectedItems.Count == 1) {
				var form_notes = new form_notes(list_accounts.SelectedItems[0].SubItems[3].Text);
				
				if (form_notes.ShowDialog(this) == DialogResult.OK) {
	        		list_accounts.SelectedItems[0].SubItems[3].Text = form_notes.notes;
				}
			}
			
			write_settings();
		}
		
		void ShutdownSteamToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			kill_steam();
		}
		
		void Link_githubLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/TheTarkus");
		}
		
	}
}
