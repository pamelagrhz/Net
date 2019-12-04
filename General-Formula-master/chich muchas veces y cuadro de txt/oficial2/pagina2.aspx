<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>pagina2</title>
	<script runat="server">
	
	</script>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<center>
				<li> Ecuacion  , Raices</li>

				<br/>



				<%

					int b=6;
					float x1;
					float x2;
					for(int a=5;  a < 100 ; a++){
						Response.Write(" X^2 + " + a +" X " + " + " + b);


						Response.Write("<br/>");
						b++;
					}

				%>


			</center>
		</div>
	</form>
</body>
</html>
