Public Class Form2
    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        Dim NewAddForm As New Form3
        Me.Hide()
        NewAddForm.ShowDialog()
        'DonerDetailsBindingSource.AddNew()
    End Sub

    Private Sub DonerDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DonerDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DonerDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CityBloodBankDBDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CityBloodBankDBDataSet.DonerDetails' table. You can move, or remove it, as needed.
        Me.DonerDetailsTableAdapter.Fill(Me.CityBloodBankDBDataSet.DonerDetails)

    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        DonerDetailsBindingSource.RemoveCurrent()
    End Sub
End Class