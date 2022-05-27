<%@ Page Title="" Language="C#" MasterPageFile="~/Area/Admin/Anasayfa.Master" AutoEventWireup="true" CodeBehind="RolListele.aspx.cs" Inherits="Emlak.Web.Area.Admin.RolListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-info">
        <div class="card-header">
            <h3 class="card-title">Roller</h3>
        </div>

        <div class="card-body table-responsive p-0">
            <table class="table table-hover text-nowrap">
                <asp:Repeater ID="RolTablo" runat="server" OnItemCommand="RolTabloCommand">
                    <HeaderTemplate>
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Rol Adı</th>
                                <th>Açıklama</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Id") %></td>
                            <td><%# Eval("RolAdi") %></td>
                            <td><%# Eval("Aciklama") %></td>
                            <td class="text-right">
                                <asp:LinkButton CssClass="btn btn-info" ID="LinkButton1" runat="server" CommandName="rolGuncelle" CommandArgument='<%# Eval("Id") %>'>
                                                <i class="fas fa-edit"></i>
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-danger" ID="LinkButton2" runat="server" CommandName="rolSil" CommandArgument='<%# Eval("Id") %>'>
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
