<%@ Page Language="C#" Inherits="oficial2.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		
		<br/>
		<asp:Label id="lbla" runat="server" Text="Valor de a:"></asp:Label>
		<asp:TextBox id="txta" runat="server"></asp:TextBox>
		<br/>
		<asp:Label id="lblb" runat="server" Text="Valor de b:"></asp:Label>
		<asp:TextBox id="txtb" runat="server"></asp:TextBox>
		<br/>
		<asp:Label id="lblc" runat="server" Text="Valor de c:"></asp:Label>
		<asp:TextBox id="txtc" runat="server"></asp:TextBox>
		<br/>
		<asp:Button id="solve" runat="server" Text="Resolver" OnClick="btnsolve"></asp:Button>
		<br/>
		<br/>
		<asp:Button id="new" runat="server" Text="lista" OnClick="btnnew"></asp:Button>
		<br/>
	</form>
</body>
</html>
