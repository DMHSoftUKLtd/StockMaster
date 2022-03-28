Imports System.Data.SqlClient
Imports System.Data
Public Class PurchaseOrder
    Inherits Utility
    Public Sub New()

    End Sub
    Protected Overrides Sub Finalize()

    End Sub
    Public Sub SavePurchaseOrderHeadRecordToDB()

    End Sub

    Public Sub UpdatePurchaseOrderHeadRecordToDB()

    End Sub

    Public Sub DeletePurchaseOrderHeadRecordInDB()

    End Sub
    Public Sub SavePurchaseOrderLineRecordToDB()

    End Sub

    Public Sub UpdatePurchaseOrderLineRecordToDB()

    End Sub

    Public Sub DeletePurchaseOrderLineRecordInDB()

    End Sub
    Public Function CheckLastSaved() As Integer
        Return 0
    End Function
End Class
