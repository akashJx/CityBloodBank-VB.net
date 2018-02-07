Public Class Form3
    Private Sub DonerDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DonerDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DonerDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CityBloodBankDBDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CityBloodBankDBDataSet.DonerDetails' table. You can move, or remove it, as needed.
        Me.DonerDetailsTableAdapter.Fill(Me.CityBloodBankDBDataSet.DonerDetails)

    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        DonerDetailsBindingSource.AddNew()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            DonerDetailsBindingSource.EndEdit()
            DonerDetailsTableAdapter.Update(CityBloodBankDBDataSet.DonerDetails)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("ERROR IN SAVING DATA.!!")
        End Try
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' DonerDetailsBindingSource.RemoveCurrent()
        DonerDetailsBindingSource.AddNew()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class