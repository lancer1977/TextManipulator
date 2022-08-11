Imports System.Xml
Imports System.Linq
Imports PolyhydraGames.Extensions


Public Class DataView
  Public Shared Function DataFromXML(ByVal filename As String) As DataSet
        Dim xmlFile As Xml.XmlReader = Xml.XmlReader.Create(filename)
        Dim ds As New DataSet
        Try
            ds.ReadXml(xmlFile)
        Catch
        End Try
        xmlFile.Close()
        Return (ds)
    End Function

    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            DataGridView1.DataMember = DataGridView1.DataSource.ta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(ColumnNames)


    End Sub


    Private Function ColumnNames() As String()
        Dim names As New List(Of String)
        For x As Integer = 0 To DataGridView1.Columns.Count - 1
            Try
                names.Add(DataGridView1.Columns(x).Name)
            Catch
            End Try

        Next
        Return names.ToArray
    End Function



    Private Sub DataView_ChangeUICues(ByVal sender As Object, ByVal e As UICuesEventArgs) _
        Handles Me.ChangeUICues

    End Sub

    Private Sub DataView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub OpenToolStripMenuItemClick1(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles OpenToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        open.InitialDirectory = "C:\Users\Lancer1977\Dropbox\Code\Character Sheet\Char Sheet Tabs\Data"
        open.ShowDialog()
        OpenFile(open.FileName)


    End Sub
    Private Sub OpenFile(ByVal fileName As String)
        If IO.File.Exists(fileName) AndAlso fileName.Contains(".xml") Then
            Dim mySet = DataFromXML(fileName)
            DataGridView1.DataSource = mySet
            DataGridView1.DataMember = mySet.Tables(0).ToString
            ComboBox1.Items.Clear()
            ComboBox1.Items.AddRange(ColumnNames)
        Else
            MsgBox("Invalid file")
        End If
    End Sub





    Private Sub SaveToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()


    End Sub

    Private Sub SaveFileDialog1FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) _
        Handles SaveFileDialog1.FileOk
        Dim thisDataSet As DataSet
        thisDataSet = DataGridView1.DataSource
        'Dim thisDataSet = mySet
        If thisDataSet Is Nothing Then
            Return
        End If

        ' Create a file name to write to. 
        Dim filename As String = SaveFileDialog1.FileName
        thisDataSet.WriteXml(filename, XmlWriteMode.WriteSchema)
        '' Create the FileStream to write with. 
        'Dim stream As New IO.FileStream _
        '        (filename, IO.FileMode.Create)

        '' Create an XmlTextWriter with the fileStream. 
        'Dim xmlWriter As New Xml.XmlTextWriter _
        '        (stream, System.Text.Encoding.Unicode)

        '' Write to the file with the WriteXml method.
        'xmlWriter.Formatting = Formatting.Indented
        'xmlWriter.Indentation = 4
        'xmlWriter.IndentChar = " "c

        'thisDataSet.WriteXml(xmlWriter)
        'xmlWriter.Close()
    End Sub

    Private Sub Button2Click(ByVal sender As System.Object, ByVal e As EventArgs)
        '  FormatSpells()


    End Sub

    Public Sub AddColumn()
        Dim mySet As DataSet
        mySet = DataGridView1.DataSource
        If mySet IsNot Nothing Then
            Dim colName As String
            colName = InputBox("New Column Name?")
            Dim contcolumn As New DataColumn(colName)
            Try
                mySet.Tables(0).Columns.AddRange({contcolumn})
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub SetClasses()
        For x = 0 To DataGridView1.Rows.Count - 2

            Dim temp As String = DataGridView1.Rows(x).Cells("Type").Value

            temp = StrConv(temp, vbProperCase)
            DataGridView1.Rows(x).Cells("Type").Value = temp
            Dim temp2 As String = DataGridView1.Rows(x).Cells("SubType").Value

            temp2 = StrConv(temp2, vbProperCase)
            DataGridView1.Rows(x).Cells("SubType").Value = temp2
        Next
    End Sub

    Public Sub SetLevels()
        Dim x As Integer
        Try
            For x = 0 To DataGridView1.Rows.Count - 2
                If DataGridView1.Rows(x).Cells("DontUseRacialHD").Value = "0" Then
                    Dim hd As Integer
                    Dim mobtype As String
                    Dim temp As String = DataGridView1.Rows(x).Cells("HD").Value
                    temp = temp.Replace("(", "")
                    temp = temp.Substring(0, InStr(temp, "d"))
                    hd = Val(temp)
                    mobtype = DataGridView1.Rows(x).Cells("Type").Value
                    Dim newtype = StrConv(mobtype & "," & hd, vbProperCase)
                    DataGridView1.Rows(x).Cells("Type").Value = newtype
                End If

            Next
        Catch ex As Exception
            MsgBox(x & vbNewLine & ex.ToString)
        End Try
    End Sub

    Public Sub StripChars(ByVal charList As Char())


        For x = 0 To DataGridView1.Rows.Count - 2

            Dim temp As String = DataGridView1.Rows(x).Cells("Name").Value
            For Each item In charList
                temp = temp.Replace(item, "")
            Next
            DataGridView1.Rows(x).Cells("Name").Value = temp
        Next
        Dim clip As String = ""

    End Sub

    Public Function GetNames() As List(Of String)

        Dim Mylist As New List(Of String)
        For x = 0 To DataGridView1.Rows.Count - 2

            Dim temp As String = DataGridView1.Rows(x).Cells("Name").Value

            temp = StrConv(temp, vbProperCase)
            temp = temp.Replace(" ", "")
            temp = temp.Replace(",", "")
            DataGridView1.Rows(x).Cells("Name").Value = temp
            Mylist.Add(temp)


        Next
        return MyList
    End Function

    Private Sub ClearRowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles ClearRowToolStripMenuItem.Click
        If MsgBox("Really clear all items in row " & ComboBox1.Text, vbYesNoCancel) = vbYes Then
            Try
                For x = 0 To DataGridView1.Rows.Count - 2
                    DataGridView1.Rows(x).Cells(ComboBox1.Text).Value = ""
                Next
                MsgBox("Done")
            Catch ex As Exception

                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub StripCharactersToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles StripCharactersToolStripMenuItem.Click
        Dim charList As String =
                InputBox("What characters (ex.  ,%$#@!) would you like to strip from the field " & ComboBox1.Text)

        If MsgBox("Really remove all " & charList & "  in row " & ComboBox1.Text, vbYesNoCancel) = vbYes Then
            StripChars(charList.ToCharArray)
        End If
    End Sub

    Private Sub FromDropdownSelectionToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) _
        Handles FromDropdownSelectionToolStripMenuItem.Click
        Dim Col As String = ComboBox1.Text
        If MsgBox("Really remove entire column " & Col, vbYesNoCancel) = vbYes Then
            CType(DataGridView1.DataSource, DataSet).Tables(0).Columns.Remove(Col)

        End If
    End Sub

    Private Sub FormatSpells()
        Dim x As Integer
        Try
            For x = 0 To 10 'DataGridView1.Rows.Count - 2
                Dim info As String = DataGridView1.Rows(x).Cells("SpellsKnown").Value
                info =
                    info.Replace("9th", "@").Replace("8th", "@").Replace("7th", "@").Replace("6th", "@").Replace(
                        "5th", "@").Replace("4th", "@").Replace("3rd", "@").Replace("2nd", "@").Replace("1st", "@").
                        Replace("0 (at will)", "@")
                '  DataGridView1.Rows(x).Cells(ComboBox1.Text).Value = info
                Dim slots As String = info.Replace("@", vbNewLine)
                MsgBox(slots)
            Next
        Catch ex As Exception
            MsgBox(x & vbNewLine & ex.ToString)
        End Try

    End Sub

    Private Sub AddColumnToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddColumnToolStripMenuItem.Click
        AddColumn()
    End Sub


    Private Sub TextEditorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TextEditorsToolStripMenuItem.Click
        ListTools.Show()

    End Sub

    Private Sub ArmorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArmorToolStripMenuItem.Click
        Dim myString As String = "Haramaki,1,99,0,0,Light#Silken Ceremonial Armor,1,99,0,0,Light#Lamellar Cuirass,2,4,0,5,Light#Leather Lamellar,4,3,2,20,Light#Do-Maru,5,4,4,25,Medium#Kikko Armor,5,4,3,20,Medium#Horn Lamellar,5,3,4,25,Medium#Four Mirror Armor,6,2,5,30,Medium#Steel Lamellar,6,3,5,25,Medium#Mountain Pattern Armor,6,3,4,30,Medium#Kusari Gusoku,7,1,7,35,Heavy#Iron Lamellar,7,0,7,40,Heavy#Tatami-Do,7,3,6,35,Heavy#OYoroi,8,2,6,35,Heavy#Stone Coat,8,0,7,40,Heavy"
        Dim myList As List(Of String) = myString.Split(CChar("#")).ToList

        For Each armor In myList
            Dim values = armor.Split(CChar(","))

            Dim rowValues = {values(0), "", values(1), values(2), values(3), values(4), "", "", "", "", values(5)}
            Dim rowcount As Integer = CType(DataGridView1.DataSource, DataSet).Tables(0).Rows.Count

            Try
                CType(DataGridView1.DataSource, DataSet).Tables(0).Rows.Add()


                CType(DataGridView1.DataSource, DataSet).Tables(0).Rows(rowcount).ItemArray = rowValues


                '      DataGridView1.Rows.Insert(0, {name, "", values(0), values(1), values(3), "", "", "", values(4)})
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next

    End Sub



    Private Sub VBProperCaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VBProperCaseToolStripMenuItem.Click
        VBProperCaseConvert()
    End Sub
    Private Sub VBProperCaseConvert()
        For x = 0 To DataGridView1.Rows.Count - 2

            If String.IsNullOrEmpty(DataGridView1.Rows(x).Cells(ComboBox1.Text).Value) = False Then
                Dim temp As String = DataGridView1.Rows(x).Cells(ComboBox1.Text).Value

                temp = StrConv(temp, vbProperCase)

                DataGridView1.Rows(x).Cells(ComboBox1.Text).Value = temp
            End If

        Next
        Dim clip As String = ""
    End Sub


    'Private Sub TextBox2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyUp
    '    If e.KeyValue = Keys.Enter Then
    '        Dim localSet = (From mob In mySet.Tables(0) Where mob("Name").ToString.Contains(TextBox2.Text) Select mob)

    '        DataGridView1.DataSource = localSet.CopyToDataTable
    '    End If
    'End Sub

    Private Sub ChangeColumnIndexToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeColumnIndexToolStripMenuItem.Click
        DataGridView1.Columns("Effect").DisplayIndex = 1

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim mySet = New DataSet(InputBox("New Dataset Name?"))
        DataGridView1.DataSource = mySet

    End Sub

Private Sub DataView_Load( sender As Object,  e As EventArgs) Handles MyBase.Load

End Sub

Private Sub Button2_Click( sender As Object,  e As EventArgs) Handles Button2.Click
     dim items = GetNames()
        dim duplicates as new List(of string)
        dim noDuplicates as new List(Of String)
        for each  item in items
            if noDuplicates.contains(item)
              duplicates.Add(item)
                Else 
                
                  noDuplicates.Add(item)
            End If
        Next
        duplicates.ForEach(Sub(paste)
                               TextBox3.Text += paste + vbnewline
                           End Sub)
End Sub
End Class