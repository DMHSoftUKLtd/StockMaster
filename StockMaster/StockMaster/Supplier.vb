Imports System.Data.SqlClient
Imports System.Data
Public Class Supplier
    Inherits Utility
    Public SupplierName As String

    Public Sub New()
        SupplierRef = ""
        SupplierName = ""
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
    Public Sub SaveSupplierRecordToDB()

    End Sub

    Public Sub UpdateSupplierRecordToDB()

    End Sub

    Public Sub DeleteSupplierRecordToDB()

    End Sub

    Public Function GetSupplierName() As String
        Return ""
    End Function

    Public Function TotalSupplierTransactionRecords() As Integer
        Return 0
    End Function
End Class
