<%@ Page Language="C#" Title="Platillos" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="PaisesYPlatillos.Default2" %>

<asp:Content ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <h1>Catalogo de Peliculas</h1>
    <p>
        <asp:Label runat="server">Nombre</asp:Label>
        <asp:TextBox runat="server" id="movieTitle" placeholder="Escribe el titulo..." />
    </p>
    <p>
        <asp:Label runat="server">Genero</asp:Label>
        <asp:TextBox runat="server" id="movieGenre" placeholder="Escribe el genero..." />
    </p>
    <p>
        <asp:Button id="btnAdd" runat="server" Text="Agregar Nuevo" OnClick="AddMovie"/>
    </p>
    <br />
    
    <asp:DataGrid id="Grid" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundColumn 
                 HeaderText="Id" 
                 DataField="Id"/>
            
            <asp:BoundColumn 
                 HeaderText="Título" 
                 DataField="Title"/>
            
            <asp:BoundColumn 
                 HeaderText="Genero" 
                 DataField="Genre"/>
            

        </Columns>
    </asp:DataGrid>
    <br>
    <asp:Label id="lbl" runat="server" Text="El ID de la pelicula a eliminar es: "></asp:Label>
    <asp:TextBox id="movieId" runat="server" placeholder="ID"></asp:TextBox>
    <asp:Button id="deleteMovie" runat="server" Text="Eliminar" OnClick="DeleteMovie_Click" />
    <br> 
	<br>
    <asp:Label id="lbll" runat="server" Text="El ID de la pelicula a editar es: "></asp:Label>
    <asp:TextBox id="gmovieId" runat="server" placeholder="ID"></asp:TextBox>
	<asp:TextBox id="gmovieGenre" runat="server" placeholder="Genero"></asp:TextBox>
	<asp:TextBox id="gmovieTitle" runat="server" placeholder="Titulo"></asp:TextBox>



    <asp:Button id="editMovie" runat="server" Text="Editar" OnClick="EditItem" />
    <br> 
</asp:Content>
