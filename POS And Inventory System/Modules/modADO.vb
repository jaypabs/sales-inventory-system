Imports System
Imports System.IO
Imports System.Xml

Module modAdo
    Public Database As String
    Public cnString As String

    Public Sub ReadfromXML()
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("data.xml")

        Dim root As XmlElement = doc.DocumentElement

        Database = root.Attributes.Item(0).Value

        cnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Database & ";Jet OLEDB:Database Password=12345678;OLE DB Services=-4"
    End Sub

    Public Sub SavetoXML(ByVal Database)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("data.xml")

        Dim root As XmlElement = doc.DocumentElement

        ' Change the value of the first attribute.
        root.Attributes.Item(0).Value = Database

        ' Save the document to a file and auto-indent the output.
        Dim writer As XmlTextWriter = New XmlTextWriter("data.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
End Module
