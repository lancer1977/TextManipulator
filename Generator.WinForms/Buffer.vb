Imports Generator.Core

Public Class Buffer

    Dim ViewModel As BufferViewModel

    Sub New(viewModel As BufferViewModel)
        Me.ViewModel = viewModel
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
        Dim items = New List(Of (String, String))()
        items.Add((TextBox3.Text, TextBox4.Text))
        items.Add((TextBox6.Text, TextBox7.Text))
        items.Add((TextBox8.Text, TextBox8.Text))


        RichTextBox1.Text = ViewModel.Generate(TextBox5.Text, items.ToArray())
        Clipboard.Clear()

        Clipboard.SetText(RichTextBox1.Text)
    End Sub


    Private Sub Buffer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
