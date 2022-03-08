Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Utility
    Public SaveToDB As Boolean
    Public UpdateInDB As Boolean
    Public DeleteFromDB As Boolean
    Public Result As Integer
    Public UserID As Integer
    Public WarehouseRef As String
    Public ShopRef As String
    Public SupplierRef As String
    Public StockCode As String
    Public DeliveredQtyHangers As Integer
    Public DeliveredQtyBoxes As Integer
    Public DeliveredQtyGarments As Integer
    Public AddressLine1 As String
    Public AddressLine2 As String
    Public AddressLine3 As String
    Public AddressLine4 As String
    Public PostCode As String
    Public Telephone As String
    Public ContactName As String
    Public Fax As String
    Public eMail As String
    Public WebsiteAddress As String
    Public Memo As String
    Public VATAmount As Decimal
    Public MovementDate As DateTime
    Public DeliveryType As String
    Public Reference As String
    Public SMovementType As String
    Public Qty As Integer
    Public TotalGainItems As Integer
    Public TotalLossItems As Integer
    Public Value As Decimal
    Public Function GetConnString(ID As Integer) As String
        ' Returns the correct Database connection string for the identity record.
        If ID = 1 Then
            Return "Initial Catalog=FYPv2;Data Source=(local);Persist Security Info=False;Integrated Security=true;"
        ElseIf ID = 2 Then
            Return "Initial Catalog=FYPv2;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ"
        ElseIf ID = 3 Then
            Return "Initial Catalog=master;Data Source=.\SQLEXPRESS;Persist Security Info=False;Integrated Security=true;"
        Else
            Return "Initial Catalog=master;Data Source=192.168.1.200;Persist Security Info=False;Integrated Security=false;User ID=FYPUser;Password=@35Adc@*K9z&QJ"
        End If
    End Function

    Public Function GetSundayDate(DatePicked As DateTime, DateType As Integer) As DateTime
        'Gives the correct Sunday's Date depending on the function that is calling the function.
        If DateType = 1 Then
            Return DatePicked.AddDays(0 - DatePicked.DayOfWeek)
        Else
            Return DatePicked.AddDays(0 - DatePicked.DayOfWeek + 7)
        End If
    End Function

    Public Function ChangeCase(TextToConvert As String, TextType As Integer) As String
        If TextType = 1 Then
            Return TextToConvert.ToUpper()
        ElseIf TextType = 2 Then
            Return TextToConvert.ToLower()
        Else
            Dim dt As TextInfo
            dt = New CultureInfo("en-GB", False).TextInfo
            Return dt.ToTitleCase(TextToConvert)
        End If
    End Function
End Class
