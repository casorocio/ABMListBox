Imports System.Xml
Imports System.IO

Public Class Form1
    Dim Enumerado As Boolean = False
    Dim Alfa As Boolean = False
    Dim may As Boolean = False



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
        'limpiar lo seleccionado
        ListBox1.ClearSelected()


    End Sub

    Private Sub Enumerar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Enumerar.Click
        Dim x As Integer
        If Enumerado Or Alfa Then
            Exit Sub
        End If
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = CStr(x) + "-" + ListBox1.Items.Item(x).ToString
        Next
        TextBox1.Focus()
        Enumerado = True
    End Sub

    Private Sub Alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alfabetizar.Click
        Dim x As Integer

        If Alfa Or Enumerado Then
            Exit Sub
        End If
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = Chr(x + 65) + "-" + ListBox1.Items.Item(x).ToString
        Next
        TextBox1.Focus()
        Alfa = True
    End Sub

    Private Sub Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quitar.Click
        Dim x, g As Integer

        For x = 0 To ListBox1.Items.Count - 1
            'g obtiene el valor de la columna donde se encuenntra el primer guion 
            g = ListBox1.Items.Item(x).ToString.IndexOf("-")
            'devuelve una cadena a partir de g+1
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).SubsTring(g + 1).ToString.ToLower
        Next

        TextBox1.Focus()
        Enumerado = False
        Alfa = False
        may = False

    End Sub

    Private Sub Mayuscula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mayuscula.Click

        Dim x As Integer
        If may Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).ToString.ToUpper

        Next
        may = True
        TextBox1.Focus()


    End Sub

    Private Sub Grabarxml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabarxml.Click
        Dim ruta As String
        ruta = CurDir.Substring(0, CurDir.Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "lista.xml", System.Text.Encoding.UTF8)

        escritor.WriteStartDocument(True)
        escritor.Formatting = Formatting.Indented
        escritor.Indentation = 4
        escritor.WriteStartElement("Lista")

        Dim x As Integer
        For x = 0 To ListBox1.Items.Count - 1
            escritor.WriteStartElement("Elemento")
            escritor.WriteString(ListBox1.Items.Item(x).ToString)
            escritor.WriteEndElement()
        Next
        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()
        MsgBox("Guardado")
        TextBox1.Focus()


    End Sub

    Private Sub Leerxml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leerxml.Click
        Dim xmld As New XmlDocument
        Dim ListaNodo As XmlNodeList
        Dim Nodo As XmlNode
        Dim ruta As String

        ruta = CurDir().Substring(0, CurDir().Length - 9)

        If Not File.Exists(ruta + "Lista.xml") Then Exit Sub
        xmld.Load(ruta + "Lista.xml")
        ListaNodo = xmld.SelectNodes("Lista/Elemento")

        For Each Nodo In ListaNodo
            ListBox1.Items.Add(Nodo.InnerText)

        Next
        TextBox1.Focus()

    End Sub
End Class
