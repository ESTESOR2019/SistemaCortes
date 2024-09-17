Imports CapaNegocioSis_Control.SIS_CONTROL

Public Class FrmPerfiles
    Inherits System.Web.UI.Page
    Dim OdDataset As New DataSet
    Dim OUPerfiles As New CnPerfiles
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            CargarGrilla()

        End If
    End Sub

    Protected Sub CargarGrilla()
        Try

            OdDataset = OUPerfiles.EjecutarSp("OT")
            GdvPerfiles.DataSource = OdDataset
            GdvPerfiles.DataBind()

        Catch ex As Exception

            '   Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try


    End Sub

End Class