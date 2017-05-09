' vb class
'bookCalc

Public Class bookCalc

    Private NameString As String
    Private numB As Integer
    Private BonusPointsInteger As Integer

    Public Sub New(ByVal NameIn As String, ByVal NumberOfBooksIn As Integer)
        'Assign the property values

        Name = NameIn
        NumberOfBooks = NumberOfBooksIn
        CalculateBonusPoints()
    End Sub

    Property Name() As String
        Get
            Return NameString
        End Get
        Set(value As String)
            NameString = value
        End Set
    End Property

    Property NumberOfBooks() As Integer
        Get
            Return numB
        End Get
        Set(value As Integer)
            If value >= 0 Then
                numB = value
            End If
        End Set
    End Property

    Property BonusPoints() As Integer
        Get
            Return BonusPointsInteger
        End Get
        Set(value As Integer)
            If value >= 0 Then
                BonusPointsInteger = value
            End If
        End Set
    End Property

    Protected Sub CalculateBonusPoints()

        'Calculate  bonus

        If numB <= 3 Then
            BonusPointsInteger = numB * 10
        ElseIf numB <= 6 Then
            BonusPointsInteger = (3 * 10) + ((numB - 3) * 15)
        ElseIf numB > 6 Then
            BonusPointsInteger = (3 * 19) + (3 * 15) + ((numB - 6) * 20)
        End If
    End Sub
End Class