﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresoLuchador.aspx.cs" Inherits="CohabManager.IngresoLuchadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

              <div id="head">
            <div class="line">
               <h1>&nbsp;INGRESO LUCHADORES</h1>
            </div>
         </div>
         <div id="content" class="left-align contact-page">
            <div class="line">
               <div class="margin">
                  <div class="s-12 l-6">
                     <h2>Datos</h2>
                     <form class="customform" runat="server" action="">
                        <div class="s-12 l-7">
                            <asp:TextBox ID="txtRut" runat="server" ></asp:TextBox>
                            <%--<input name="txtRut" placeholder="Rut" title="Your e-mail" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                           <%-- <input name="txtNombre" placeholder="Nombre" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                            <%--<input name="txtApellido" placeholder="Apellido" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
                            <%--<input name="txtFechaNac" placeholder="Fecha Nacimiento" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:DropDownList ID="ddlCinturon" runat="server">
                                 <asp:ListItem Text="Cinturon" Value="0"></asp:ListItem>
                                 <asp:ListItem Text="Blanco" Value="1"></asp:ListItem>
                                 <asp:ListItem Text="Azul" Value="2"></asp:ListItem>
                                 <asp:ListItem Text="Morado" Value="3"></asp:ListItem>
                                 <asp:ListItem Text="Café" Value="4"></asp:ListItem>
                                 <asp:ListItem Text="Negro" Value="5"></asp:ListItem>
                             </asp:DropDownList>
                            
                            <%--<input name="txtCinturon" placeholder="Cinturon" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                            <asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox>
                            <%--<input name="txtFechaIngreso" placeholder="Fecha Ingreso" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                            <div class="s-12 m-6 l-4">
                             <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" BackColor="gray"/>
                              <%-- <button type="submit">Ingresar</button>--%>
                         </div>
                            <%--<input name="txtDireccion" placeholder="Dirección" title="Your name" type="text" />--%>
                        </div>  
                        <%--<div class="s-12"><textarea placeholder="Your massage" name="" rows="5"></textarea></div>--%>
                         
                         
                     </form>
                       
                  </div>
               </div>
            </div>
         </div>


</asp:Content>
