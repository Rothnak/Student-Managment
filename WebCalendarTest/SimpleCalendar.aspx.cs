
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebCalendarTest
{
	/// <summary>
	/// Summary description for SimpleCalendar.
	/// <author url="http://michaelsync.net">Michael Sync</author>	
	/// </summary>
	public class SimpleCalendar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox txtName;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.TextBox txtDOB;
		protected System.Web.UI.WebControls.Button btnDOB;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.TextBox txtAddress;
		protected System.Web.UI.WebControls.Button btnSave;
		protected System.Web.UI.WebControls.Calendar cdrCalendar;
		protected System.Web.UI.WebControls.Label Label1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnDOB.Click += new System.EventHandler(this.btnDOB_Click);
			this.cdrCalendar.SelectionChanged += new System.EventHandler(this.cdrCalendar_SelectionChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnDOB_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(txtDOB.Text.Trim() != "") cdrCalendar.SelectedDate = Convert.ToDateTime(txtDOB.Text);
			}
			catch
			{
			}
			cdrCalendar.Visible= true;
		}

		private void cdrCalendar_SelectionChanged(object sender, System.EventArgs e)
		{
			txtDOB.Text = cdrCalendar.SelectedDate.ToString();
			cdrCalendar.Visible= false;
		}
	}
}
