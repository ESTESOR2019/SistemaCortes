Imports CapaNegocioSis_Control.SIS_CONTROL

Public Class FrmGrados
    Inherits System.Web.UI.Page
    Dim OcnGrados As New CnGrados
    Dim OuDataSet As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub

    Protected Sub CargarGrilla()
        Try

            OuDataSet = OcnGrados.EjecutarSp("OT")
            GdvGrados.DataSource = OuDataSet
            GdvGrados.DataBind()
        Catch ex As Exception

        End Try

    End Sub

End Class