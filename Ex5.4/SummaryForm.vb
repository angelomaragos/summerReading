'
'
'
'
Public Class SummaryForm


    Private Sub SummaryForm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Get data

        AverageTextBox.Text = SummerReading.avg.ToString("N")
    End Sub
    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        'Close the summary form

        Me.Hide()
    End Sub
End Class