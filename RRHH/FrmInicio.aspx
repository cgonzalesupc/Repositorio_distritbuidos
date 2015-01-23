<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmInicio.aspx.cs" Inherits="RRHH.FrmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
 <ContentTemplate>
 <table width="100%">
  <tr>
                    <td align="center" style="height: 7px;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#443735" Text="BIENVENIDO AL SISTEMA DE RECURSOS HUMANOS UPC"
                            Width="472px" Font-Size="Medium"></asp:Label>
                        <br />
                    </td>
   </tr>
   <tr>
                    <td style="width: 100%;">
                        <table style="width: 100%;">
                            <tr>
                                <td colspan="4" valign="bottom" align="left">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#D0AE1E" CssClass="titulo"
                                        Font-Size="Small"></asp:Label>
                                </td>
                            </tr>
                              <tr style="height: 100px;">
                                <td colspan="4" valign="top" align="left">
                                    <asp:Label ID="Label4" runat="server" Font-Bold="true" CssClass="titulo"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Font-Bold="true" CssClass="titulo"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
 </table>
 </ContentTemplate>
 </asp:UpdatePanel>
</asp:Content>

