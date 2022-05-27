<%@ Page Title="" Language="C#" MasterPageFile="~/Area/Admin/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KullaniciGuncelle.aspx.cs" Inherits="Emlak.Web.Area.Admin.KullaniciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Kullanıcı Güncelle</h3>
        </div>
        <div class="card-body">
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Adi" class="col-sm-2 col-form-label">Adı</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Adi" placeholder="Adı" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Soyadi" class="col-sm-2 col-form-label">Soyadı</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Soyadi" placeholder="Soyadı" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Telefon" class="col-sm-2 col-form-label">Telefon</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Telefon" placeholder="Telefon" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Adres" class="col-sm-2 col-form-label">Adres</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Adres" placeholder="Adres" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Eposta" class="col-sm-2 col-form-label">Eposta</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Eposta" placeholder="Eposta" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="KullaniciAdi" class="col-sm-2 col-form-label">Kullanıcı Adı</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="KullaniciAdi" placeholder="Kullanıcı Adı" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Sifre" class="col-sm-2 col-form-label">Şifre</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox TextMode="Password" CssClass="form-control" runat="server" ID="Sifre" placeholder="Şifre" />
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="RolAdi" class="col-sm-2 col-form-label">Rol</asp:Label>
                <asp:DropDownList ID="RolAdi" runat="server" DataSourceID="EmlakSqlDataSource" DataTextField="RolAdi" DataValueField="Id">
                    
                </asp:DropDownList>
                <asp:SqlDataSource ID="EmlakSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:EmlakConnectionString %>" SelectCommand="SELECT [Id], [RolAdi] FROM [Rol]"></asp:SqlDataSource>
            </div>
        </div>
        <div class="card-footer">
            <asp:Button CssClass="btn btn-info" runat="server" OnClick="Kaydet_Click" Text="Kaydet" />
        </div>
    </div>
</asp:Content>
