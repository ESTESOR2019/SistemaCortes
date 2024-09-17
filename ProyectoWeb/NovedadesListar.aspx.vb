Imports System.Data

Imports ProyectoWeb.CnSistemas

Public Class NovedadesListar

    Inherits System.Web.UI.Page

    Dim oNegocio As New CnNovedades
    Dim OMotivos As New CnMotivos
    Dim OServicios As New CnServicios

    Dim OdDataset As New DataSet


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then

            'CargarGrilla()
            'CargarCombo()


        End If



    End Sub
    Protected Sub CargarGrilla()
        Try

            OdDataset = oNegocio.TraerTodos
            GdvNovedades.DataSource = OdDataset
            GdvNovedades.DataBind()

        Catch ex As Exception

            Master.MostrarDanger("Hubo un erro en la Carga de la Grilla")

        End Try


    End Sub


    Private Sub GdvNovedades_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GdvNovedades.RowCommand


        Dim indice As Integer = e.CommandArgument

        Dim row As GridViewRow = GdvNovedades.Rows(indice)
        Dim ID As Integer = Convert.ToInt32(CType(row.FindControl("ID"), Label).Text)


        Select Case e.CommandName

            Case "Eliminar"

                Try

                    lblMotivo_Eliminar.Text = "Esta seguro que desa Eliminar el Registro!!!, <br><font color='red'>Se van a Eliminar el Color Cargado!!!</font>"
                    txtmotivoEliminar.Text = Convert.ToString(CType(row.FindControl("ID"), Label).Text)

                    If (Not ClientScript.IsStartupScriptRegistered("fnEliminar")) Then

                        Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEliminar", "fnEliminar();", True)

                    End If

                Catch ex As Exception

                    ' Mostrar_Mensaje("Ha ocurrido la Siguiente Excepción: " & ex.Message)

                Finally




                End Try



            Case "Editar"

                Try

                    lblMotivo_Eliminar.Text = "Esta seguro que desa Editar el Registro!!!, <br><font color='red'>Se va a  Editar el Color Cargado!!!</font>"

                    txtIdMotivoEditar.Text = Convert.ToString(CType(row.FindControl("ID"), Label).Text)


                    If (Not ClientScript.IsStartupScriptRegistered("fnEditar")) Then

                        Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditar", "fnEditar();", True)

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

                If (Not ClientScript.IsStartupScriptRegistered("fnEditar")) Then

                    Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditar", "fnEditar();", True)

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

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click


        Try


            oNegocio.Agregar(TxtFechaDesdeAgregar.Text, INICIO_HORA.Value, TxtFechaHastaAgregar.Text, HoraHastaAgregar.Value, idServicioAgregar.SelectedValue, IdMotivoAgregar.SelectedValue, TxtTiempoCorteAgregar.Text, TxtDescripcionAgregar.Text, Session("USUARIO"))

            Master.MostrarSucces("Se Agrego Correctamente")


            CargarGrilla()
        Catch ex As Exception

            ' ClientScript.RegisterStartupScript(Me.GetType, "msg", "alert('No se Pudo Agregar el Color');", True)

            Master.MostrarWarning("No se Pudo Agregar el Motivo" & ex.Message)
            CargarGrilla()
        End Try



    End Sub



    Private Sub CargarCombo()



        Try
            Dim OdsMotivos As New DataSet
            Dim OdServicios As New DataSet

            OdsMotivos = OMotivos.TraerTodos()
            IdMotivoAgregar.DataSource = OdsMotivos
            IdMotivoAgregar.DataBind()

            OdServicios = OServicios.TraerTodos()
            idServicioAgregar.DataSource = OdServicios
            idServicioAgregar.DataBind()




        Catch ex As Exception

            Master.MostrarWarning("Hubo un error en la funcion Cargar Combo")

        End Try








    End Sub


End Class