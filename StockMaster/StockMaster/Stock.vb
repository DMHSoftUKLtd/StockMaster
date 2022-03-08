Imports System.Data.SqlClient
Imports System.Data
Public Class Stock
    Inherits Utility
    Public SeasonName As String
    Public DeadCode As Boolean
    Public ZeroQty As Boolean
    Public AmountTaken As Decimal
    Public CostValue As Decimal
    Public PCMarkUp As Decimal

    Public Sub New()

    End Sub
    Protected Overrides Sub Finalize()

    End Sub
    Public Sub SaveStockRecordToDB()

    End Sub

    Public Sub UpdateStockRecordToDB()

    End Sub

    Public Sub DeleteStockRecordToDB()

    End Sub
    Public Function TotalStockTransactions() As Integer
        Return -0
    End Function

    Public Function UpdateAmountTaken() As Boolean
        Return False
    End Function

    Public Function UpdateCostValue() As Boolean
        Return False
    End Function

    Public Function UpdateDelQtyHangers() As Boolean
        Return False
    End Function

    Public Function UpdateDelQtyBoxes() As Boolean
        Return False
    End Function

    Public Function UpdateDelQtyGarments() As Boolean
        Return False
    End Function

    Public Function CheckStockCodeSave() As Integer
        Return 0
    End Function

    Public Function UpdatePCMarkUp() As Boolean
        Return False
    End Function

    Public Function GetWarehouseStockQty() As Integer
        Return -0
    End Function

    Public Function GetShopStockQty() As Integer
        Return -0
    End Function

    Public Function GetWarehouseStockValue() As Decimal
        Return 9.3
    End Function

    Public Function GetShopStockValue() As Decimal
        Return 3.4
    End Function
End Class
