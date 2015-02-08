<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FrmListadoPersonal.aspx.cs" Inherits="RRHH.FrmListadoPersonal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PnlListado" runat="server">
    <table width="100%">
    <tr>
        <td colspan="3">
            <asp:Label ID="Label1" runat="server" Text="LISTADO DE POSTULANTE" CssClass="titulo"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Ingrese Dni" CssClass="textB"></asp:Label>
            <asp:TextBox ID="txtBuscar" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td>
        <td align="left">
            <asp:Label ID="Label15" runat="server" Text="Seleccione Campaña" CssClass="textB"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="ddlCampaña" runat="server" CssClass="cajatexto">
                <asp:ListItem Value="0">Seleccione</asp:ListItem>
                <asp:ListItem Value="1">Campaña 1</asp:ListItem>
                <asp:ListItem Value="2">Campaña 2</asp:ListItem>
                <asp:ListItem Value="3">Campaña 3</asp:ListItem>
            </asp:DropDownList>
            
        </td>
        <td>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="boton" 
                 />
                <asp:Button ID="Button1" runat="server" Text="Nuevo" CssClass="boton" 
                onclick="btnNuevo_Click" /></td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="gvListado" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" AutoGenerateColumns="False" OnRowCommand="gvListado_RowCommand" DataKeyNames="codigoDNI">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                 <RowStyle CssClass="gridItemGroup" Height="19px" BackColor="#F7F6F3" 
                    ForeColor="#333333"></RowStyle>
                <Columns>
                    <asp:BoundField DataField="nombres" HeaderText="NOMBRES" />
                    <asp:BoundField DataField="apePat" HeaderText="PATERNO" />
                    <asp:BoundField DataField="apeMat" HeaderText="MATERNO" />
                    <asp:BoundField DataField="codigoDNI" HeaderText="NRO DOCUMENTO" />
                    <asp:BoundField DataField="codigoDepartamento" HeaderText="DEPARTAMENTO" />
                    <asp:BoundField DataField="codigoProvincia" HeaderText="PROVINCIA" />
                    <asp:BoundField DataField="codigoDistrito" HeaderText="DISTRITO" />
                    <asp:BoundField DataField="direccion" HeaderText="DOMICILIO" />
                   <%--  <asp:TemplateField HeaderStyle-Width="2%">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgEditar" runat="server" CommandArgument='<% # Container.DataItemIndex %>'
                            CommandName="Edt" CssClass="detail" Height="14px" ImageUrl="~/Imagenes/btnEdit.png"
                            ToolTip="Editar" />
                            <asp:ImageButton ID="imgEliminar" runat="server" CommandArgument='<% # Container.DataItemIndex %>'
                            CommandName="Del" CssClass="detail" Height="14px" ImageUrl="~/Imagenes/btnDelete.png"
                            ToolTip="Eliminar" OnClientClick="return confirm('¿Seguro de elimnar al personal?');" />
                    </ItemTemplate>
                         <HeaderStyle Width="2%" />
                    <ItemStyle HorizontalAlign="Center" Width="15px"></ItemStyle>
                </asp:TemplateField>--%>
                                                                  
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
    </tr>
    </table>
    </asp:Panel>
    <asp:Panel ID="PnlMantenimiento" runat="server">
    <table width="100%">
    <tr><td colspan="4" align="left">
        <asp:Label ID="Label3" runat="server" Text="REGISTRO DE PERSONAL" CssClass="titulo" ></asp:Label> </td></tr>
    <tr><td style="width:200px">
        <asp:Label ID="Label4" runat="server" Text="Ingrese numero de DNI" CssClass="textB"></asp:Label>
        </td><td align="left" style="width:180px">
            <asp:TextBox ID="txtBuscar_DNI" runat="server" CssClass="cajatexto"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Imagenes/btnSearch.gif" onclick="ImageButton1_Click" />
        </td><td></td><td style="width:180px"></td><td rowspan="6">
        <asp:Image ID="imgFoto" runat="server" Width="80px" Height="80px"  Visible=false/>
        </td></tr>
    <tr><td align="left">
        <asp:Label ID="Label5" runat="server" Text="Nombres"></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtNombre" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td><td>&nbsp;</td><td></td></tr>
    <tr><td style="width:180px" align="left">
        <asp:Label ID="Label6" runat="server" Text="Apellido Paterno" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtPaterno" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td><td style="width:180px" align="left">
        <asp:Label ID="Label8" runat="server" Text="Apellido Materno" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtMaterno" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td></tr>
        <tr><td style="width:180px" align="left">
        <asp:Label ID="Label9" runat="server" Text="Estado Civil" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtEstadoCivil" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td><td style="width:180px" align="left">
        <asp:Label ID="Label10" runat="server" Text="Sexo" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtSexo" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td></tr>
        <tr><td style="width:180px" align="left">
            <asp:Label ID="Label16" runat="server" Text="Telefono" ></asp:Label>  </td>
            <td align="left"> 
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="cajatexto"></asp:TextBox></td>
                <td style="width:180px" align="left"><asp:Label ID="Label18" runat="server" Text="Correo"></asp:Label></td>
                <td align="left"><asp:TextBox ID="txtCorreo" runat="server" CssClass="cajatexto"></asp:TextBox></td>
                </tr>
        
        <tr>
            

            <td align="left" style="width:180px">
                <asp:Label ID="Label11" runat="server" Text="Nacionalidad"></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="cajatexto"></asp:TextBox>
            </td>
            <td align="left" style="width:180px">
                <asp:Label ID="Label12" runat="server" Text="Departamento"></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox ID="txtDepartamento" runat="server" CssClass="cajatexto"></asp:TextBox>
            </td>
        </tr>
        <tr><td style="width:180px" align="left">
        <asp:Label ID="Label13" runat="server" Text="Provincia" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtProvincia" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td><td style="width:180px" align="left">
        <asp:Label ID="Label14" runat="server" Text="Distrito" ></asp:Label>
        </td><td align="left">
            <asp:TextBox ID="txtDistrito" runat="server" CssClass="cajatexto"></asp:TextBox>
        </td></tr>
        <tr><td align="left">
    <asp:Label ID="Label7" runat="server" Text="Domicilio" ></asp:Label>
    </td><td align="left" colspan="2"> 
            <asp:TextBox ID="txtDomicilio" runat="server" CssClass="cajatexto" Width="250px"></asp:TextBox>
        </td><td></td></tr>

        
        <tr>
            <td align="left"> <asp:Label ID="Label17" runat="server" Text="AceptaoNO" ></asp:Label></td>
            <td align="left" colspan="2"> <asp:DropDownList ID="ddlAcepta" runat="server" CssClass="cajatexto">
                <asp:ListItem Value="0">Seleccion</asp:ListItem>
                <asp:ListItem Value="1">Favorable</asp:ListItem>
                <asp:ListItem Value="2">Desfavorable</asp:ListItem>
                </asp:DropDownList>  </td>
            <td>
                &nbsp;</td>
        </tr>

        
        <tr><td>
            <asp:HiddenField ID="hdnIdPersonal" runat="server" />
        </td></tr>

         <tr><td align="left">
    
    </td><td align="center" colspan="2"> 
        <asp:Button ID="btnCambio" runat="server"  CssClass="boton" onclick="btnCambio_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="boton" 
                     onclick="btnCancelar_Click"  />
        </td><td></td></tr>
    
    </table>
    </asp:Panel>
    
</asp:Content>
