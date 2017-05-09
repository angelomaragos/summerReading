'Program Name:      Summer Reading
'Programmer:        Angelo Maragos
'Date:              November 4, 2012
'Description:       This program calculates the bonus points earned in a summer reading program. 

Public Class SummerReading
    'Declare the new object

    Private logic As bookCalc
    Private totalB, numB As Integer
    Private rCnt As Integer
    Friend avg As Decimal


    Private Sub PointsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PointsToolStripMenuItem.Click
        'Calculate the points earned

        Try
            'Instantiate the object and set the properties

            logic = New bookCalc(NameTextBox.Text, Integer.Parse(NumberOfBooksTextBox.Text))

            'Calculate and format the result

            BonusPointsRichTextBox.Text = logic.BonusPoints.ToString("N0")
            numB = Integer.Parse(NumberOfBooksTextBox.Text)
            totalB += numB
            rCnt += 1

        Catch ex As Exception
            MessageBox.Show("Enter numeric data", "Library Points System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear all fields

        NumberOfBooksTextBox.Clear()
        BonusPointsRichTextBox.Clear()
        With NameTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit Program

        Me.Close()
    End Sub


    Private Sub SummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        'Show summary form


        avg = totalB / rCnt
        SummaryForm.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' select a new font for the bonus point

        With FontDialog1
            .Font = BonusPointsRichTextBox.Font
            .ShowDialog()
            BonusPointsRichTextBox.Font = .Font
        End With
    End Sub

    Private Sub BonusPointsRichTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles BonusPointsRichTextBox.TextChanged
        'Alignment

        BonusPointsRichTextBox.SelectAll()
        BonusPointsRichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Show the about box

        AboutBox.ShowDialog()
    End Sub


    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' select a different color for the bonus point

        With ColorDialog1
            .Color = BonusPointsRichTextBox.ForeColor
            .ShowDialog()
            BonusPointsRichTextBox.ForeColor = .Color
        End With
    End Sub

End Class


