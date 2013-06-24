Imports System.Data.OleDb

Public Class frmStoreInventory

    Private Sub ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Dim ProductDetailID As Integer = ProductDetailDataGridView.Item(0, ProductDetailDataGridView.CurrentRow.Index).Value
        Dim intActualQtyOH As Integer = ProductDetailDataGridView.Item("ActualQtyOnHand", ProductDetailDataGridView.CurrentRow.Index).Value
        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        Dim Status As String = cb.Text

        If Status IsNot Nothing Then
            Dim intCount As Integer = CountRows("SELECT ProductDetailID FROM StoreInventory WHERE ProductDetailID  = " & ProductDetailID)

            If intCount > 0 Then
                ExecNonQuery("UPDATE StoreInventory SET StoreInventory.ActualQtyOnHand = " & intActualQtyOH & ", StoreInventory.Status = '" & Status & "' " _
                            & "WHERE ProductDetailID= " & ProductDetailID)
            Else
                ExecNonQuery("INSERT INTO StoreInventory ( ActualQtyOnHand, Status ) VALUES (" & intActualQtyOH & ", '" & Status & "')")
            End If
        End If
    End Sub

    Private Sub ProductDetailDataGridView_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ProductDetailDataGridView.EditingControlShowing
        Dim combo As ComboBox = TryCast(e.Control, ComboBox)

        If combo IsNot Nothing Then
            RemoveHandler combo.SelectionChangeCommitted, AddressOf ComboBox_SelectionChangeCommitted
            AddHandler combo.SelectionChangeCommitted, AddressOf ComboBox_SelectionChangeCommitted
        End If
    End Sub

    Private Sub ProductDetailBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductDetailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductDetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductDataSet)

    End Sub

    Private Sub frmStoreInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.ProductTableAdapter.Fill(Me.ProductDataSet.Product)
        Me.ProductDetailTableAdapter.Fill(Me.ProductDataSet.ProductDetail)

    End Sub
End Class