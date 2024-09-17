<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPager.Master" CodeBehind="NovedadesListar.aspx.vb" Inherits="ProyectoWeb.NovedadesListar" %>
<%@ MasterType VirtualPath="~/MasterPager.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
       <section class="content-header">
  <h1>
    <i class="fa fa-file-text-o icon-title"></i> Novedades 

   

      <a class="btn btn-primary btn-social pull-right" onclick="fnAgregar()" title="" data-toggle="tooltip" data-original-title="Agregar">
      <i class="fa fa-plus"></i> Agregar
    </a>
  </h1>

</section>






   <div class="row"> <%--FILA--%>
            <div class="col-xs-12"> <%--COLUMNAS--%>
                <div class="box box-primary"> <%--CONTENEDOR--%>
                   
                    <div class="box-body table-responsive">
                         
                     
                         <asp:GridView ID="GdvNovedades" runat="server"  AllowPaging="True" AutoGenerateColumns="False" CssClass="grid aej_all table table-striped table-bordered dt-responsive dataTable" 
                              PageSize="90" Width="100%" EnableModelValidation="True"   EmptyDataText="No se encontraron Registros.">
                      <%--  <Columns>  

                 <asp:GridView ID="GdvColores" AutoGenerateColumns="false" CssClass="table table-active table-bordered" runat="server">--%>

                     <Columns>

                          
                           <asp:TemplateField Visible="TRUE" HeaderText="Nro">
                                 <ItemTemplate>
                                          <asp:Label ID="ID" runat="server" Text='<%# Eval("ID") %>' />
                                 </ItemTemplate>
                       </asp:TemplateField>

                           <asp:TemplateField Visible="TRUE" HeaderText="Fecha Inicio">
                                 <ItemTemplate>
                                          <asp:Label ID="FECHA" runat="server" Text='<%# Eval("fechainicio") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                          <asp:TemplateField Visible="TRUE" HeaderText="Hora Inicio">
                                 <ItemTemplate>
                                          <asp:Label ID="Hora" runat="server" Text='<%# Eval("Horainicio") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                                                    <asp:TemplateField Visible="TRUE" HeaderText="Fecha Fin">
                                 <ItemTemplate>
                                          <asp:Label ID="FECHA" runat="server" Text='<%# Eval("fechafin") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                          <asp:TemplateField Visible="TRUE" HeaderText="Hora Fin">
                                 <ItemTemplate>
                                          <asp:Label ID="Hora" runat="server" Text='<%# Eval("Horafin") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>


                          <asp:TemplateField Visible="TRUE" HeaderText="Tiempo de Corte">
                                 <ItemTemplate>
                                          <asp:Label ID="TiempoCorte" runat="server" Text='<%# Eval("TiempoCorte") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                          <asp:TemplateField Visible="TRUE" HeaderText="Novedades Descripcion">
                                 <ItemTemplate>
                                          <asp:Label ID="NovedadesDescripcion" runat="server" Text='<%# Eval("NovedadesDescripcion") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField Visible="TRUE" HeaderText="Motivo Descripcion">
                                 <ItemTemplate>
                                          <asp:Label ID="MotivoDescripcion" runat="server" Text='<%# Eval("MotivoDescripcion") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField Visible="TRUE" HeaderText="Servicio Descripcion">
                                 <ItemTemplate>
                                          <asp:Label ID="ServicioDescripcion" runat="server" Text='<%# Eval("ServicioDescripcion") %>' />
                                 </ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField Visible="TRUE" HeaderText="Usuario">
                                 <ItemTemplate>
                                          <asp:Label ID="Usuario" runat="server" Text='<%# Eval("Usuario") %>' />
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
                    <h4 class="modal-title" id="myModalLabelAgregar">Agregar Novedades</h4>
                </div>
                <div class="modal-body">
                    <div class="row">
                 
                    <div class="col-lg-6">
                             <div class="form-group">
                         <label>Fecha Inicio</label>
                        <asp:TextBox ID="TxtFechaDesdeAgregar" ClientIDMode="Static" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    </div>

                    <div class="col-lg-6">                    
                    <div class="form-group">
                         <label>Hora</label>
                       
                        <input type="time" class="form-control" ID="TxtHoraDesdeAgregar"   value="14:00:00" max="23:59:00" min="00:00:00" step="1">
                        <input type="time" id="_INICIO_HORA" name="_INICIO_HORA"  tabIndex="5"  class="form-control" value="00:00"  max="24:59" min="00:00">            
                         <asp:hiddenfield ID="INICIO_HORA" runat="server"></asp:hiddenfield>
                    </div>
                      

                       </div>

                    </div>

                     <div class="row">
                     <div class="col-lg-6">   
                             <div class="form-group">
                         <label>Fecha Hasta</label>
                        <asp:TextBox ID="TxtFechaHastaAgregar" ClientIDMode="Static" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    </div>

                   <div class="col-lg-6">                    
                    <div class="form-group">
                         <label>Hora</label>
                     
                        <input type="time" runat="server"  class="form-control" ID="TxtHoraHastaAgregar"   value="14:00:00" max="23:59:00" min="00:00:00" step="1">
                    </div>
                      

                       </div>

                    </div>

                    
                      <div class="row">
                     <div class="col-lg-6">                    
                    <div class="form-group">
                         <label>Servicio</label>
                            <asp:DropDownList ID="idServicioAgregar" DataTextField="DESCRIPCION" DataValueField="ID" runat="server" CssClass="form-control"></asp:DropDownList>


                       
                    </div>
                      

                       </div>
                 <div class="col-lg-6">                 
                    <div class="form-group">
                         <label>Motivo</label>
                        <asp:DropDownList ID="IdMotivoAgregar"  DataTextField="DESCRIPCION" DataValueField="ID" runat="server" CssClass="form-control"></asp:DropDownList>
                     
                    </div>
                      

                       </div>

                    </div>
                    
                          <div class="row">

                              <div class="col-lg-6">   
                             <div class="form-group">
                         <label>Tiempo de Corte</label>
                        <asp:TextBox ID="TxtTiempoCorteAgregar" ClientIDMode="Static" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    </div>
                                 
                    

                <div class="col-lg-12">               
                    <div class="form-group">
                         <label>Observaciones</label>
                        <asp:TextBox ID="TxtDescripcionAgregar" TextMode="MultiLine" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                      

                       </div>
                      

                       </div>
                   

                       
                    </div>

                 <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                    <asp:Button runat ="server" ID="BtnAgregar"  tabIndex="12"  CssClass="btn btn-primary dropdown-toggle btn-group-lg" text="Agregar"  ></asp:Button>
      
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
                    <asp:Button runat ="server" ID = "BtnEditarColor"  tabIndex="12"  CssClass="btn btn-primary dropdown-toggle btn-group-lg" text="Actualizar"  ></asp:Button>
      
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
                     <br />   <i class="fa fa-trash-o fa-2x fa-lg" style="color:#FFFFFF;"></i>
                    </div>


                </div>
                <div class="modal-body">
                     <div class="row" runat="server" id="Div5">

                        <div class="col-sm-12">                        
                         <asp:Label ID="lblMotivo_Eliminar" CssClass="label-danger -error alert alert-info btn-block"  runat="server" Text="" ></asp:Label>         
                        </div> 
                        

                         <div class="col-lg-12">
                                        <div class="form-group">
                                          <asp:TextBox ID="txtmotivoEliminar" clientIdmode="static"  CssClass="form-control"  runat="server" ReadOnly="true" visible="TRUE"></asp:TextBox>
                                       
                                            <label for="dgdsg" class="control-label">Motivo</label>
                                                
                                           
                                        </div>
                                    </div>
                        
                           
                  </div>      
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                    <asp:Button runat ="server" ID = "BtnEliminarMotivo"  tabIndex="12"  CssClass="btn  btn-danger" text="Eliminar"  ></asp:Button>
      
                </div>
            </div>
        </div>
    </div>
        
 

  
     <asp:HiddenField runat="server" ID="mensaje" ClientIDMode="Static" />
     <asp:HiddenField runat="server" ID="titulo" ClientIDMode="Static" />

      <asp:HiddenField ID="HoraDesdeAgregar" runat="server" />
      <asp:HiddenField ID="HoraHastaAgregar" runat="server" />
    
    



    
 
    
      
    <script src="assets/plugins/jquery-ui-1.12.1/jquery.js"></script>
    <link type="text/css"  rel="stylesheet" href="assets/plugins/jquery-ui-1.12.1/jquery-ui.css"  />
    <script type="text/javascript" src="assets/plugins/jquery-ui-1.12.1/jquery-ui.js"></script>
 


    <script>


       

        function fnAgregar() { $('#mdlAgregar').modal({ backdrop: 'static', keyboard: false }); };

        function fnEditar() { $('#mdlEditar').modal({ backdrop: 'static', keyboard: false }); };


        function fnEliminar() { $('#mdlEliminar').modal({ backdrop: 'static', keyboard: false }); };


        $(document).ready(function ()
        {
            

         



                $("#BtnAgregar").on("click", function () {

                    $('#INICIO_HORA').val($("#_INICIO_HORA").val());

                  //  $('#HoraDesdeAgregar').val($("#TxtHoraDesdeAgregar").val());
                   // $('#HoraHastaAgregar').val($("#TxtHoraHastaAgregar").val());     

                });



  
          });
      


       
    </script>

             <script type="text/javascript">

                     $.datepicker.regional['es'] = {
                     closeText: 'Cerrar',
                     prevText: '<Ant',
                     nextText: 'Sig>',
                     currentText: 'Hoy',
                     monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                     monthNamesShort: ['Ene','Feb','Mar','Abr', 'May','Jun','Jul','Ago','Sep', 'Oct','Nov','Dic'],
                     dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
                     dayNamesShort: ['Dom','Lun','Mar','Mié','Juv','Vie','Sáb'],
                     dayNamesMin: ['Do','Lu','Ma','Mi','Ju','Vi','Sá'],
                     weekHeader: 'Sm',
                     dateFormat: 'dd/mm/yy',
                     firstDay: 1,
                     isRTL: false,
                     showMonthAfterYear: false,
                     yearSuffix: ''
                     };
                     $.datepicker.setDefaults($.datepicker.regional['es']);
                   
</script>



      	 <script type="text/javascript">

                   

           $(function ()

           {
                         

               
               


                var d = new Date();

                    var month = d.getMonth()+1;
                    var day = d.getDate();

                 var output = (day < 10 ? '0' : '') + day + '/' +
                (month < 10 ? '0' : '') + month + '/' + d.getFullYear();
        
                                          

                $("#TxtFechaDesdeAgregar").datepicker({

   	                defaultDate: "+1w",
                    changeMonth: true,
                     dateFormat: 'dd/mm/yy',
                    changeYear:true,
                    numberOfMonths: 1,
                       language: 'es',
                    maxDate: new Date(output),

                    onClose: function (selectedDate)
                    {
                        $("#TxtFechaHastaAgregar").datepicker("option", "minDate", selectedDate);

                    }






   	         });

   	         $("#TxtFechaHastaAgregar").datepicker({
   	                   defaultDate: "+1w",
                       changeMonth: true,
                       changeYear: true,
                        dateFormat: 'dd/mm/yy',
                       numberOfMonths: 1,
                          language: 'es',
                       maxDate: new Date(output),
                       onClose: function (selectedDate)
                       {
                           $("#TxtFechaDesdeAgregar").datepicker("option", "maxDate", selectedDate);
                       }



   	         });





           
         


 });


  </script>

</asp:Content>
