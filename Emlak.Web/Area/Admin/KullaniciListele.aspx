<%@ Page Title="" Language="C#" MasterPageFile="~/Area/Admin/Anasayfa.Master" AutoEventWireup="true" CodeBehind="KullaniciListele.aspx.cs" Inherits="Emlak.Web.Area.Admin.KullaniciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Kullanıcılar</h3>
        </div>

        <div class="card-body table-responsive p-0">
            <table class="table table-hover text-nowrap">
                <asp:Repeater ID="KullaniciTablo" runat="server" OnItemCommand="KullaniciTabloCommand">
                    <HeaderTemplate>
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Ad</th>
                                <th>Soyad</th>
                                <th>Telefon</th>
                                <th>Adres</th>
                                <th>Eposta</th>
                                <th>Kullanıcı Adı</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td><%# Eval("Ad") %></td>
                            <td><%# Eval("Soyad") %></td>
                            <td><%# Eval("Telefon") %></td>
                            <td><%# Eval("Adres") %></td>
                            <td><%# Eval("Eposta") %></td>
                            <td><%# Eval("KullaniciAdi") %></td>
                            <td class="text-right">
                                <asp:LinkButton CssClass="btn btn-info" ID="LinkButton1" runat="server" CommandName="kullaniciGuncelle" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-danger" ID="LinkButton2" runat="server" CommandName="kullaniciSil" CommandArgument='<%# Eval("Id") %>'>
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
