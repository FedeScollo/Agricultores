<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="webAgricultor.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMensajeCarga" runat="server" Text="Para cargar una parcela, ingrese los siguientes datos: "></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="lblCapataz" runat="server" Text="Capataz"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCapataz" runat="server" Height="16px" style="margin-left: 3px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblNroParcela" runat="server" Text="nro Parcela"></asp:Label>
    <asp:TextBox ID="txtNroParcela" runat="server" style="margin-left: 31px"></asp:TextBox>
    <%--<asp:RegularExpressionValidator ID="Regex1" runat="server" ErrorMessage="Solo se admiten números"
                                          ControlToValidate="txtNroParcela" ValidationExpression ="[0-9]*">
        </asp:RegularExpressionValidator>--%>
    <br />
    <br />
    <asp:Label ID="lblHCultivadas" runat="server" Text="Hectareas Cultivadas"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtHCultivadas" runat="server" Height="16px" style="margin-left: 0px; margin-top: 29px"></asp:TextBox>
<%--<asp:RegularExpressionValidator ID="Regex2" runat="server" ErrorMessage="Solo se admiten números"
                                          ControlToValidate="txtHCultivadas" ValidationExpression ="[0-9]*">
        </asp:RegularExpressionValidator>--%>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblSilo" runat="server" Text="Silo"></asp:Label>
    <asp:TextBox ID="txtSilo" runat="server" style="margin-left: 75px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblHectareasLibres" runat="server" Text="Hectareas Libres"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtHLibres" runat="server" Height="16px" style="margin-left: 3px; margin-top: 28px"></asp:TextBox>
    <%--<asp:RegularExpressionValidator ID="Regex3" runat="server" ErrorMessage="Solo se admiten números"
                                          ControlToValidate="txtHLibres" ValidationExpression ="[0-9]*">
        </asp:RegularExpressionValidator>--%>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblTamanio" runat="server" Text="Tamaño"></asp:Label>
    <asp:TextBox ID="txtTamanio" runat="server" style="margin-left: 53px"></asp:TextBox>
        <%--<asp:RegularExpressionValidator ID="Regex4" runat="server" ErrorMessage="Solo se admiten números"
                                          ControlToValidate="txtHLibres" ValidationExpression ="[0-9]*">
        </asp:RegularExpressionValidator>--%>
    <br />
    <br />
    <asp:Label ID="lblTipoCultivo" runat="server" Text="Tipo de Cultivo"></asp:Label>
    <asp:TextBox ID="txtTipoCultivo" runat="server" Height="16px" style="margin-left: 14px; margin-top: 29px"></asp:TextBox>
    <%--<asp:RegularExpressionValidator ID="Regex5" runat="server" ErrorMessage="Solo se admiten letras"
                                          ControlToValidate="txtTipoCultivo" ValidationExpression ="[A-Za-z]*">
        </asp:RegularExpressionValidator>--%>
    <br />
    <br />
    <br />
    <asp:Button ID="btnAceptar" runat="server" style="margin-left: 248px" Text="Aceptar" Width="76px" OnClick="btnAceptar_Click" />
    <asp:Button ID="btnLimpiar" runat="server" style="margin-left: 64px" Text="Limpiar" Width="73px" OnClick="btnLimpiar_Click" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
