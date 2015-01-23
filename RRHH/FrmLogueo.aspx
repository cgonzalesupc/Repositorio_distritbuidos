<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogueo.aspx.cs" Inherits="RRHH.FrmLogueo" %>

<%@ Register Assembly="System.Web.Extensions" Namespace="System.Web.UI" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>.: UPC :.</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
    <link href="Styles/EstiloPrincipal.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
        top.window.moveTo(0, 0)
        if (document.all) {
            top.window.resizeTo(screen.availWidth, screen.availHeight);
        }
        else if (document.layers || document.getElementById) {
            if (top.window.outerHeight < screen.availHeight || top.window.outerWidth < screen.availWidth) {
                top.window.outerWidth = screen.availWidth
                top.window.outerHeight = screen.availHeight
            }
        }

        function load() {
            if (navigator.appName != "Microsoft Internet Explorer")
                document.location.href = 'http://www.google.com.pe/';
        }
    </script>
</head>
<body style="margin: 0px; background-image: url('Imagenes/repeat_bg.jpg'); vertical-align: top;
    ">
    <form id="form1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" 
        style="background-image: url('Imagenes/head_repeater.png');
        background-repeat: repeat-x; width: 100%; height: 100%; text-align: center">
        <tr>
            <td align="center" valign="top">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <table border="0" cellpadding="0" cellspacing="0" style="background-image: url('Imagenes/login_STD1.jpg');
                    background-repeat: no-repeat; height: 609px" width="940">
                    <tr>
                        <td style="vertical-align: top; height: 281px;">
                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 434px;">
                                <tr>
                                    <td style="width: 783px; height: 241px;">
                                    </td>
                                    <td style="width: 440px; height: 241px;">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 783px; height: 208px; vertical-align: top; text-align: right;">
                                    </td>
                                    <td style="padding-left: 30px; height: 200px;" align="left" valign="top">
                                        <asp:UpdatePanel ID="PanelMantenimiento" runat="server">
                                            <ContentTemplate>
                                                <table border="0" cellpadding="0" cellspacing="0" style="width: 120px">
                                                    <tbody>
                                                        <tr>
                                                            <td align="left" style="width: 120px; height: 144px">
                                                                <table border="0" cellpadding="0" cellspacing="0" style="width: 168px; height: 126px;">
                                                                    <tr>
                                                                        <td align="left" valign="top" style="height: 56px;">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="padding-left: 1px;" align="left" valign="top">
                                                                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100px">
                                                                                <tr>
                                                                                    <td style="width: 100px; height: 20px;" align="center">
                                                                                        <asp:TextBox ID="txtUsuario" runat="server" Width="126px" BackColor="Transparent"
                                                                                            BorderColor="Transparent" BorderStyle="None" AutoCompleteType="Disabled" 
                                                                                            CssClass="cajatexto" MaxLength="20"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="left" style="width: 35px; padding-top: 3px; height: 33px; text-align: center"
                                                                            valign="top">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="height: 35px; padding-left: 1px;" align="left" valign="top">
                                                                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100px">
                                                                                <tr>
                                                                                    <td style="width: 100px;" align="center">
                                                                                        <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" Width="126px"
                                                                                            BackColor="Transparent" BorderColor="Transparent" BorderStyle="None" 
                                                                                            CssClass="cajatexto" MaxLength="20"></asp:TextBox>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td align="left" valign="top" style="width: 31px; height: 39px; padding-left: 31px;
                                                                            text-align: left;">
                                                                          
                                                                            <asp:ImageButton ID="btnIngresar" runat="server" ImageUrl="~/Imagenes/btn_STD.jpg"
                                                                                 Height="30px" Width="70px" onclick="btnIngresar_Click" />
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 281px">
                                                                <asp:HiddenField ID="hdnCodUsuario" runat="server" />
                                                                <asp:HiddenField ID="hdn1" runat="server" />
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
