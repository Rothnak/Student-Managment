<%@ Page language="c#" Codebehind="PopupCalendar.aspx.cs" AutoEventWireup="false" Inherits="WebCalendarTest.PopupCalendar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>PopupCalendar</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript" type="text/javascript">			
			function calendarPicker(strTxtRef)
			{										 									 
				window.open('./Controls/Calendar.aspx?field=' + strTxtRef +'','calendarPopup','titlebar=no,left=470,top=100,width=300,height=250,resizable=no');				
			}		
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="Medium">ASP.NET Web Calendar on PopUp Window</asp:Label>
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
						<asp:TextBox ID="txtDOB" Runat="server"></asp:TextBox>
						<asp:HyperLink id="imgDate" runat="server" ImageUrl="Images/pdate.gif">HyperLink</asp:HyperLink>
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
