<%@ Page Title="" Language="C#" MasterPageFile="~/Area/Admin/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KategoriListele.aspx.cs" Inherits="Emlak.Web.Area.Admin.KategoriListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Kategoriler</h3>
        </div>

        <div class="card-body table-responsive p-0">
            <table class="table table-hover text-nowrap">
                <asp:Repeater ID="KategoriTablo" runat="server" OnItemCommand="KategoriTabloCommand">
                    <HeaderTemplate>
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Kategori Adı</th>
                                <th>Açıklama</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td><%# Eval("KategoriAdi") %></td>
                            <td><%# Eval("Aciklama") %></td>
                            <td class="text-right">
                                <asp:LinkButton CssClass="btn btn-info" ID="LinkButton1" runat="server" CommandName="kategoriGuncelle" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-danger" ID="LinkButton2" runat="server" CommandName="kategoriSil" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-trash"></i>
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                    </FooterTemplate>
                </asp:Repeater>
            </table>
        </div>

    </div>
</asp:Content>
