﻿Imports System.Security.Cryptography
Imports System.Text

Public NotInheritable Class Encryption
    Private Sub New()
    End Sub

    Shared pass As String = Chr(65) & Chr(118) & Chr(65) & Chr(65) & Chr(46) & Chr(49) & Chr(52) & Chr(56) & Chr(48)
    Private Shared Function vSal(ByVal d As String) As String
        d = d & "gna2015"
        Return d
    End Function
    Public Shared Function CreateRandomString(ByVal StringLength As Integer) As String
        Dim text As String = "0123456789qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM"
        Dim random As Random = New Random()
        ' The following expression was wrapped in a checked-statement
        Dim array As Char() = New Char(StringLength - 1 + 1 - 1) {}
        Dim length As Integer = text.Length
        Dim arg_25_0 As Integer = 0
        Dim num As Integer = StringLength - 1
        For i As Integer = arg_25_0 To num
            ' The following expression was wrapped in a unchecked-expression
            array(i) = text(CInt(Math.Round(Conversion.Fix(CDec(text.Length) * random.NextDouble()))))
        Next
        Return New String(array)
    End Function
    Public Shared Function SelfEncrypt(ByVal original As String) As String
        Dim random As String
        Dim tuneada As String
        Dim final As String
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim par As Boolean = False
        x = 0
        y = 0
        z = 0
        final = ""
        random = CreateRandomString(15)
        tuneada = Encrypt(original, True, random)
        While (x < tuneada.Length + 15)
            If Not par Or z >= 15 Then
                final = final & tuneada.Chars(y)
                y = y + 1
                par = True
            Else
                final = final & random.Chars(z)
                z = z + 1
                par = False
            End If
            x = x + 1
        End While

        Return final
    End Function

    Public Shared Function SelfDecrypt(ByVal final As String) As String
        Dim random As String
        Dim original As String
        Dim tuneada As String
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim par As Boolean = False
        x = 0
        y = 0
        z = 0
        tuneada = ""
        random = ""
        original = ""
        While (x < final.Length)
            If Not par Or z >= 15 Then
                tuneada = tuneada & final.Chars(x)
                y = y + 1
                par = True
            Else
                random = random & final.Chars(x)
                z = z + 1
                par = False
            End If
            x = x + 1
        End While
        original = Decrypt(tuneada, True, random)
        Return original
    End Function
    Public Shared Function Encrypt(toEncrypt As String) As String
        Dim useHashing As Boolean = True
        Dim Rsp As String = ""
        Dim keyArray As Byte()
        Try
            Dim toEncryptArray As Byte() = UTF8Encoding.UTF8.GetBytes(toEncrypt)

            Dim key As String = pass
            If useHashing Then
                Dim hashmd5 As New MD5CryptoServiceProvider()
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
                hashmd5.Clear()
            Else
                keyArray = UTF8Encoding.UTF8.GetBytes(key)
            End If

            Dim tdes As New TripleDESCryptoServiceProvider()
            tdes.Key = keyArray
            tdes.Mode = CipherMode.ECB
            tdes.Padding = PaddingMode.PKCS7
            Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
            tdes.Clear()
            Rsp = Convert.ToBase64String(resultArray, 0, resultArray.Length)
        Catch ex As Exception
            Throw New Exception("Error. Dato inconsistente. [ENC]")
        End Try
        Return Rsp
    End Function

    Public Shared Function Decrypt(cipherString As String) As String
        Dim useHashing As Boolean = True
        Dim Rsp As String = ""
        Dim keyArray As Byte()
        Try
            Dim toEncryptArray As Byte() = Convert.FromBase64String(cipherString)
            Dim key As String = pass
            If useHashing Then
                'if hashing was used get the hash code with regards to your key
                Dim hashmd5 As New MD5CryptoServiceProvider()
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
                'release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear()
            Else
                'if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key)
            End If

            Dim tdes As New TripleDESCryptoServiceProvider()
            'set the secret key for the tripleDES algorithm
            tdes.Key = keyArray
            'mode of operation. there are other 4 modes. 
            'We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB
            'padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7

            Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
            Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
            'Release resources held by TripleDes Encryptor                
            tdes.Clear()
            'return the Clear decrypted TEXT
            Rsp = UTF8Encoding.UTF8.GetString(resultArray)
        Catch ex As Exception
            Throw New Exception("Error. Dato inconsistente. [DES]")
        End Try
        Return Rsp
    End Function
    Public Shared Function Encrypt(ByVal toEncrypt As String, ByVal useHashing As Boolean, ByVal pass As String) As String
        Dim keyArray As Byte()
        Dim toEncryptArray As Byte() = UTF8Encoding.UTF8.GetBytes(toEncrypt)

        'System.Configuration.AppSettingsReader settingsReader =
        '                                    new AppSettingsReader();
        ''/ Get the key from config file

        'string key = (string)settingsReader.GetValue("SecurityKey",
        '                                                 typeof(String));
        Dim key As String = pass
        'System.Windows.Forms.MessageBox.Show(key);
        'If hashing use get hashcode regards to your key
        If useHashing Then
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            'Always release the resources and flush data
            ' of the Cryptographic service provide. Best Practice

            hashmd5.Clear()
        Else
            keyArray = UTF8Encoding.UTF8.GetBytes(key)
        End If

        Dim tdes As New TripleDESCryptoServiceProvider()
        'set the secret key for the tripleDES algorithm
        tdes.Key = keyArray
        'mode of operation. there are other 4 modes.
        'We choose ECB(Electronic code Book)
        tdes.Mode = CipherMode.ECB
        'padding mode(if any extra byte added)

        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateEncryptor()
        'transform the specified region of bytes array to resultArray
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
        'Release resources held by TripleDes Encryptor
        tdes.Clear()
        'Return the encrypted data into unreadable string format
        Return Convert.ToBase64String(resultArray, 0, resultArray.Length)
    End Function

    Public Shared Function Decrypt(ByVal cipherString As String, ByVal useHashing As Boolean, ByVal pass As String) As String
        Dim keyArray As Byte()
        'get the byte code of the string

        Dim toEncryptArray As Byte() = Convert.FromBase64String(cipherString)

        'System.Configuration.AppSettingsReader settingsReader =
        '                                    new AppSettingsReader();
        ''/Get your key from config file to open the lock!
        'string key = (string)settingsReader.GetValue("SecurityKey",
        '                                             typeof(String));
        Dim key As String = pass

        If useHashing Then
            'if hashing was used get the hash code with regards to your key
            Dim hashmd5 As New MD5CryptoServiceProvider()
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key))
            'release any resource held by the MD5CryptoServiceProvider

            hashmd5.Clear()
        Else
            'if hashing was not implemented get the byte code of the key
            keyArray = UTF8Encoding.UTF8.GetBytes(key)
        End If

        Dim tdes As New TripleDESCryptoServiceProvider()
        'set the secret key for the tripleDES algorithm
        tdes.Key = keyArray
        'mode of operation. there are other 4 modes. 
        'We choose ECB(Electronic code Book)

        tdes.Mode = CipherMode.ECB
        'padding mode(if any extra byte added)
        tdes.Padding = PaddingMode.PKCS7

        Dim cTransform As ICryptoTransform = tdes.CreateDecryptor()
        Dim resultArray As Byte() = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
        'Release resources held by TripleDes Encryptor                
        tdes.Clear()
        'return the Clear decrypted TEXT
        Return UTF8Encoding.UTF8.GetString(resultArray)
    End Function

    Public Shared Function GenerateSaltedSHA1(ByVal plainTextString As String) As String
        Dim algorithm As HashAlgorithm = New SHA1Managed()
        Dim saltBytes = GenerateSalt(4)
        Dim plainTextBytes = Encoding.ASCII.GetBytes(plainTextString)

        Dim plainTextWithSaltBytes = AppendByteArray(plainTextBytes, saltBytes)
        Dim saltedSHA1Bytes = algorithm.ComputeHash(plainTextWithSaltBytes)
        Dim saltedSHA1WithAppendedSaltBytes = AppendByteArray(saltedSHA1Bytes, saltBytes)

        Return "{SSHA}" + Convert.ToBase64String(saltedSHA1WithAppendedSaltBytes)
    End Function

    Public Shared Function GenerateSHA1Hash(ByVal dataArray As Byte()) As Byte()
        Dim sha As HashAlgorithm = New SHA1CryptoServiceProvider()
        Dim result As Byte() = sha.ComputeHash(dataArray)
        Return result
    End Function
    'Public Shared Function GenerateSaltedSHA1(plainTextString As String) As String
    '    Dim algorithm As HashAlgorithm = New SHA1Managed()
    '    Dim saltBytes = GenerateSalt(4)
    '    Dim plainTextBytes = Encoding.ASCII.GetBytes(plainTextString)

    '    Dim plainTextWithSaltBytes = AppendByteArray(plainTextBytes, saltBytes)
    '    Dim saltedSHA1Bytes = algorithm.ComputeHash(plainTextWithSaltBytes)
    '    Dim saltedSHA1WithAppendedSaltBytes = AppendByteArray(saltedSHA1Bytes, saltBytes)

    '    Return "{SSHA}" & Convert.ToBase64String(saltedSHA1WithAppendedSaltBytes)
    'End Function

    '    Public Shared Function GenerateSHA1Hash(dataArray As Byte()) As Byte()
    ' Dim sha As HashAlgorithm = New SHA1CryptoServiceProvider()
    ' Dim result As Byte() = sha.ComputeHash(dataArray)
    '     Return result
    ' End Function

    Private Shared Function GenerateSalt(saltSize As Integer) As Byte()
        Dim rng = New RNGCryptoServiceProvider()
        Dim buff = New Byte(saltSize - 1) {}
        rng.GetBytes(buff)
        Return buff
    End Function

    Private Shared Function AppendByteArray(byteArray1 As Byte(), byteArray2 As Byte()) As Byte()
        Dim byteArrayResult = New Byte(byteArray1.Length + (byteArray2.Length - 1)) {}
        Dim i As Integer
        For i = 0 To byteArray1.Length - 1
            byteArrayResult(i) = byteArray1(i)
        Next
        For i = 0 To byteArray2.Length - 1
            byteArrayResult(byteArray1.Length + i) = byteArray2(i)
        Next

        Return byteArrayResult
    End Function

    Public Shared Function GetCrypt(text As String) As String
        Dim hash As String = ""
        Dim alg As SHA512 = SHA512.Create()
        Dim result As Byte() = alg.ComputeHash(Encoding.UTF8.GetBytes(text))
        hash = Encoding.UTF8.GetString(result)
        Return hash
    End Function
End Class
