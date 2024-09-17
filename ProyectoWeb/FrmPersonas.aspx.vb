Imports CapaNegocioSis_Control.SIS_CONTROL

Public Class FrmPersonas
    Inherits System.Web.UI.Page
    Dim OdDataset As New DataSet
    Dim OUPersonas As New CnPersonas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            CargarGrilla()

        End If
    End Sub
    Protected Sub CargarGrilla()
        Try

            OdDataset = OUPersonas.EjecutarSp("OT")
            GdvPersonas.DataSource = OdDataset
            GdvPersonas.DataBind()

        Catch ex As Exception

            '   Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try


    End Sub

End Class