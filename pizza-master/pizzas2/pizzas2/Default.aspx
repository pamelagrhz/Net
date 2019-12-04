<%@ Page Language="C#" CodeFile="Default.aspx.cs" Inherits="pizzas2.Default" %>
<script runat="server"></script>
<html>
    <head runat="server">
        <title>Pizzas</title>
    </head>
    <body>
        <h1>Tarea pizzas</h1>
        <form id="form1"runat="server">
            <table>
                <tr>
                    <td>
                        <h1>Ingredientes Disponibles</h1>
                        <asp:ListBox runat="server" id="lista1"></asp:ListBox><br>
                        <asp:TextBox runat="server" id="txtNombre" placeholder="Nombre"></asp:TextBox>
                        <asp:TextBox runat="server" id="txtCalorias" placeholder="Calorias"></asp:TextBox>
                        <asp:Button runat="server" Text="Agregar" id="BtnAgregar" OnClick="BtnAgregar_Click"></asp:Button>
                    </td>
                    
                    <td>
                        <asp:Button runat="server" id="Btn_pasar" Text=">>" OnClick="BtnPasar_Click"/><br>
                        <asp:Button runat="server" Text="&lt; &lt" Onclick="BtnQuitar_Click"/><br>
                    
                    </td>
                    <td>
                        <h1>Pizza</h1>
                        <asp:ListBox runat="server" id="lista2"></asp:ListBox><br>
                        <asp:Label runat="server" Text="Total de Calorias: "/>
                        <asp:Label runat="server" id="totalCalorias" />
                    </td>
                </tr>
            </table>
            
      </form>
    </body>
    
</html>
