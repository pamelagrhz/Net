<%@ Page Language="C#" Title="Platillos" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PaisesYPlatillos.Default" %>

<asp:Content ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <h1>Catalogo de Comida</h1>
    <p>
        <asp:Label runat="server">Nombre</asp:Label>
        <asp:TextBox runat="server" id="txtComida" placeholder="Escribe aqui..." />
    </p>
    <p>
        <asp:Label runat="server">Pais de Origen</asp:Label>
        <asp:DropDownList runat="server" id="cboPais" />
    </p>
    <p>
        <asp:Button id="btnAdd" runat="server" Text="Agregar Nuevo" OnClick="AddSaucer"/>
    </p>
    <br />
    
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
    <br>
    <asp:Label id="lbl" runat="server" Text="El ID del platillo a eliminar es: "></asp:Label>
    <asp:TextBox id="saucerId" runat="server"></asp:TextBox>
    <asp:Button id="deleteSaucer" runat="server" Text="Eliminar" OnClick="DeleteSaucer_Click" />
    <br> 
	<br>
    <asp:Label id="idpelicula" runat="server" Text="El ID del platilo  a editar es: "></asp:Label>
    <asp:TextBox id="eSaucerId" runat="server" placeholder="ID"></asp:TextBox>
	<asp:TextBox id="eSaucerName" runat="server" placeholder="Nombre de el platillo"></asp:TextBox>
    <asp:DropDownList runat="server" id="cbaPais" />

    <asp:Button id="editSaucer" runat="server" Text="Editar" OnClick="EditItem" />
</asp:Content>