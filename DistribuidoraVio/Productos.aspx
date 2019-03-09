<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Productos.aspx.cs" Inherits="Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderScripts" Runat="Server">
    <script src="./Scripts/Productos.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderBody" Runat="Server">
    <h3>Sección Productos</h3>
    <div class="col-md-4">
        <input id="img" class="form-control-file" type="file" />
        <br />
        <button id="btn" class="btn btn-default">Guardar</button>
        <hr />
        <input id="inputFileToLoad" type="file" onchange="encodeImageFileAsURL();" />
    <div id="imgTest"></div>
    </div>
    

</asp:Content>

