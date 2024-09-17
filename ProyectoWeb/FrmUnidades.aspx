<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPager.Master" CodeBehind="FrmUnidades.aspx.vb" Inherits="ProyectoWeb.FrmUnidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="content-header">
    <h1>
        <i class="fa fa-file-text-o icon-title"></i>Unidades

   

  <a class="btn btn-primary btn-social pull-right" onclick="fnAgregar()" title="" data-toggle="tooltip" data-original-title="Agregar">
      <i class="fa fa-plus"></i>Agregar
  </a>
    </h1>

</section>


<div class="row">
    <%--FILA--%>
    <div class="col-xs-12">
        <%--COLUMNAS--%>
        <div class="box box-primary">
            <%--CONTENEDOR--%>



            <div class="box-body table-responsive">


                <asp:GridView ID="GdvUnidades" runat="server" AllowPaging="True" AutoGenerateColumns="False" CssClass="grid aej_all table table-striped table-bordered dt-responsive dataTable no-footer"
                    PageSize="90" Width="100%" EnableModelValidation="True" EmptyDataText="No se encontraron Registros.">
<%--                    <%--  <Columns>  --%>

           

                    <Columns>

                        <asp:ButtonField HeaderText="Eliminar" Text="<i class='fa fa-trash-o icon-large fa-1x'></i>" CommandName="Eliminar" />

                        <asp:TemplateField Visible="TRUE" HeaderText="Id">
                            <ItemTemplate>
                                <asp:Label ID="ID" runat="server" Text='<%# Eval("ID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField Visible="TRUE" HeaderText="Usuario">
                            <ItemTemplate>
                                <asp:Label ID="LblDescripcion" runat="server" Text='<%# Eval("Descripcion") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>


                        <asp:ButtonField HeaderText="Editar" Text="<i class='fa fa-cog icon-large fa-1x; style:color-red'></i>" CommandName="Editar" />

                    </Columns>


                </asp:GridView>

            </div>


        </div>
    </div>
</div>
</asp:Content>
