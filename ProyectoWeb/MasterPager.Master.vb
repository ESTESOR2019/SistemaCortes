Imports System.Web.Services.Description

Public Class MasterPager
    Inherits System.Web.UI.MasterPage

    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    If Session("USUARIO") Is Nothing Then

    '        MostrarWarning("Su session ha finalizado, ingrese nuevamente!!!")

    '        Response.Redirect("Login.aspx")
    '    End If


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

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class