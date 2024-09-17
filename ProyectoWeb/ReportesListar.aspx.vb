

Imports ProyectoWeb.CnSistemas

Public Class ReportesListar

    Inherits System.Web.UI.Page

    Dim oNegocio As New CnNovedades
    Dim OdDataset As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then

            CargarGrilla()

        End If



    End Sub
    Protected Sub CargarGrilla()
        Try

            OdDataset = oNegocio.TraerTodos
            GdvNovedades.DataSource = OdDataset
            GdvNovedades.DataBind()

        Catch ex As Exception

        End Try


    End Sub


    Private Sub GdvNovedades_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GdvNovedades.RowCommand


        Dim indice As Integer = e.CommandArgument

        Dim row As GridViewRow = GdvNovedades.Rows(indice)
        Dim ID As Integer = Convert.ToInt32(CType(row.FindControl("ID"), Label).Text)


        Select Case e.CommandName

            Case "Eliminacion"

                Try

                    lblMotivo_Eliminar.Text = "Esta seguro que desa Eliminar el Registro!!!, <br><font color='red'>Se van a Eliminar el Color Cargado!!!</font>"
                    txtmotivoEliminar.Text = Convert.ToString(CType(row.FindControl("ID"), Label).Text)

                    If (Not ClientScript.IsStartupScriptRegistered("fnEliminarColor")) Then

                        Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEliminarColor", "fnEliminarColor();", True)

                    End If

                Catch ex As Exception

                    ' Mostrar_Mensaje("Ha ocurrido la Siguiente Excepción: " & ex.Message)

                Finally




                End Try



            Case "Editar"

                Try

                    lblMotivo_Eliminar.Text = "Esta seguro que desa Editar el Registro!!!, <br><font color='red'>Se va a  Editar el Color Cargado!!!</font>"

                    txtIdMotivoEditar.Text = Convert.ToString(CType(row.FindControl("ID"), Label).Text)
                    TxtdescripcionMotivoEditar.Text = Convert.ToString(CType(row.FindControl("DESCRIPCION"), Label).Text)

                    If (Not ClientScript.IsStartupScriptRegistered("fnEditarColor")) Then

                        Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditarColor", "fnEditarColor();", True)

                    End If

                Catch ex As Exception

                    ' Mostrar_Mensaje("Ha ocurrido la Siguiente Excepción: " & ex.Message)

                Finally




                End Try



        End Select

    End Sub

    Private Sub BtnEliminarMotivo_Click(sender As Object, e As EventArgs) Handles BtnEliminarMotivo.Click
        Try


            oNegocio.Eliminar(txtmotivoEliminar, Session("USUARIO"))


            Master.MostrarWarning("Se elimino correctamente!")






        Catch ex As Exception


            Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try

        CargarGrilla()


    End Sub

    Private Sub BtnEditarColor_Click(sender As Object, e As EventArgs) Handles BtnEditarColor.Click


        Try


            If TxtdescripcionMotivoEditar.Text = "" Then


                Master.MostrarInfo("Debe Ingresar un Motivo")

                If (Not ClientScript.IsStartupScriptRegistered("fnEditarMotivo")) Then

                    Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditarMotivo", "fnEditarMotivo();", True)

                End If

                Exit Sub


            End If



            oNegocio.Modificar(txtIdMotivoEditar.Text, TxtdescripcionMotivoEditar.Text, Session("USUARIO"))

            Master.MostrarSucces("Se Actualizo Correctamente el Color!!!")



        Catch ex As Exception

            Master.MostrarWarning("Hubo un errror" & ex.Message)

        End Try
        CargarGrilla()

    End Sub

    Private Sub BtnAgregarColor_Click(sender As Object, e As EventArgs) Handles BtnAgregarColor.Click


        Try


            oNegocio.Agregar(TxtMotivoAgregar.Text, Session("USUARIO"))

            Master.MostrarInfo("Se Agrego Correctamente")


            CargarGrilla()
        Catch ex As Exception

            ' ClientScript.RegisterStartupScript(Me.GetType, "msg", "alert('No se Pudo Agregar el Color');", True)

            Master.MostrarWarning("'No se Pudo Agregar el Motivo")
            CargarGrilla()
        End Try



    End Sub




End Class