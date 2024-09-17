<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPager.Master" AutoEventWireup="false" CodeFile="ReportesGraficar.aspx.vb" Inherits="ReportesGraficar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
   <section class="content-header">
  <h1>
    <i class="fa fa-file-text-o icon-title"></i> Reporte Grafico 

   

     
  </h1>

</section>

     <div class="row"> <%--FILA--%>
            <div class="col-xs-12"> <%--COLUMNAS--%>
                <div class="box box-primary"> <%--CONTENEDOR--%>

                    

                    <div class="box-body table-responsive">
                     
                         <div class="row">
                         
                               <div class="col-lg-4">
                                                    <div class="form-group">
                        <label>Fecha Desde</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtFechaDesde" runat="server" Text="" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                    </div>

                            </div>

                              <div class="col-lg-4">
                    <div class="form-group">
                        <label>Fecha Hasta</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtFechaHasta" runat="server" Text="" CssClass="form-control" ClientIDMode="Static" ></asp:TextBox>
                    </div>

                            </div>
                    

                              <div class="col-lg-4">

      

                            </div>
                    
                       </div>
                         

            </div>

                    <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>                   
                   <asp:Button runat ="server" ID = "BtnConsultar"  tabIndex="12"  CssClass="btn btn-primary " text="Consultar"  ></asp:Button>
      
                </div>
           
        </div>
    </div>
       </div>


         <div class="row"> 
            <div class="col-xs-12"> 
                <div class="box box-primary"> 

                    

                    <div class="box-body table-responsive">
                     
                        </div>
                    </div>
                </div>
             </div>

      <script type="text/javascript" src="assets/plugins/jquery-ui-1.12.1/jquery.js"></script>
      <link type="text/css"  rel="stylesheet" href="assets/plugins/jquery-ui-1.12.1/jquery-ui.css"  />
      <script type="text/javascript" src="assets/plugins/jquery-ui-1.12.1/jquery-ui.js"></script>
    
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

                                          

                $("#txtFechaDesde").datepicker({

   	                defaultDate: "+1w",
                    changeMonth: true,
                     dateFormat: 'dd/mm/yy',
                    changeYear:true,
                    numberOfMonths: 1,
                       language: 'es',
                    maxDate: new Date(output),

                    onClose: function (selectedDate)
                    {
                        $("#txtFechaHasta").datepicker("option", "minDate", selectedDate);

                    }






   	         });

   	         $("#txtFechaHasta").datepicker({
   	                   defaultDate: "+1w",
                       changeMonth: true,
                       changeYear: true,
                        dateFormat: 'dd/mm/yy',
                       numberOfMonths: 1,
                          language: 'es',
                       maxDate: new Date(output),
                       onClose: function (selectedDate)
                       {
                           $("#txtFechaDesde").datepicker("option", "maxDate", selectedDate);
                       }



   	         });





           
         


 });


  </script>
 

</asp:Content>

