<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPager.Master" CodeBehind="ReportesListar.aspx.vb" Inherits="ProyectoWeb.ReportesListar" %>
<%@ MasterType VirtualPath="~/MasterPager.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="content-header">
  <h1>
    <i class="fa fa-file-text-o icon-title"></i> Calendario

   

     
  </h1>

</section>





   <div class="row"> <%--FILA--%>
            <div class="col-xs-12"> <%--COLUMNAS--%>
                <div class="box box-primary"> <%--CONTENEDOR--%>
                    
                    <div class="box-body table-responsive">
                         
                     <div id="calendario" class="fc fc-unthemed fc-ltr">

                     </div>
                      
                          

            </div>

           
        </div>
    </div>
       </div>

    

 

  


 

  
     <asp:HiddenField runat="server" ID="mensaje" ClientIDMode="Static" />
       <asp:HiddenField runat="server" ID="titulo" ClientIDMode="Static" />


    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>



     <!-- jQuery Version 1.11.1 


      <script src="assets/js/libs/bootstrap/bootstrap.min.js"></script>


    <!-- Bootstrap Core JavaScript


  
     <script src="Content/Archivos_JS/jquery/jquery.js"></script> -->

    <style>
        body {
            margin: 40px 10px;
            padding: 0;
            font-family: Arial, Helvetica Neue, Helvetica, sans-serif;
            font-size: 14px;
        }
    </style>
   <%-- <link href="assets/plugins/fullcalendar/fullcalendar.css" rel="stylesheet" />

    <script src="js/bootstrap.min.js"></script>

    <script src="assets/plugins/fullcalendar/moment.min.js"></script>

    <script src="assets/plugins/fullcalendar/fullcalendar.js"></script>


 


    <script src="assets/plugins/fullcalendar/lang/es.js"></script>--%>

  

     <script  src="https://code.jquery.com/jquery-3.6.0.min.js" ></script>

    <!-- ✅ load moment.js ✅ -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment.min.js"    ></script>

    <!-- ✅ load FullCalendar ✅ -->
    <script       src="https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.10.2/fullcalendar.min.js" ></script>

     <script>



         function cargarDatos(url, jsontext)
         {

             debugger;

                         $.ajax({
                             url: url,
                             dataType: "json",
                             data: jsontext,
                             type: "POST",
                             cache: false,
                             async: false,
                             timeout: 30000,
                             contentType: "application/json; charset=utf-8",
                             dataFilter: function (data) {
                                 return data;
                             },
                             success: function (data) {
                                 resultados = data.d;
                             },
                             error: function (XMLHttpRequest, textStatus, errorThrown) {
                                 alert(errorThrown);
                             }
                         });
                         return eval(resultados);
                     };



    $(document).ready(function ()

        {


                         $('#calendario').val = "";


                         var date = new Date();
                         var yyyy = date.getFullYear().toString();

                         var mm = (date.getMonth() + 1).toString().length == 1 ? "0" + (date.getMonth() + 1).toString() : (date.getMonth() + 1).toString();
                         var dd = (date.getDate()).toString().length == 1 ? "0" + (date.getDate()).toString() : (date.getDate()).toString();

                         //var jsontext = "{'PERIODO': '" + yyyy + "'}";
                        // yyyy = '2020';

                         var jsontext = "{'FechaDesde': '0','FechaHasta': '0'}";
                        
                         var chartData = "";


                 
                         chartData = cargarDatos('Ajax/PRC_Tablero.aspx/CalendarioMostrar', jsontext);


                       

                         $('#calendario').fullCalendar({

                             header:
                             {
                                 language: 'es',
                                 left: 'prev,next today',
                                 center: 'title,year',
                                 right: 'year,month,basicWeek,basicDay,listMonth',

                             },


                             defaultDate: yyyy + "-" + mm + "-" + dd,
                             editable: true,
                             eventLimit: true, // allow "more" link when too many events
                             selectable: true,
                             selectHelper: true,
                             weekNumbers: false,

                                                                                    


                             eventDrop: function (event, delta, revertFunc) {

                                 edit(event);

                             },
                             eventResize: function (event, dayDelta, minuteDelta, revertFunc) {

                                 edit(event);

                             },

                             events: chartData





                         });













                     });


               




         
    </script>
 
   
</asp:Content>
