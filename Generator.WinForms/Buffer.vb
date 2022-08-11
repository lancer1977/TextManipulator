Public Class Buffer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strAdd As String
        Dim strRem As String
        RichTextBox1.Clear()
        strAdd = "Case """ + TextBox5.Text + """" + vbNewLine + "if straction = ""Add"" then" + vbNewLine + "if sender." + TextBox1.Text + " < " + TextBox2.Text + " then sender." + TextBox1.Text + "=" + TextBox2.Text + vbNewLine
        If TextBox3.Text <> "" Then strAdd += "if sender." + TextBox4.Text + "<" + TextBox3.Text + " then sender." + TextBox4.Text + "=" + TextBox3.Text + vbNewLine
        If TextBox6.Text <> "" Then strAdd += "if sender." + TextBox6.Text + "<" + TextBox7.Text + " then sender." + TextBox6.Text + "=" + TextBox7.Text + vbNewLine
        If TextBox8.Text <> "" Then strAdd += "if sender." + TextBox8.Text + "<" + TextBox9.Text + " then sender." + TextBox8.Text + "=" + TextBox9.Text + vbNewLine

        strRem = "else" + vbNewLine + "if sender." + TextBox1.Text + "=" + TextBox2.Text + " then sender." + TextBox1.Text + "= 0" + vbNewLine
        If TextBox4.Text <> "" Then strRem += "if sender." + TextBox4.Text + "=" + TextBox3.Text + " then sender." + TextBox4.Text + "= 0" + vbNewLine
        If TextBox6.Text <> "" Then strRem += "if sender." + TextBox6.Text + "=" + TextBox7.Text + " then sender." + TextBox6.Text + "= 0" + vbNewLine
        If TextBox8.Text <> "" Then strRem += "if sender." + TextBox8.Text + "=" + TextBox9.Text + " then sender." + TextBox9.Text + "= 0" + vbNewLine
        strRem += "end If"


        RichTextBox1.Text = strAdd + strRem

        Try
            Clipboard.Clear()

            Clipboard.SetText(RichTextBox1.Text)
        Catch
        End Try

    End Sub

    Private Sub Buffer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
