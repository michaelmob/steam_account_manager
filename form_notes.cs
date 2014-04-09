using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steam_Account_Manager
{
	public partial class form_notes : Form
	{
		public string notes { get;set; }
		
		public form_notes(string _notes)
		{
			InitializeComponent();
			text_notes.Text = _notes.Replace("\n", Environment.NewLine);
		}
		
		void Button_saveClick(object sender, System.EventArgs e)
		{
			this.notes = text_notes.Text.Replace(Environment.NewLine, "\n").Replace("|", "/");
			this.DialogResult = DialogResult.OK;
		}
	}
}
