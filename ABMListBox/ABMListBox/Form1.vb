Public Class Form1

    
    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        'foco en el texbox
        TextBox1.Focus()

        If TextBox1.Text.Trim = "" Then
            Exit Sub
        End If

        'estrada de datos
        ListBox1.Items.Add(TextBox1.Text.Trim)

        'limpa luego del alta
        TextBox1.Clear()

    End Sub

    Private Sub Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click
        'foco en el texbox
        TextBox1.Focus()
        If ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If
        'bajada de datos
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        TextBox1.Clear()
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        '
        TextBox1.Text = ListBox1.Items.Item(ListBox1.SelectedIndex)
        TextBox1.Focus()

    End Sub


    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click
        TextBox1.Focus()

        If ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If

        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text
        TextBox1.Clear()

    End Sub
End Class
