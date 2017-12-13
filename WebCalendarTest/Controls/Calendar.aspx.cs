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

namespace AspNetCalendarCtlTest
{
	/// <summary>
	/// Summary description for Calender.
	/// </summary>
	public class Calendar : System.Web.UI.Page
	{
		#region "Controls"		
			protected System.Web.UI.WebControls.ImageButton BtnRefresh;
			protected System.Web.UI.WebControls.DropDownList CboYear;
			protected System.Web.UI.WebControls.Label LblYear;
			protected System.Web.UI.WebControls.DropDownList CboMonth;
			protected System.Web.UI.WebControls.Label LblMonth;
			protected System.Web.UI.WebControls.Calendar CdrDatePicker;
			protected System.Web.UI.WebControls.LinkButton hlSelectDate;
			protected System.Web.UI.HtmlControls.HtmlTable TblTimeControl;
		#endregion

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
			this.CboYear.SelectedIndexChanged += new System.EventHandler(this.CboYear_SelectedIndexChanged);
			this.CboMonth.SelectedIndexChanged += new System.EventHandler(this.CboMonth_SelectedIndexChanged);
			this.CdrDatePicker.SelectionChanged += new System.EventHandler(this.CdrDatePicker_SelectionChanged);
			this.hlSelectDate.Click += new System.EventHandler(this.hlSelectDate_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		#region Events		
		private void Page_Load(object sender, System.EventArgs e)
		{			
			for(int i=0;i<12;i++)
				this.CboMonth.Items[i].Text = new DateTime(1,i+1,1).ToString("MMMM"); //MMMM Month Format
		
			if(!Page.IsPostBack)
			{
					
				//Adding the value to Combobox. [1900- thisYear]				
				for(int iYear=1900;iYear <= DateTime.Now.Year;iYear++)
				{
					CboYear.Items.Add(new ListItem(iYear.ToString()));
					//System.Math.Min(System.Threading.Interlocked.Increment(ref iYear), iYear - 1);
					
				}
				refreshControls();
				//Array.Copy(arr, arr.GetLength(1)*4, arrB, 0, arr.GetLength(1));
			}
		}
		private void hlSelectDate_Click(object sender, System.EventArgs e)
		{
			string ReturnDate = CdrDatePicker.SelectedDate.ToString("MM/dd/yyyy");
            returnToPage(ReturnDate);
		}
		private void CdrDatePicker_SelectionChanged(object sender, System.EventArgs e)
		{
			string retDate = CdrDatePicker.SelectedDate.ToString("MM/dd/yyyy");
			returnToPage(retDate);			
		}
		private void CboYear_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setCalendarDate();
		}		
		private void CboMonth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			setCalendarDate();
		}
		#endregion

		#region "Private Methods"		
		private void returnToPage(string retDate)
		{
			//"<script>window.opener." + Request.QueryString("field") + ".value ='" + ReturnDate + "';" + " " + "window.close();</script>")
			Response.Write("<script>window.opener." + Request.QueryString["field"].ToString() + ".value='" + retDate + "';window.close();</script>");
			//Response.Write("<script>alert(window.opener.document.WebForm1.txtDate.value);</script>");
		}
		private void setCalendarDate()
		{
			int day;
			int year = Int32.Parse(CboYear.SelectedValue.ToString());
			int month = Int32.Parse(CboMonth.SelectedValue.ToString());
			day = CdrDatePicker.SelectedDate.Day;
			if (day > DateTime.DaysInMonth(year, month)) 
			{
				day = DateTime.DaysInMonth(year, month);
			}
			CdrDatePicker.VisibleDate = new DateTime(year, month, day);
		}
		private void refreshControls()
		{
			DateTime SelectedDate;
			if (!(Request.QueryString["ShowDate"] == null))
			{
				SelectedDate = System.Convert.ToDateTime(Request.QueryString["ShowDate"]);
				CboYear.SelectedIndex = SelectedDate.Year - 1900;
				CboMonth.SelectedIndex = SelectedDate.Month - 1;				
				CdrDatePicker.VisibleDate = SelectedDate.Date;
			} 
			else 
			{
				CboYear.SelectedIndex = DateTime.Now.Year - 1900;
				CboMonth.SelectedIndex = DateTime.Now.Month - 1;				
				CdrDatePicker.VisibleDate = DateTime.Now.Date;				
			}
		}
		#endregion
		
	}
}
