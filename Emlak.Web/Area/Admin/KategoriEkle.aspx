<%@ Page Title="" Language="C#" MasterPageFile="~/Area/Admin/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="Emlak.Web.Area.Admin.KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Kategori Ekle</h3>
        </div>
        <div class="card-body">
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="KategoriAdi" class="col-sm-2 col-form-label">Kategori Adı</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="KategoriAdi" placeholder="Kategori Adı"/>
                </div>
            </div>
            <div class="form-group row">
                <asp:Label runat="server" AssociatedControlID="Aciklama" class="col-sm-2 col-form-label">Açıklama</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox CssClass="form-control" runat="server" ID="Aciklama" placeholder="Açıklama"/>
                </div>
            </div>
        </div>
        <div class="card-footer">
            <asp:Button CssClass="btn btn-info" runat="server" OnClick="Kaydet_Click" Text="Kaydet" />
        </div>
    </div>
</asp:Content>
