Public Class Form2

    Private Sub DetailsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DetailsDataSet)

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DetailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.DetailsDataSet.Details)

    End Sub
End Class