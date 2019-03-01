Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Dim strNames(49, 3) As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        txtName.SelectAll()

        Dim strName As String = ("")
        Dim strYear As String = ("")
        Dim strAge As String = ("")
        Dim dblAge As Double
        Dim strConcantenatedInfo As String
        Dim intIndex As Integer

        'Double.TryParse(strAge, dblAge)
        'strAge = dblAge.ToString("N2")
        'strConcantenatedInfo = strName.PadRight(40) & strAge.PadRight(35) & strYear.PadLeft(5)

        ' lstNames.Items.Add(strConcantenatedInfo)

        If txtName.Text.Trim <> "" Then
            lstNames.Items.Add(txtName.Text)
            txtName.Clear()
        End If

        If txtAge.Text.Trim <> "" Then
            lstAge.Items.Add(txtAge.Text)
            txtAge.Clear()
        End If

        If txtYear.Text.Trim <> "" Then
            lstYear.Items.Add(txtYear.Text)
            txtYear.Clear()
        End If

        'Dim intHighRow As Integer = strNames.GetUpperBound(0)
        'Dim intHighCol As Integer = strNames.GetUpperBound(1)
        'Dim intR As Integer
        'Dim intC As Integer
        'Do While intC <= intHighCol
        '    intR = 0
        '    Do While intR <= intHighRow
        '        lstNames.Items.Add(strNames(intR, intC))
        '        intR += 1
        '    Loop
        '    intC += 1
        'Loop
    End Sub
    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        'Dim intname As Integer
        'Dim strAge As String
        'Dim dblAge As Double
        'Double.TryParse(strAge, dblAge)
        'strAge = dblAge.ToString("N2")
        'Integer.TryParse(txtName.Text, intname)
        'Double.TryParse(txtAge.Text, dblAge)

        'For i As Integer = 1 To 100
        '    intname.Add(i)
        'Next i

        'Dim rand As New Random
        'Dim index As Integer
        'Dim item As Object

        ' Display the items in random order.
        'For item.Count > 0
        ''Choose a random index.
        'index = rand.Next(0, name.Count)

        '    '     'Get the item at that index.
        '    '     'item = name(index)
        '    '     'End Get
        '    '     ' Remove the item so that it cannot be chosen again.
        '    '     name.RemoveAt(index)
        '    '     ' Display the item.
        '    MessageBox.Show(item.ToString())
        'Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstNames.Items.Clear()
        lstAge.Items.Clear()
        lstYear.Items.Clear()
        txtName.Text = String.Empty
        txtAge.Text = String.Empty
        txtYear.Text = String.Empty
        txtName.Focus()

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim average As Double = lstAge.Items.Cast(Of String)().Select(Function(s) CDbl(s)).Average()
        MessageBox.Show(CType(average, String))
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strSearchName As String
        Dim intSub As Integer
        Dim dblAge As Double

        strSearchName = txtName.Text

        For counter As Integer = 0 To 49
            MessageBox.Show(lstNames.Text)
        Next


        'Do Until intSub = lstNames OrElse
        '     lstNamesSub += 1
        'Loop
        'lstNames.Text = ""
        'If intSub < lstNames.Text Then
        '    dblAge = lstNames(intSub).dblAge

        'End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText("names.txt")
        For intIndex As Integer = 0 To lstNames.Items.Count - 1
            outFile.WriteLine(lstNames.Items(intIndex))
        Next intIndex

        outFile.Close()

    End Sub
    Dim inFile As IO.StreamReader
    '    Dim strInfo As String

    '    If IO.File.Exists("Name.Txt") Then
    '        inFile = IO.File.OpenText("Name.txt")
    '        Do Until inFile.Peek = -1
    '            strInfo = inFile.ReadLine
    '            lstNames.Items.Add(strInfo)
    '        Loop
    '        inFile.Close()
    '        lstNames.SelectedIndex = 0
    '    Else
    '        MessageBox.Show("Can't find the Names.txt file", "Names", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

End Class
