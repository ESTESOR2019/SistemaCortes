Imports Microsoft.VisualBasic
Imports System.IO
Imports System
Imports System.Xml
Imports System.Data
Imports System.Collections.Specialized
Imports System.Configuration

Module modConexion

    'Comento porque no se usa, 30/08/2023 - Bre
    'Public Function ObtenerStringConexion_usuario(ByVal strConexion As String) As String
    '    Dim _EX As String = "AdNet-0002"
    '    Dim xml_tmp As String = ""

    '    Try

    '        xml_tmp = strConexion

    '    Catch ex As Exception
    '        Throw New Exception(_EX & "/" & ex.Message & "/revise datos de conexion.")  'si se produce un error, devuelvo en _EX el codigo para identificar donde fue el error (ej: SVR001, para saber que fue aqui)
    '    End Try
    '    Return xml_tmp
    'End Function

    ''' <summary>
    ''' Médoto que permite obtener el origen de la cadena de conexión
    ''' </summary>
    ''' <param name="strConexion">Tag de conexion u origen de datos</param>
    ''' <returns></returns>
    Public Function ObtenerStringConexion(ByVal strConexion As String) As String
        Try
            'Obtiene la conexión desde el webconfig en el tag ConnectionStrings/nombre de conexión
            Return ConfigurationManager.ConnectionStrings(strConexion).ConnectionString.ToString()

            'Obtiene la conexión desde el webconfig en el tag ConnectionStrings/nombre de conexión Encriptada
            'Return Encryption.Decrypt(ConfigurationManager.ConnectionStrings(strConexion).ConnectionString.ToString())

            'Obtiene la conexión desde el webconfig en el tag AppSettings/nombre de conexión Encriptada
            'Return Encryption.Decrypt(System.Configuration.ConfigurationManager.AppSettings(strConexion))

        Catch ex As Exception
            Return ""
        End Try

    End Function

    ''' <summary>
    ''' Médoto que permite obtener la cadena de conexión, desde el webconfig cifrada con el ServidorDatos
    ''' </summary>
    ''' <param name="nombreKey">Nombre de la key dentro del AppSetting</param>
    ''' <param name="appSettings">AppSetting dentro del webconfig</param>
    ''' <returns></returns>
    Public Function ObtenerStringWebConfig(ByVal nombreKey As String, ByRef appSettings As NameValueCollection) As String
        Dim _EX As String = "Error de conección desde webconfig"
        Dim cadenaConexion As String = ""

        Try

            cadenaConexion = Encryption.SelfDecrypt(appSettings(nombreKey))

        Catch ex As Exception
            Throw New Exception(_EX & "/" & ex.Message & "/revise datos de conexion.")  'si se produce un error, devuelvo en _EX el codigo para identificar donde fue el error (ej: SVR001, para saber que fue aqui)
        End Try

        Return cadenaConexion
    End Function


    ''Comento porque no usa el ultimo parametro, 30/08/2023 - Bre

    'Public Function ObtenerStringDeArchivoXML(ByVal strPath As String, ByVal strAplicacion As String, ByVal strParametro As String) As String
    '    Dim oDom As New XmlDocument()
    '    Dim _string As String = ""

    '    Try
    '        oDom.Load(strPath)

    '        Dim elemList As XmlNodeList = oDom.GetElementsByTagName("aplicaciones")
    '        Dim i As Integer = 0

    '        For i = 1 To elemList(i).ChildNodes.Count

    '            Debug.Print(elemList(i).ChildNodes(i).Name.ToString)

    '            If elemList(i).ChildNodes(i).Name.ToString = strAplicacion Then
    '                Debug.Print("nada")
    '            End If

    '        Next i

    '    Catch ex As Exception

    '    End Try
    '    Return _string

    'End Function


    ''' <summary>
    ''' Médoto que permite obtener el origen de la cadena de conexión desde un archivo Xml
    ''' </summary>
    ''' <param name="strPath">Url de origen de la conexión</param>
    ''' <param name="strAplicacion">Nodo del xml para tomar la cadena</param>
    ''' <returns></returns>
    Public Function ObtenerStringDeArchivoXML(ByVal strPath As String, ByVal strAplicacion As String) As String
        Dim oDom As New XmlDocument()
        Dim _string As String = ""

        Try
            oDom.Load(strPath)

            Dim elemList As XmlNodeList = oDom.GetElementsByTagName("aplicaciones")
            Dim i As Integer = 0

            For i = 1 To elemList(i).ChildNodes.Count

                Debug.Print(elemList(i).ChildNodes(i).Name.ToString)

                If elemList(i).ChildNodes(i).Name.ToString = strAplicacion Then
                    Debug.Print("nada")
                End If

            Next i

        Catch ex As Exception
            Dim oErr As New cError()
            oErr.Exc_Client_msg = "Se produjo un Error al intentar leer la cadena de conexión desde el archivo XML"
            oErr.Exc_Message = ex.Message
            oErr.Exc_Source = "svr.modConexion"
            Throw oErr
        End Try
        Return _string

    End Function

    ''' <summary>
    ''' Médoto que permite obtener el origen de la cadena de conexión desde un archivo Xml tomando el tag "ccss" 
    ''' </summary>
    ''' <param name="strPath">Url de origen de la conexión</param>
    ''' <param name="strAplicacion">Nodo del xml para tomar la cadena</param>
    ''' <param name="strParametro">Este parámetro NO se usa</param>
    ''' <returns></returns>
    Public Function ObtenerStringDeArchivoXML3(ByVal strPath As String, ByVal strAplicacion As String, ByVal strParametro As String) As String

        Dim xmldoc As XmlDocument = New XmlDocument()
        Dim _string As String = ""

        Try
            xmldoc.Load(strPath)

            Dim DocumentNodeList As XmlNodeList = xmldoc.GetElementsByTagName("aplicaciones")

            For Each DocumentNode As XmlNode In DocumentNodeList
                Dim ChildNodeList As XmlNodeList = DocumentNode.ChildNodes

                For Each ChildNode As XmlNode In ChildNodeList
                    If ChildNode.Name.ToUpper.ToString = strAplicacion.ToUpper.ToString Then
                        Dim VNODE As XmlNode = ChildNode.SelectSingleNode("ccss")
                        If VNODE IsNot Nothing Then
                            _string = VNODE.InnerText
                            Exit For
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            Dim oErr As New cError()
            oErr.Exc_Client_msg = "Se produjo un Error al intentar leer la cadena de conexión desde el archivo XML"
            oErr.Exc_Message = ex.Message
            _string = ex.Message
            oErr.Exc_Source = "svr.modConexion"
        End Try

        Return _string
    End Function

End Module
