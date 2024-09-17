

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If TxtDNI.Text = "" Then

            ClientScript.RegisterStartupScript(Me.GetType, "msg", "alert('INGRESE USUARIO Y CONTRASEÑA');", True)
            'MsgBox("INGRESE DATOS")
        Else
            If IsNumeric(TxtDNI.Text) = False Then
                ClientScript.RegisterStartupScript(Me.GetType, "msg", "alert('INGRESE UNICAMENTE NUMEROOOOOOS');", True)
                'MsgBox("INGRESE UNICAMENTE NUMEROOOOOOOOOS")
            Else

                ' Ingresar()

                Session("USUARIO") = TxtDNI.Text

                Response.Redirect("Presentacion.aspx")



            End If
        End If


    End Sub




    'Private Sub Ingresar()



    '    Try


    '        Dim dsUsuarios As New DataSet
    '        Dim dsContacto As New DataSet

    '        Dim auth As New LdapAuthentication("LDAP://10.201.0.7")

    '        If TxtDNI.Text IsNot Nothing Or txtPassword.Text IsNot Nothing Then

    '            If auth.IsAuthenticated("GENDARMERIA", TxtDNI.Text, txtPassword.Text) Then

    '                Session("USUARIO") = TxtDNI.Text

    '                Response.Redirect("NovedadesListar.aspx")
    '            Else

    '                MostrarWarning("El Usuario o Clave es Incorrecta")

    '            End If

    '        Else
    '            MostrarWarning("Debe ingresar El Usuario y la  Clave.")
    '        End If
    '    Catch Ex As Exception

    '        MostrarWarning("Hubo un error en llamada de la funcion.")

    '    End Try
    'End Sub



    Public Sub MostrarSucces(ByVal strmensaje As String)


        lblmensaje.Value = strmensaje


        If (Not Page.ClientScript.IsStartupScriptRegistered("fnMostrarSucces")) Then

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnMostrarSucces", "fnMostrarSucces();", True)

        End If

    End Sub

    Public Sub MostrarWarning(ByVal strmensaje As String)


        lblmensaje.Value = strmensaje
        titulo.Value = "Colores"

        If (Not Page.ClientScript.IsStartupScriptRegistered("fnMostrarWarning")) Then

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnMostrarWarning", "fnMostrarWarning();", True)


        End If

    End Sub

    Public Sub MostrarInfo(ByVal strmensaje As String)


        lblmensaje.Value = strmensaje

        If (Not Page.ClientScript.IsStartupScriptRegistered("fnMostrarInfo")) Then

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnMostrarInfo", "fnMostrarInfo();", True)



        End If

    End Sub

    Public Sub MostrarDanger(ByVal strmensaje As String)


        lblmensaje.Value = strmensaje

        If (Not Page.ClientScript.IsStartupScriptRegistered("fnMostrarDanger")) Then

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "fnMostrarDanger", "fnMostrarDanger();", True)



        End If

    End Sub

End Class