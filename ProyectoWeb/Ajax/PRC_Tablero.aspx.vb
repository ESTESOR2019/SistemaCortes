Imports System.Globalization
Imports System.Xml

Imports System.Web.Services
Imports System.Web.Script.Services

Imports System.Data
Imports System.Collections.Generic
Imports ProyectoWeb.CnSistemas

Partial Class PRC_Tablero
    Inherits System.Web.UI.Page







    <WebMethod> Public Shared Function CalendarioMostrar(FechaDesde As String, FechaHasta As String) As String

        Dim oNegocio As New CnNovedades
        Dim OdDataset As New DataSet


        OdDataset = ONegocio.TraerTodos





        Try

            'GNA_GRUPOS_UNIDAD_PAGO_CUPO_OF_CALENDARIO

            Dim dt As New DataTable
            Dim Ods As New DataSet
            dt = oNegocio.EjecutarSp("Calendario").Tables(0)


            Dim Js As New System.Web.Script.Serialization.JavaScriptSerializer()

            Dim rows As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()

            Dim row As Dictionary(Of String, Object) = Nothing
            For Each dr As DataRow In dt.Rows

                row = New Dictionary(Of String, Object)()


                For Each col As DataColumn In dt.Columns

                    row.Add(col.ColumnName, dr(col))

                Next
                rows.Add(row)

            Next

            Dim json As String = Js.Serialize(rows)
            Return json

        Catch ex As Exception

            Return ex.Message

        End Try

    End Function



End Class

