Imports System.Data.OleDb

Module modProcedure

    Public Sub FillListView(ByRef lvList As ListView, ByRef myData As OleDbDataReader)
        Dim itmListItem As ListViewItem

        Dim strValue As String

        Do While myData.Read
            itmListItem = New ListViewItem()
            strValue = IIf(myData.IsDBNull(0), "", myData.GetValue(0))
            itmListItem.Text = strValue

            For shtCntr = 1 To myData.FieldCount() - 1
                If myData.IsDBNull(shtCntr) Then
                    itmListItem.SubItems.Add("")
                Else
                    itmListItem.SubItems.Add(myData.GetValue(shtCntr))
                End If
            Next shtCntr

            lvList.Items.Add(itmListItem)
        Loop
    End Sub

    Public Sub FillComboBox(ByVal cboCombo As ComboBox, ByVal sSQL As String, ByVal strTable As String, ByVal strDisplayMember As String, ByVal strValueMember As String, Optional strHeader As String = "")
        Dim conn As New OleDbConnection

        Try
            With conn
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sSQL, conn)
            Dim dt As New DataSet

            da.Fill(dt, strTable)

            cboCombo.DataSource = dt.Tables(strTable).DefaultView
            cboCombo.DisplayMember = strDisplayMember
            cboCombo.ValueMember = strValueMember

            If strHeader <> "" Then
                Dim dr As DataRow = dt.Tables(strTable).NewRow()
                dr(0) = "-1"
                dr(1) = strHeader
                dt.Tables(strTable).Rows.InsertAt(dr, 0)
                cboCombo.DataBindings.Add("DataSource", dt, dt.Tables(strTable).TableName)
                cboCombo.DataBindings.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Debug.Print(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub CustomFillComboBox(ByVal cboCombo As ComboBox, ByVal sSQL As String, ByVal strTable As String, ByVal strDisplayMember As String, ByVal strValueMember As String, Optional strHeader As String = "")
        Dim conn As New OleDbConnection

        Try
            With conn
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sSQL, conn)
            Dim dt As New DataSet

            da.Fill(dt, strTable)

            cboCombo.DataSource = dt.Tables(strTable).DefaultView
            cboCombo.DisplayMember = strDisplayMember
            cboCombo.ValueMember = strValueMember
            'cboCombo.Text = "(select an item)"


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Debug.Print(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Procedure used to clear the text content
    Public Sub clearText(ByRef sForm As System.Windows.Forms.Form)
        For Each ctrControl As System.Windows.Forms.Control In sForm.Controls
            'Loop through all controls
            If Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.TextBox)) Then
                'Check to see if it's a textbox
                'If it is then set the text to String.Empty (empty textbox)
                DirectCast(ctrControl, System.Windows.Forms.TextBox).Text = String.Empty
            ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.RichTextBox)) Then
                'If its a RichTextBox clear the text
                DirectCast(ctrControl, System.Windows.Forms.RichTextBox).Text = String.Empty
            ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.ComboBox)) Then
                'Next check if it's a dropdown list
                'If it is then set its SelectedIndex to 0
                DirectCast(ctrControl, System.Windows.Forms.ComboBox).SelectedIndex = -1
            ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.CheckBox)) Then
                'Next uncheck all checkboxes
                DirectCast(ctrControl, System.Windows.Forms.CheckBox).Checked = False
            ElseIf Object.ReferenceEquals(ctrControl.[GetType](), GetType(System.Windows.Forms.RadioButton)) Then
                'Unselect all RadioButtons
                DirectCast(ctrControl, System.Windows.Forms.RadioButton).Checked = False
            End If
        Next
    End Sub

End Module
