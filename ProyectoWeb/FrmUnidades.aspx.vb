Imports CapaNegocioSis_Control.SIS_CONTROL

Public Class FrmUnidades
    Inherits System.Web.UI.Page
    Dim OcnUnidades As New CnUnidades
    Dim OuDataSet As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub
    Protected Sub CargarGrilla()
        Try

            OuDataSet = OcnUnidades.EjecutarSp("OT")
            GdvUnidades.DataSource = OuDataSet
            GdvUnidades.DataBind()
        Catch ex As Exception

        End Try

    End Sub

End Class