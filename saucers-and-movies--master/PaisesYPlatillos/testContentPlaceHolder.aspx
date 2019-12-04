<%@ Page Language="C#" Inherits="PaisesYPlatillos.testContentPlaceHolder" MasterPageFile="~/MasterPage.master"  %>

<asp:Content ContentPlaceHolderID="test" runat="server">
    <h1>Testaspx</h1>
<h1>Catalogo de Comida</h1>
    <asp:Label runat="server">Nombre</asp:Label>
    <asp:TextBox runat="server" id="txtComida" /><br />
    <asp:Label runat="server">Pais de Origen</asp:Label>
    <asp:DropDownList runat="server" id="cboPais" /><br /><!-- mandamos a llamar a la tabla en Default.aspx.cs-->
    
    <asp:DataGrid id="Grid" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundColumn 
                 HeaderText="Id" 
                 DataField="Id"/>
            
            <asp:BoundColumn 
                 HeaderText="Nombre" 
                 DataField="Name"/>
            
            <asp:BoundColumn 
                 HeaderText="País" 
                 DataField="PaisNombre"/>
        </Columns>
        
    </asp:DataGrid>
    
    <asp:Button id="btnAgregar" runat="server" Text="Agregar"/>
    <asp:Button id="btnEliminar" runat="server" Text="Eliminar"/>
    <asp:Button id="btnEditar" runat="server" Text="Editar"/>
    
    
</asp:Content>