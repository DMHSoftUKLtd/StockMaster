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
        Using conn As New SqlConnection(GetConnString(1))
            Using SaveCmd As New SqlCommand()
                With SaveCmd
                    .Connection = conn
                    .Connection.Open()
                    .CommandType = CommandType.Text
                    .CommandText = "INSERT INTO tblWarehouses (WarehouseRef,WarehouseName,Address1,Address2,Address3,Address4,PostCode,ContactName,Telephone,Telephone2,Fax,eMail,WarehouseType,Memo,CreatedBy,CreatedDate) VALUES (@WarehouseRef,@WarehouseName,@Address1,@Address2,@Address3,@Address4,@PostCode,@ContactName,@Telephone,@Telephone2,@Fax,@eMail,@WarehouseType,@Memo,@CreatedBy,@CreatedDate)"
                    With .Parameters
                        .AddWithValue("@WarehouseRef", WarehouseRef)
                        .AddWithValue("@WarehouseName", WarehouseName)
                        .AddWithValue("@Address1", AddressLine1)
                        .AddWithValue("@Address2", AddressLine2)
                        .AddWithValue("@Address3", AddressLine3)
                        .AddWithValue("@Address4", AddressLine4)
                        .AddWithValue("@PostCode", PostCode)
                        .AddWithValue("@ContactName", ContactName)
                        .AddWithValue("@Telephone", Telephone)
                        .AddWithValue("@Fax", Fax)
                        .AddWithValue("@eMail", eMail)
                        .AddWithValue("@Memo", Memo)
                        .AddWithValue("@WarehouseType", WarehouseType)
                        .AddWithValue("@CreatedBy", UserID)
                        .AddWithValue("@CreatedDate", Date.Now)
                    End With
                    .ExecuteNonQuery()
                End With
            End Using
        End Using
    End Sub

    Public Sub UpdateWarehouseRecordToDB()
        Using conn As New SqlConnection(GetConnString(1))
            Using UpdateCmd As New SqlCommand()
                With UpdateCmd
                    .Connection = conn
                    .Connection.Open()
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE tblWarehouses SET WarehouseName = @WarehouseName,Address1=@Address1,Address2=@Address2,Address3=@Address3,Address4 = @Address4,PostCode = @PostCode,ContactName = @ContactName,Telephone = Telephone,Telephone2 = @Telephone2,Fax = @Fax,eMail = @eMail,Memo = @Memo,WarehouseType = @WarehouseType WHERE WarehouseRef = @WarehouseRef"
                    With .Parameters
                        .AddWithValue("@WarehouseRef", WarehouseRef)
                        .AddWithValue("@WarehouseName", WarehouseName)
                        .AddWithValue("@Address1", AddressLine1)
                        .AddWithValue("@Address2", AddressLine2)
                        .AddWithValue("@Address3", AddressLine3)
                        .AddWithValue("@Address4", AddressLine4)
                        .AddWithValue("@PostCode", PostCode)
                        .AddWithValue("@ContactName", ContactName)
                        .AddWithValue("@Telephone", Telephone)
                        .AddWithValue("@Fax", Fax)
                        .AddWithValue("@eMail", eMail)
                        .AddWithValue("@Memo", Memo)
                        .AddWithValue("@WarehouseType", WarehouseType)
                    End With
                    .ExecuteNonQuery()
                End With
            End Using
        End Using
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
