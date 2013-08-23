Public Class Form3

    Private Sub DetailsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DetailsDataSet)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DetailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.DetailsDataSet.Details)

    End Sub

    Private Sub Basic_PayLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Provident_FundLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GradeLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class