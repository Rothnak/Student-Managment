<%@ Page language="c#" Codebehind="YahooUICalendarSimplePage.aspx.cs" AutoEventWireup="false" Inherits="WebCalendarTest.YahooUICalendarSimplePage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>YahooUICalendarSimplePage</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<!-- Yahoo UI Calendar -->
		<script type="text/javascript" src="./JS/yahoo.js"></script>
		<script type="text/javascript" src="./JS/event.js"></script>
		<script type="text/javascript" src="./JS/dom.js"></script>
		
		<link type="text/css" rel="stylesheet" href="./CSS/fonts.css">
		<link type="text/css" rel="stylesheet" href="./CSS/reset.css">
		<link rel="stylesheet" type="text/css" href="./CSS/dpSyntaxHighlighter.css">
		
		<script type="text/javascript" src="./JS/calendar.js"></script>
		
		<link type="text/css" rel="stylesheet" href="./CSS/calendar.css">
		
		<script language="javascript">
		YAHOO.namespace("example.calendar");
		
		function init() {
		// CALENDAR INIT
		//this.link1 = document.getElementById('dateLink1'); // Moved to showCalendar1()
		YAHOO.example.calendar.cal1 = new YAHOO.widget.Calendar("YAHOO.example.calendar.cal1","cal1Container"); 
		YAHOO.example.calendar.cal1.title = "Select the desired workout day:";
		
		YAHOO.example.calendar.cal1.onSelect = setDate1;
		YAHOO.example.calendar.cal1.render();

		}
		
		function showCalendar1(txtDateClientID,btnCalendarID) {
		   this.link1 = document.getElementById(btnCalendarID);
		   this.oTxtDate = document.getElementById(txtDateClientID);
		   var pos = YAHOO.util.Dom.getXY(link1);
		   YAHOO.example.calendar.cal1.oDomContainer.style.display='block';
		   YAHOO.util.Dom.setXY(YAHOO.example.calendar.cal1.oDomContainer, [pos[0],pos[1]+link1.offsetHeight+1]);
		}
		
		
		function setDate1() {
		   var date1 = YAHOO.example.calendar.cal1.getSelectedDates()[0];
		   YAHOO.example.calendar.cal1.oDomContainer.style.display='none';
		   var formattedDate = date1;		   
		   oTxtDate.value = formattedDate.getDate()+'/'+ (formattedDate.getMonth() +1) +'/'+ formattedDate.getFullYear();		   	  	   
		}
		
		YAHOO.util.Event.addListener(window, "load", init);

		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="cal1Container" style="DISPLAY: none; POSITION: absolute" ></div>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Bold="True" Font-Names="Verdana" Font-Size="Medium">Using Yahoo UI Calendar Control in ASP.NET Page</asp:Label>
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
						<a id="chooseday" onclick="showCalendar1('<% =txtDOB.ClientID %>','imgCalendar')" href="javascript:void(null)">
							<IMG id="imgCalendar" border="0" alt="" src="Images/pdate.gif"> </a>
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
