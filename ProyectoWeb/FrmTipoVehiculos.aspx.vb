Imports CapaNegocioSis_Control.SIS_CONTROL
Imports ServidorDatosNet_GNA

Public Class FrmTipoVehiculos
    Inherits System.Web.UI.Page
    Dim OcnTipoVehiculos As New CnTipoVehiculos
    Dim OuDataSet As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub
    Protected Sub CargarGrilla()
        Try

            OuDataSet = OcnTipoVehiculos.EjecutarSp("OT")
            GdvTipoVehiculos.DataSource = OuDataSet
            GdvTipoVehiculos.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Respuesta As Integer
        Try
            Respuesta = OcnTipoVehiculos.Agregar(0, TxtDescripcionAgregar.Text)
            CargarGrilla()

        Catch ex As cError


            Response.Write(ex.Exc_Message)


        End Try
    End Sub
End Class