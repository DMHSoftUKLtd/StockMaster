Public Class PurchaseOrderForm
    Private Sub TxtWarehouseRef_Leave(sender As Object, e As EventArgs) Handles TxtWarehouseRef.Leave
        Utility.ChangeCase(TxtWarehouseRef.Text, 0)
    End Sub

    Private Sub TxtSupplierRef_Leave(sender As Object, e As EventArgs) Handles TxtSupplierRef.Leave
        Utility.ChangeCase(TxtSupplierRef.Text, 0)

    End Sub

    Private Sub DteMovementDate_ValueChanged(sender As Object, e As EventArgs) Handles DteMovementDate.ValueChanged

    End Sub

    Private Sub TxtOurRef_Leave(sender As Object, e As EventArgs) Handles TxtOurRef.Leave
        Utility.ChangeCase(TxtOurRef.Text, 0)
    End Sub

    Private Sub TxtStockCode_Leave(sender As Object, e As EventArgs) Handles TxtStockCode.Leave
        Utility.ChangeCase(TxtStockCode.Text, 0)
    End Sub

    Private Sub TxtShipperName_Leave(sender As Object, e As EventArgs) Handles TxtShipperName.Leave
        Utility.ChangeCase(TxtShipperName.Text, 0)
    End Sub

    Private Sub TxtDeliveryCharges_Leave(sender As Object, e As EventArgs) Handles TxtDeliveryCharges.Leave

    End Sub

    Private Sub TxtCommission_Leave(sender As Object, e As EventArgs) Handles TxtCommission.Leave

    End Sub

    Private Sub TxtVATAmount_Leave(sender As Object, e As EventArgs) Handles TxtVATAmount.Leave

    End Sub

    Private Sub CmdAddToGrid_Click(sender As Object, e As EventArgs) Handles CmdAddToGrid.Click

    End Sub

    Private Sub CmdDeleteFromGrid_Click(sender As Object, e As EventArgs) Handles CmdDeleteFromGrid.Click

    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ' Add code to save and update to the database from the form
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()  ' Close the form without saving
    End Sub

    Private Sub PurchaseOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class