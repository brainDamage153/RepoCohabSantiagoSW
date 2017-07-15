<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresoTrabajador.aspx.cs" Inherits="CohabManager.IngresoTrabajador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

              <div id="head">
            <div class="line">
               <h1>&nbsp;INGRESO PERSONAL</h1>
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
                            <asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox>
                            <%--<input name="txtFechaIngreso" placeholder="Fecha Ingreso" title="Your name" type="text" />--%>
                        </div>
                        <div class="s-12 l-7">
                             <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                            <div class="s-12 m-6 l-4">
                             <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" BackColor="gray" OnClick="btnIngresar_Click"/>
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
