<%@ Page Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfclStock.aspx.cs" Inherits="web_add.wfclStock" %>
<%@ Register Src="./CU_clStock.ascx"
    tagname="CU_clStock" TagPrefix="uc1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_clStock ID="CU_clStock1" runat="server" />
</asp:Content>
