<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="Electromart.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="index" runat="server">
     <div id="CategoryDiv" class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/em1.png" PostBackUrl="~/Index.aspx" />
            </div>
            <div class="col-md-4">
                <h3 style="margin-top: 20px">Product Information</h3>
            </div>
            </div>
         </div>
    
    <br />
    <br /><br />
    <div class="container">
        <label>Product Name : </label>
        <asp:Label ID="ProductName" runat="server" Text="Label"></asp:Label>

    </div>
</asp:Content>
