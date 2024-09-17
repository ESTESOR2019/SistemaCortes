'------------------------------------------------------------------------------
' <generado automáticamente>
'     Este código fue generado por una herramienta.
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código. 
' </generado automáticamente>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class NovedadesListar

    '''<summary>
    '''Control GdvNovedades.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents GdvNovedades As Global.System.Web.UI.WebControls.GridView

    '''<summary>
    '''Control TxtFechaDesdeAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFechaDesdeAgregar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control INICIO_HORA.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents INICIO_HORA As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Control TxtFechaHastaAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtFechaHastaAgregar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtHoraHastaAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtHoraHastaAgregar As Global.System.Web.UI.HtmlControls.HtmlInputGenericControl

    '''<summary>
    '''Control idServicioAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents idServicioAgregar As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control IdMotivoAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents IdMotivoAgregar As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''Control TxtTiempoCorteAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtTiempoCorteAgregar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtDescripcionAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtDescripcionAgregar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control BtnAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnAgregar As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control txtIdMotivoEditar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtIdMotivoEditar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control TxtdescripcionMotivoEditar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents TxtdescripcionMotivoEditar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control BtnEditarColor.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEditarColor As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control Div5.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents Div5 As Global.System.Web.UI.HtmlControls.HtmlGenericControl

    '''<summary>
    '''Control lblMotivo_Eliminar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents lblMotivo_Eliminar As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''Control txtmotivoEliminar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents txtmotivoEliminar As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''Control BtnEliminarMotivo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents BtnEliminarMotivo As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''Control mensaje.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents mensaje As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Control titulo.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents titulo As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Control HoraDesdeAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HoraDesdeAgregar As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Control HoraHastaAgregar.
    '''</summary>
    '''<remarks>
    '''Campo generado automáticamente.
    '''Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
    '''</remarks>
    Protected WithEvents HoraHastaAgregar As Global.System.Web.UI.WebControls.HiddenField

    '''<summary>
    '''Propiedad Master.
    '''</summary>
    '''<remarks>
    '''Propiedad generada automáticamente.
    '''</remarks>
    Public Shadows ReadOnly Property Master() As ProyectoWeb.MasterPager
        Get
            Return CType(MyBase.Master, ProyectoWeb.MasterPager)
        End Get
    End Property
End Class
