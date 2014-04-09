using System;
using System.Windows.Forms;

namespace Steam_Account_Manager
{
	public partial class form_account : Form
	{
		public string username { get;set; }
		public string password { get;set; }
		
		public form_account()
		{
			InitializeComponent();
		}
		
		void Button_addClick(object sender, System.EventArgs e)
		{
			if(text_username.Text == "" || text_password.Text == "") {
				Button_cancelClick(sender, e);
				return;
			}
			
			this.username = text_username.Text;
			this.password = text_password.Text;
			this.DialogResult = DialogResult.OK;
		}
		
		void Button_cancelClick(object sender, System.EventArgs e)
		{
			this.Dispose();
		}
		void Form_accountLoad(object sender, System.EventArgs e)
		{
			
		}
		
	}
}
