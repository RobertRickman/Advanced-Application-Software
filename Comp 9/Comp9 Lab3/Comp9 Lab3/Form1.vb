Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboFinish.Items.Add("Silver Plate")
        cboFinish.Items.Add("Solid Brass")
        cboFinish.SelectedItem = "Silver Plate"

        For dblLights As Double = 1 To 12
            cboLights.Items.Add(dblLights.ToString)
        Next dblLights
        cboLights.SelectedItem = "1"

    End Sub
    Public Class Chandelier
        Private _intSilver As Integer
        Private _intBrass As Integer
        Private _intCrystal As Integer

        Structure Finish
            Public dblSilver As Double
            Public dblBrass As Double
            Public dblCrystal As Double
        End Structure

        Private _dblTotal As Integer

        Public Property Chandelier As Integer

            Get
                Return _dblTotal
            End Get
            Set(cost As Integer)
                If cost > 0 Then
                    _dblTotal = cost
                Else
                    _dblTotal = 0
                End If
            End Set
        End Property
    End Class

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim _dblSilver As Integer
        Dim _dblBrass As Integer
        Dim _dblCrystal As Integer
        Dim Finish As New Chandelier
        Dim strSilver As String
        Dim strBrass As String
        Dim strCrystal As String

        'intRow = 0
        'intCol = 0
        'IndexCounter = 0

        'If IndexCounter > finish Then
        '    MessageBox.Show("List to full")
        '    Exit Sub
        'End If

        'blnisvalid = Double.TryParse(InputBox("Enter item price", "Price"), dblPrices)
        'If blnisvalid = False Then
        '    MessageBox.Show("Invalid data. Please enter a string")
        '    Exit Sub
        'End If

        'blnisvalid = Double.TryParse(InputBox("Enter item quantity", "Quantity"), quantity)

        'If blnisvalid = False Then
        '    MessageBox.Show("Invlid quantity. Please intput a number")
        '    Exit Sub
        'End If

        'Finish.selectedItems.Add(currentfinish)
        'Finish(IndexCounter, 0) = dblPrices
        'finsih(IndexCounter, 1) = quantity

        'IndexCounter = IndexCounter + 1
        'If IndexCounter = 0 Then
        '    lstHardware.SelectedIndex = 0
        'End If

    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        Dim result As String = " "
        Dim finish As New Chandelier

        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim lights As Integer
        Dim quantity As Integer
        Dim cost As String = " "

        Double.TryParse(cboFinish.SelectedItem.ToString, Num1)
        Double.TryParse(cboFinish.SelectedItem.ToString, Num2)
        Double.TryParse(cboFinish.SelectedItem.ToString, Num3)
        Double.TryParse(cboLights.SelectedItem.ToString, quantity)
        Double.TryParse(cboLights.SelectedItem.ToString, lights)
        cost = Num1 * 29.99 + Num2 * 39.99 + Num3 * 25.5



        If chkCrystal.Checked = True Then
            result = result & " and Crystal Trimming"
        End If

        MessageBox.Show("You have ordered the following Chandelier(s): " & ControlChars.NewLine & lights & " light(s) with a Silver Plate Finish" & result & ControlChars.NewLine & lights & " light(s) with a Solid Brass Finish" & result & ControlChars.NewLine & "For a total of: " & cost)
    End Sub

End Class