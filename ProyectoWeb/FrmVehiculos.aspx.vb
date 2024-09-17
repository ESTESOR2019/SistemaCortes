Imports CapaNegocioSis_Control.SIS_CONTROL
Imports ServidorDatosNet_GNA

Public Class FrmVehiculos
    Inherits System.Web.UI.Page
    Dim OdDataset As New DataSet
    Dim OUVehiculos As New CnVehiculos
    Dim OcnTipoVehiculo As New CnTipoVehiculos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            CargarGrilla()
            CargarCombo()
        End If

    End Sub

    Protected Sub CargarGrilla()
        Try

            OdDataset = OUVehiculos.EjecutarSp("OT")
            GdvVehiculos.DataSource = OdDataset
            GdvVehiculos.DataBind()

        Catch ex As Exception

            '   Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try


    End Sub

    Protected Sub CargarCombo()
        Try

            OdDataset = OcnTipoVehiculo.EjecutarSp("OT")
            DdlTipoVehiculoAgregar.DataSource = OdDataset
            DdlTipoVehiculoAgregar.DataBind()

        Catch ex As Exception

            '   Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try


    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Respuesta As Integer
        Try
            Respuesta = OUVehiculos.Agregar(0, TxtDominio.Text, DdlTipoVehiculoAgregar.SelectedValue)
            CargarGrilla()

        Catch ex As cError


            Response.Write(ex.Exc_Message)


        End Try
    End Sub
End Class