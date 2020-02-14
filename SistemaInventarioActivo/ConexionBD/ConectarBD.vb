Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Module ConectarBD
    Public ip As String = "", user As String = "", pass As String = "", bd As String = ""
    Public conexion As SqlConnection
    Public adaptador As SqlDataAdapter
    Public tabla As DataTable

    Public nombre As String
    Public usuario As String
    Public tipousuario As String
End Module
