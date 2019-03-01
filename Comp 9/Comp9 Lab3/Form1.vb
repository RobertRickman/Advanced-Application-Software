Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Class Chandelier

        Dim finishInfo As New Chandelier

        Structure Finish
            Public finishSilvererPlate As String
            Public FinishSolidBrass As String
            Public finishCrysatalTrimmings As String
        End Structure

        Private Function GetFinish(ByVal finish As A) As Double
            Const dblCOST_PER_SILVER As Double = 39.99
            Const dblCOST_PER_BRASS As Double = 49.99
            Const sblCOST_PER_CRYSTAL As Double = 25.5

            Return finish.b

        End Function
    End Class
End Class
