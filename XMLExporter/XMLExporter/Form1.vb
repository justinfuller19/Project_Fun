Imports System
Imports System.Xml
Imports Microsoft

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Dim Stuff As String
        If Not InputTextBox.Text = "" Then
            Stuff = InputTextBox.Text
        End If
        XML_Writer(Stuff)
    End Sub
    Private Sub XML_Writer(ByRef Stuff As String)
        Dim thedate As String
        thedate = DateString
        If My.Computer.FileSystem.DirectoryExists("Desktop\") = False Then
            My.Computer.FileSystem.CreateDirectory("Desktop\")
        End If
        Dim writer As XmlWriter = XmlWriter.Create("Desktop\" & thedate & ".xml")

        With writer
            If Stuff <> "" Then
                .WriteStartElement("Customer")
                .WriteString(Stuff)
                .WriteEndElement()
                .Close()
            End If
        End With


    End Sub
End Class
