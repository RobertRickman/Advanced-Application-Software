Option Strict Off
Option Explicit On
Option Infer Off
Public Class Form1

    Private Structure Person
        Public Name As String
        Public Height As String
        Public Weight As String
    End Structure

    Private objPerson As Person

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strNames(49, 2) As String
        Dim intName As Integer
        Dim intWeight As Integer
        Dim intHeight As Integer
        Dim intSub As Integer

        Dim intHighRow As Integer = strNames.GetUpperBound(0)
        Dim intHighCol As Integer = strNames.GetUpperBound(1)
        Dim intR As Integer
        Dim intC As Integer
        Do While intC <= intHighCol
            intR = 0
            Do While intR < +intHighRow
                lstName.Items.Add(strNames(intR, intC))
            Loop
            intC += 1
        Loop
        Integer.TryParse(txtName.Text, intName)
        Integer.TryParse(txtHeight.Text, intHeight)
        Integer.TryParse(txtWeight.Text, intWeight)
        Dim lblResult As Object = Nothing
        'intSub = lblResult.SelectedIndex

        txtName.SelectAll()

        For Each strElement As String In strNames
            lblResult.Items.Add(strElement)

        Next strElement

        If txtName.Text.Trim <> "" Then
            lblResult.Items.Add(txtName.Text)
            txtName.Clear()
        End If

    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    Dim outFile As IO.StreamWriter

    '    outFile = IO.File.CreateText("Person.txt")
    '    For intIndex As Integer = 0 To lblResult.Items.Count - 1
    '        outFile.WriteLine(lblResult.Items(intIndex))
    '    Next intIndex

    '    outFile.Close()
    'End Sub

    'Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
    '    Dim inFile As IO.StreamReader
    '    Dim strInfo As String

    '    If IO.File.Exists("Person.Txt") Then
    '        inFile = IO.File.OpenText("Person.txt")
    '        Do Until inFile.Peek = -1
    '            strInfo = inFile.ReadLine
    '            lblResult.Items.Add(strInfo)
    '        Loop
    '        inFile.Close()
    '        lblResult.SelectedIndex = 0
    '    Else
    '        MessageBox.Show("Can't find the Person.txt file", "Person", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
        lstName.Items.Clear()
    End Sub


End Class

