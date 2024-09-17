<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPager.Master" CodeBehind="ServiciosListar.aspx.vb" Inherits="ProyectoWeb.ServiciosListar" %>
<%@ MasterType VirtualPath="~/MasterPager.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <section class="content-header">
  <h1>
    <i class="fa fa-file-text-o icon-title"></i> Servicios 

   

      <a class="btn btn-primary btn-social pull-right" onclick="fnAgregar()" title="" data-toggle="tooltip" data-original-title="Agregar">
      <i class="fa fa-plus"></i> Agregar
    </a>
  </h1>

</section>





   <div class="row"> <%--FILA--%>
            <div class="col-xs-12"> <%--COLUMNAS--%>
                <div class="box box-primary"> <%--CONTENEDOR--%>
                   
                    <div class="box-body table-responsive">
                         
                     
                         <asp:GridView ID="GdvMotivos" runat="server"  AllowPaging="True" AutoGenerateColumns="False" CssClass="grid aej_all table table-striped table-bordered dt-responsive dataTable" 
                              PageSize="90" Width="100%" EnableModelValidation="True"   EmptyDataText="No se encontraron Registros.">
                      <%--  <Columns>  

                 <asp:GridView ID="GdvColores" AutoGenerateColumns="false" CssClass="table table-active table-bordered" runat="server">--%>

                     <Columns>

                             <asp:ButtonField   HeaderText="Eliminar"     Text="<i class='fa fa-trash-o icon-large fa-1x'></i>" CommandName="Eliminar" />
             
                           <asp:TemplateField Visible="TRUE" HeaderText="Id">
                                 <ItemTemplate>
                                          <asp:Label ID="ID" runat="server" Text='<%# Eval("ID") %>' />
                                 </ItemTemplate>
                       </asp:TemplateField>

                           <asp:TemplateField Visible="TRUE" HeaderText="Descripcion">
                                 <ItemTemplate>
                                          <asp:Label ID="descripcion" runat="server" Text='<%# Eval("descripcion") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                          <asp:TemplateField Visible="TRUE" HeaderText="Activo">
                                 <ItemTemplate>
                                          <asp:Label ID="Activo" runat="server" Text='<%# Eval("Activo") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                         

                         
                      <asp:ButtonField  HeaderText="Editar"     Text="<i class='fa fa-cog icon-large fa-1x; style:color-red'></i>" CommandName="Editar"/>                                            
                                
                     </Columns>

                     
                 </asp:GridView>
                          

            </div>

           
        </div>
    </div>
       </div>

    

    <div class="modal fade" id="mdlAgregar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabelAgregar">Agregar Servicios</h4>
                </div>
                <div class="modal-body">
                    
                   
                    <div class="form-group">
                        <label>Descripcion</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="TxtDescripcionAgregar" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                    <asp:Button runat ="server" ID = "BtnAgregar"  tabIndex="12"  CssClass="btn btn-primary dropdown-toggle btn-group-lg" text="Agregar"  ></asp:Button>
      
                </div>

            </div>
        </div>
    </div>


    <div class="modal fade" id="mdlEditar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Editar registro</h4>
                </div>
                <div class="modal-body">
                     <div class="col-sm-12">                        
                         <asp:Label ID="lblEditar" CssClass="label-danger -error alert alert-info btn-block"  runat="server" Text="" ></asp:Label>         
                        </div> 
                        


                    <div class="form-group">
                        <label>Id</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtIdMotivoEditar" runat="server" Text="" CssClass="form-control" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Descripcion</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="TxtdescripcionMotivoEditar" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                    <asp:Button runat ="server" ID = "BtnEditar"  tabIndex="12"  CssClass="btn btn-primary dropdown-toggle btn-group-lg" text="Actualizar"  ></asp:Button>
      
                </div>

            </div>
        </div>
    </div>


     <div class="modal inmodal fade in" id="mdlEliminar" tabindex="-1" role="dialog" aria-hidden="true">
         <div class="modal-dialog modal-md">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span><span class="sr-only">Close</span></button>
                     
                 

                    <div class="panel-heading panel-danger" >Eliminar Motivo
                     <br />   <i class="fa fa-trash-o fa-2x fa-lg"></i>
                    </div>


                </div>
                <div class="modal-body">
                     <div class="row" runat="server" id="Div5">

                        <div class="col-sm-12">                        
                         <asp:Label ID="IdEliminar" CssClass="label-danger -error alert alert-info btn-block"  runat="server" Text="" ></asp:Label>         
                        </div> 
                        

                         <div class="col-lg-12">
                                        <div class="form-group">
                                          <asp:TextBox ID="txtDescripcionEliminar" clientIdmode="static"  CssClass="form-control"  runat="server" ReadOnly="true" visible="TRUE"></asp:TextBox>
                                       
                                            <label for="dgdsg" class="control-label">Motivo</label>
                                                
                                           
                                        </div>
                                    </div>
                        
                           
                  </div>      
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                    <asp:Button runat ="server" ID = "BtnEliminar"  tabIndex="12"  CssClass="btn  btn-danger" text="Eliminar"  ></asp:Button>
      
                </div>
            </div>
        </div>
    </div>
        
 

  
     <asp:HiddenField runat="server" ID="mensaje" ClientIDMode="Static" />
       <asp:HiddenField runat="server" ID="titulo" ClientIDMode="Static" />
 
    <script>


       

        function fnAgregar() { $('#mdlAgregar').modal({ backdrop: 'static', keyboard: false }); };

        function fnEditar() { $('#mdlEditar').modal({ backdrop: 'static', keyboard: false }); };


        function fnEliminar() { $('#mdlEliminar').modal({ backdrop: 'static', keyboard: false }); };


       

       
    </script>
</asp:Content>
