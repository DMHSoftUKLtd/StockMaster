Imports System.Data.SqlClient
Imports System.Data
Public Class Warehouse
    Inherits Utility
    Public WarehouseName As String
    Public WarehouseType As String

    Public Sub New()
        WarehouseRef = ""
        SaveToDB = False
        UpdateInDB = False
        DeleteFromDB = False
    End Sub
    Protected Overrides Sub Finalize()

    End Sub
    Public Sub LoadNewRecord()

    End Sub

    Public Sub LoadOldRecord()

    End Sub

    Public Sub SaveWarehouseRecordToDB()

    End Sub

    Public Sub UpdateWarehouseRecordToDB()

    End Sub

    Public Sub DeleteWarehouseRecordToDB()

    End Sub

    Public Function GetWarehouseName() As String
        Return ""
    End Function

    Public Function GetTotalWarehouseRecords() As Integer
        Return 0
    End Function

End Class
