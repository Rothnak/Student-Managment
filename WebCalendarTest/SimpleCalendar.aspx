<%@ Page language="c#" Codebehind="SimpleCalendar.aspx.cs" AutoEventWireup="false" Inherits="WebCalendarTest.SimpleCalendar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SimpleCalendar</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="Medium">ASP.NET Web Calendar - Simple Example</asp:Label>
			<HR style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 32px" width="100%" SIZE="1">
			<table cellpadding="0" cellspacing="0" border="0">
				<tr height="50">
					<td width="100">&nbsp;</td>
					<td></td>
					<td width="20">&nbsp;</td>
					<td></td>
				</tr>
				<tr>
					<td></td>
					<td><asp:Label id="Label2" runat="server">Name</asp:Label></td>
					<td></td>
					<td>
						<asp:TextBox ID="txtName" Runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td></td>
					<td><asp:Label id="Label3" runat="server">Date Of Birth</asp:Label></td>
					<td></td>
					<td>
						<asp:TextBox ID="txtDOB" Runat="server"></asp:TextBox><asp:Button ID="btnDOB" Runat="server" Text="..."></asp:Button>
					</td>
				</tr>
				<tr>
					<td></td>
					<td></td>
					<td></td>
					<td>
						<asp:calendar id="cdrCalendar" runat="server" backcolor="#ffffff" width="250px" height="200px"
							font-size="12px" font-names="Arial" borderwidth="2px" bordercolor="#000000" nextprevformat="shortmonth"
							daynameformat="firsttwoletters" Visible="False">
							<TodayDayStyle ForeColor="White" BackColor="Black"></TodayDayStyle>
							<NextPrevStyle Font-Size="12px" Font-Bold="True" ForeColor="#333333"></NextPrevStyle>
							<DayHeaderStyle Font-Size="12px" Font-Bold="True"></DayHeaderStyle>
							<TitleStyle Font-Size="14px" Font-Bold="True" BorderWidth="2px" ForeColor="#000055"></TitleStyle>
							<OtherMonthDayStyle ForeColor="#CCCCCC"></OtherMonthDayStyle>
						</asp:calendar>
					</td>
				</tr>
				<tr>
					<td></td>
					<td valign="top"><asp:Label id="Label4" runat="server">Address</asp:Label></td>
					<td></td>
					<td>
						<asp:TextBox ID="txtAddress" Runat="server" Height="64px" TextMode="MultiLine"></asp:TextBox>
					</td>
				</tr>
				<tr height="10">
					<td></td>
					<td></td>
					<td></td>
					<td></td>
				</tr>
				<tr>
					<td></td>
					<td></td>
					<td></td>
					<td><asp:Button ID="btnSave" Runat="server" Text="Save"></asp:Button></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
