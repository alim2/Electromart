<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Electromart.Index" %>

<asp:Content runat="server" ContentPlaceHolderID="index">

    <div id="CategoryDiv" class="container-fluid">
        <div class="row">
            <div class="col-md-2">
                <asp:ImageButton ID="BtnTv" runat="server" OnClick="BtnTv_OnClick" ImageUrl="~/Images/Categories/tv.png" />
            </div>
            <div class="col-md-2">
                <asp:ImageButton ID="BtnLaptop" runat="server" ImageUrl="~/Images/Categories/laptop.png" OnClick="BtnTv_OnClick" />
            </div>
            <div class="col-md-2">
                <asp:ImageButton ID="BtnMonitor" runat="server" ImageUrl="~/Images/Categories/monitor.png" OnClick="BtnTv_OnClick" />
            </div>
            <div class="col-md-2">
                <asp:ImageButton ID="BtnMobile" runat="server" ImageUrl="~/Images/Categories/mobile.png" OnClick="BtnTv_OnClick" />
            </div>
            <div class="col-md-2">
                <asp:ImageButton ID="BtnCamera" runat="server" ImageUrl="~/Images/Categories/camera.png" OnClick="BtnTv_OnClick" />
            </div>
            <div class="col-md-2">
                <asp:ImageButton ID="BtnAccessories" runat="server" ImageUrl="~/Images/Categories/accessories.png" OnClick="BtnTv_OnClick" />
            </div>
        </div>
    </div>


    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <div class="container-fluid NewTopProduct">
                <h3>New Products</h3>
                <div id="NewProductDiv" runat="server"></div>
            </div>
            <div class="container-fluid NewTopProduct">
                <h3>Top Products</h3>
                <div id="TopProductDiv" runat="server"></div>
            </div>
        </asp:View>
        <%--view  2--%>
        <asp:View ID="View2" runat="server">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            <div id="CategoryProducts" runat="server">
            </div>

        </asp:View>
    </asp:MultiView>
    
</asp:Content>