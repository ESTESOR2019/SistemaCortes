<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ProyectoWeb.Login" %>
<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-language" content="es" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Acceso al Sistema de Cortes</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black">
    <form id="form1" runat="server">
        <div class="form-box" id="login-box">
                    <div class="header">Sistema de Registro de Cortes</div>
                    <div class="body bg-gray">
                        <div class="form-group">
                            <asp:TextBox ID="TxtDNI" runat="server" CssClass="form-control" placeholder="Ingrese usuario..."></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Ingrese clave..." TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="footer">
                        <asp:Button ID="btnIngresar"  runat="server" Text="Inicar Sesión" CssClass="btn bg-olive btn-block" />
                    </div>
            </div>
              
    
    
     <asp:HiddenField runat="server" ID="lblmensaje"  />
     <asp:HiddenField runat="server" ID="titulo"  />
</form>
</body>
<script src="js/jquery-3.1.0.min.js"></script>
<script src="js/bootstrap.min.js" type="text/javascript"></script>



    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui.min.js" type="text/javascript"></script>
    <script src="js/AdminLTE/app.js" type="text/javascript"></script>
    <script src="jAlert/jquery.alerts.js" type="text/javascript"></script>
    <script src="js/jquery.ui.draggable.js" type="text/javascript"></script>

    <script src="js/plugins/datatables/jquery.dataTables.js"></script>
    <script src="js/plugins/datatables/dataTables.bootstrap.js"></script>
    <script src="js/logout.js"></script>

   <script src="Assets/Plugin/sweet-alert-2/sweetalert2.all.min.js"></script>



             <script>
         
        function fnMostrarSucces()

        {
            mensaje = $("#lblmensaje").val();
            titulo = $("#titulo").val();           
            Swal.fire
                ({
                    title: titulo,
                    text: mensaje,
                    icon: 'success',
                    confirmButtonText: "Cerrar",

                })


                 };


                 function fnMostrarDanger()
                 {
                 mensaje = $("#lblmensaje").val();
                 titulo = $("#titulo").val();

                 Swal.fire
                         ({
                             title: titulo,
                             text: mensaje,
                             icon: 'error',
                             confirmButtonText: "Cerrar",

                         })



                 };



                 function fnMostrarWarning()
                 {

                 mensaje = $("#lblmensaje").val();
                 titulo = $("#titulo").val();

                 Swal.fire
                 ({
                    title: titulo,
                    text: mensaje,
                    icon: 'warning',                    
                    confirmButtonText: "Cerrar",
                   
                 })
                                         
        };



                 function fnMostrarInfo()
                 {

                mensaje = $("#lblmensaje").val();
                titulo = $("#titulo").val();

           
            Swal.fire
                ({
                    title: titulo,
                    text: mensaje,
                    icon: 'info',
                    confirmButtonText: "Cerrar",

                })



        };


     
  

             </script>
</html>
