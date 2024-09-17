

Imports ProyectoWeb.CnSistemas

Public Class MotivosListar

    Inherits System.Web.UI.Page


    Dim oNegocio As New CnMotivos
    Dim OdDataset As New DataSet





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then

            CargarGrilla()

        End If



    End Sub
    Protected Sub CargarGrilla()
        Try

            OdDataset = oNegocio.TraerTodos
            GdvMotivos.DataSource = OdDataset
            GdvMotivos.DataBind()

        Catch ex As Exception

            Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try


    End Sub


    Private Sub GdvMotivos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GdvMotivos.RowCommand


        Dim indice As Integer = e.CommandArgument

        Dim row As GridViewRow = GdvMotivos.Rows(indice)
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

                    txtIdEditar.Text = Convert.ToString(CType(row.FindControl("ID"), Label).Text)
                    TxtDescripcionEditar.Text = Convert.ToString(CType(row.FindControl("DESCRIPCION"), Label).Text)

                    If (Not ClientScript.IsStartupScriptRegistered("fnEditar")) Then

                        Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditar", "fnEditar();", True)

                    End If

                Catch ex As Exception

                    ' Mostrar_Mensaje("Ha ocurrido la Siguiente Excepción: " & ex.Message)

                Finally




                End Try



        End Select

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try


            oNegocio.Eliminar(txtmotivoEliminar.Text, Session("USUARIO"))

            Master.MostrarSucces("Se elimino correctamente!")


        Catch ex As Exception


            Master.MostrarWarning("Hubo un errror" & ex.Message)


        End Try

        CargarGrilla()


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click


        Try


            If TxtDescripcionEditar.Text = "" Then


                Master.MostrarInfo("Debe Ingresar la Descripcion")

                If (Not ClientScript.IsStartupScriptRegistered("fnEditar")) Then

                    Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnEditar", "fnEditar();", True)

                End If

                Exit Sub


            End If



            oNegocio.Modificar(txtIdEditar.Text, TxtDescripcionEditar.Text, Session("USUARIO"))

            Master.MostrarSucces("Se Actualizo Correctamente.!!!")



        Catch ex As Exception

            Master.MostrarWarning("Hubo un errror" & ex.Message)

        End Try


        CargarGrilla()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click


        Try


            oNegocio.Agregar(TxtDescripcionAgregar.Text, Session("USUARIO"))

            Master.MostrarSucces("Se Agrego Correctamente")


            CargarGrilla()
        Catch ex As Exception

            ' ClientScript.RegisterStartupScript(Me.GetType, "msg", "alert('No se Pudo Agregar el Color');", True)

            Master.MostrarWarning("'No se Pudo Agregar el Motivo")
            CargarGrilla()
        End Try



    End Sub

    Private Function Buscar(ByVal descricpion As String) As Boolean

        Dim Ods As New DataSet
        Dim Existe As Boolean = False

        Ods = oNegocio.EjecutarSp("Descripcion", descricpion)

        If Ods.Tables(0).Rows.Count > 0 Then

            Existe = True
        End If

        Return Existe

    End Function




End Class