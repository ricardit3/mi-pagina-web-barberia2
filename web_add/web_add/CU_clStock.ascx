<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_clStock.ascx.cs" Inherits="web_add.CU_clStock" %>
<asp:GridView ID="rgvclStock" runat="server"  AutoGenerateColumns="false">
   <Columns> 
       <asp:BoundField DataField="IdUnidadDeMedida" HeaderText="IdUnidadDeMedida" />
       <asp:BoundField DataField="NombreUnidadDeMedida" HeaderText="NombreUnidadDeMedida" />
       <asp:BoundField DataField="Abreviacion" HeaderText="Abreviacion" />
       <asp:BoundField DataField="FechaRegistro" HeaderText="FechaRegistro" />
       <asp:BoundField DataField="EstadoRegistro" HeaderText="EstadoRegistro" />
   </Columns>
    </asp:GridView>
