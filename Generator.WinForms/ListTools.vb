
Imports System.Threading.Tasks
Imports System.Linq


Public Class ListTools

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strtemp As String = TextBox1.Text.Replace(vbNewLine, "#")

        Clipboard.SetText(strtemp)

    End Sub

    Private Sub condenseEnums()
        Dim myString As String = TextBox1.Text
        MsgBox(myString)
        Dim myList As List(Of String) = myString.Split(",").ToList
        Dim outlist As New List(Of String)
        For Each item In myList
            If outlist.Contains(item) = False Then
                outlist.Add(item)
                outputTextbox.Text &= item & "," & vbNewLine
            End If
            'For Each item In From item1 In (From item1 In  Where item1 <> "" Select item1) Where myList.Contains(item1) = False
            '    

        Next


    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim strtemp As String = TextBox1.Text.Replace(Chr(10), "#")
        Dim aryTemp() As String = strtemp.split(CChar("#"))

        For x As Integer = 0 To aryTemp.Length - 1 Step 1
            Dim ary() = aryTemp(x).Split("""")
            'Dim strtemp2 As String = aryTemp(x).Replace("Case """, "")
            'Dim str1st As Integer = InStr(strtemp2, """")
            strtemp += ary(1) & ","

        Next
        Clipboard.SetText(strtemp)
    End Sub
    Public Sub UpdateLabel(ByVal value As String)
        Label1.Text = value
        Application.DoEvents()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       Dim items = textbox1.Text.Split(vbnewline)
        dim x as Integer = 0
        for each item in items
            
            _outputTextbox.Text &= item & " = row[" & x & "]" & vbNewLine
            x= x + 1

        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        outputTextbox.Text = TextBox1.Text.Replace(Chr(10), toTextbox.Text)
        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        outputTextbox.Text = TextBox1.Text.Replace(vbNewLine, toTextbox.Text)

        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub removeTabs()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        outputTextbox.Text = TextBox1.Text.Replace(vbTab, toTextbox.Text)
        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text.Replace(Chr(10), "#")
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = outputTextbox.Text.Replace(Chr(13), toTextbox.Text)
        If TextBox1.Text IsNot "" Then Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text.Replace(Chr(13), "#")
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text.Replace("-", "")
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox1.Text = TextBox1.Text.Replace("##", vbNewLine)
        TextBox1.Text = TextBox1.Text.Replace("Qualities.# #", vbNewLine & "Case """)
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text.Replace("#", ")"" : Return """)

    End Sub


    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text.Replace("[Location]", (vbNewLine & "[Location]"))
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        outputTextbox.Text = TextBox1.Text.Replace(vbTab, toTextbox.Text)

        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim temp As String
        temp = TextBox1.Text.Replace("1st—", "#").Replace(", 2nd—", "#").Replace(", 3rd—", "#").Replace(", 4th—", "#").Replace(", 5th—", "#").Replace(", 6th—", "#").Replace(", 7th—", "#").Replace(", 8th—", "#").Replace(", 9th—", "#")
        TextBox1.Text = StrConv(temp, vbProperCase)
        Try
            Clipboard.SetText(TextBox1.Text)
        Catch
        End Try

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim listItem As String()
        listItem = TextBox1.Text.Split(vbNewLine)
        Dim out As String = ""
        For Each item In listItem
            item = item.Replace(" ", "")
            out &= vbNewLine & "case """ & item & """" & vbNewLine
            out &= "Select Case Skill" & vbNewLine
            out &= "case "" :" & vbNewLine
            out &= "End Select"
        Next
        TextBox1.Text = out

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim list As New List(Of String)
        list.AddRange(TextBox1.Text.Split(vbNewLine))
        TextBox1.Clear()

        list.Sort()
        For Each item In list
            TextBox1.Text &= item & vbNewLine

        Next


    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TextBox1.Text = TextBox1.Text.Replace(box1.Text, box2.Text)
    End Sub


    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        outputTextbox.Clear()

        Dim myList As New List(Of String)
        Dim tasklist As New List(Of System.Threading.Tasks.Task)

        Dim ary() As String = TextBox1.Text.Split(vbNewLine)
        For Each item In ary
            Dim localItem As String = item
            Dim task As New Task(Sub()
                                     Dim itemSubSplit As String() = localItem.Split(":")
                                     Dim subtype As String = itemSubSplit(0).Replace("Case ", "").Replace(" ", "").Replace("""", "").Replace(Chr(10), "")



                                     For Each subItem In itemSubSplit(1).split(CChar("#"))
                                         myList.Add(subItem & "@" & subtype & vbNewLine)
                                     Next
                                 End Sub)
            tasklist.Add(task)

            task.Start()


        Next

        System.Threading.Tasks.Task.WaitAll(tasklist.ToArray)

        For Each item In myList
            outputTextbox.Text &= item

        Next

        Clipboard.SetText(outputTextbox.Text)



    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        TextBox1.Text = ""
        outputTextbox.Text = ""
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        outputTextbox.Text = ""
        For Each itemType In TextBox1.Text.Split(vbNewLine)
            Try
                Dim data() As String = itemType.Split(":")
                Dim slot As String = data(0).Trim
                For Each item In data(1).split(CChar("#"))
                    item = StrConv(item, vbProperCase)
                    outputTextbox.Text &= String.Format("Case """ & item & """ : localstring = ""[Name]{0}@[Slot]{1}@[Effect]{2}""", {item, slot, item.Replace(" ", "").Replace("+", "")}) & vbNewLine


                Next
            Catch
            End Try
        Next
        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        StringFormatArray
    End Sub
      Public Sub StringFormatArray()
        Dim list As New List(Of String)
        For Each item In TextBox1.Text.Split(Environment.NewLine)
            if item= "" or item = " "
                Continue For
            End If
           

            Dim splitItem = item.Split(",")
   

            outputTextbox.Text &= _
                     String.Format(txtStringFormat.Text, splitItem) & vbNewLine

        Next
    End Sub
    Public Sub StringFormatSingle()
Dim list As New List(Of String)
        For Each item In TextBox1.Text.Split(Environment.NewLine)
            item = item.Replace(Chr(10), "")
            item = item.Replace(Chr(13), "")
            item = item.Trim

            outputTextbox.Text &= _
                     String.Format(txtStringFormat.Text, item) & vbNewLine

        Next
    End Sub
    Private Sub btngear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        My.Computer.Clipboard.SetText(outputTextbox.Text)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim file As New OpenFileDialog
        file.ShowDialog()
        If System.IO.File.Exists(file.FileName) Then
            Dim fileName As String = file.FileName
            TextBox1.Text = System.IO.File.ReadAllText(fileName)

        End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim list As New List(Of String)
        For Each item In ListBox1.Items
            list.Add(item)
        Next
        '  outputTextbox.Text = myExcel.parseInfo(InputBox("Tag name? IE the classification"), list.ToArray)

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim addItem As String = InputBox("Field name to ignore (case must match)?")
        If addItem <> "" Then ListBox1.Items.Add(addItem)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If ListBox1.SelectedIndex <> -1 Then
            Try
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        outputTextbox.Text = TextBox1.Text.Replace(toTextbox.Text, vbNewLine)

        Clipboard.SetText(outputTextbox.Text)
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub ConvertToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConvertToolStripMenuItem.Click

    End Sub

    Private Sub DataviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataviewToolStripMenuItem.Click
        DataView.Show()

    End Sub



    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Dim newList As New List(Of String)
        newList.AddRange(TextBox1.Text.Split(vbNewLine))
        For Each item In newList
            outputTextbox.Text &= String.Format(txtStringFormat.Text, item.Replace(Chr(10), "").Replace(Chr(13), "").Replace(" ", ""))


        Next
    End Sub

    Private Sub EnumCreationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnumCreationToolStripMenuItem.Click
        condenseEnums()
    End Sub

Private Sub Button12_Click_1( sender As Object,  e As EventArgs) Handles Button12.Click
        'Speak(_outputTextbox.Text)

    End Sub



    Private Sub Button13_Click_1( sender As Object,  e As EventArgs) Handles Button13.Click
        Dim text As String = TextBox1.Text
        text = text.Replace(Environment.NewLine,  ";" & Environment.NewLine )

        for x As Integer = 1 To 100
            text = text.Replace("Case " & x & " To ","if(roll <= ")
        Next
        outputTextbox.Text = text

End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Clear()
    End Sub
End Class