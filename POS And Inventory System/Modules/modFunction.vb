Imports System.Data.OleDb

Module modFunction

    Public Function GetFieldValue(ByVal srcSQL As String, ByVal strField As String)
        Dim conn As New OleDb.OleDbConnection(My.Settings.DataConnectionString)

        Try
            conn.Open()

            Dim cmd As OleDbCommand = New OleDbCommand(srcSQL, conn)
            'create data reader
            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            'loop through result set
            rdr.Read()

            If rdr.HasRows Then GetFieldValue = rdr(strField).ToString()

            'close data reader
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetData(ByVal sSQL As String)
        Dim conn As New OleDb.OleDbConnection(My.Settings.DataConnectionString)

        conn.Open()

        Dim sqlCmd As OleDbCommand = New OleDbCommand(sSQL, conn)
        Dim myData As OleDbDataReader

        myData = sqlCmd.ExecuteReader

        Return myData
    End Function

    Public Function GetDataTable(ByVal conn As OleDbConnection, ByVal strSQL As String)
        Try
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(strSQL, conn)
            Dim ds As DataSet = New DataSet

            da.Fill(ds, "ProductDetail")

            Dim dt As DataTable = ds.Tables("ProductDetail")

            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Function used to change the yes/no value
    Public Function changeYNValue(ByVal srcStr As String) As String
        changeYNValue = ""

        Select Case srcStr
            Case "Y" : changeYNValue = "1"
            Case "N" : changeYNValue = "0"
            Case "1" : changeYNValue = "Y"
            Case "0" : changeYNValue = "N"
        End Select
    End Function

    'Execute Non Query
    Public Function ExecNonQuery(ByVal strSQL As String)
        Dim conn As OleDbConnection
        conn = New OleDbConnection

        Try
            With conn
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = cnString
                .Open()
            End With

            Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As OleDbException
            MsgBox(ex.ToString)

            Return False
        Finally
            conn.Close()
        End Try
    End Function

    'Execute Non Query
    Public Function ExecNonQueryTrans(ByVal conn As OleDbConnection, ByVal strSQL As String)
        Try
            Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)

            cmd.ExecuteNonQuery()

            Return True
        Catch ex As OleDbException
            MsgBox(ex.Message)

            Return True
        End Try
    End Function

    Public Function GetIndex(ByVal srcTable As String) As Long
        Dim intNextNo As Integer
        Dim conn As OleDbConnection = New OleDbConnection
        'create connection

        With conn
            If .State = ConnectionState.Open Then .Close()

            .ConnectionString = cnString
            .Open()
        End With

        Dim sqlQRY As String = "SELECT * FROM KeyGen WHERE TableName = '" & srcTable & "'"

        'create commands
        Dim cmd As OleDbCommand = New OleDbCommand(sqlQRY, conn)

        Try
            'create data reader
            Dim rdr As OleDbDataReader = cmd.ExecuteReader

            'loop through result set
            rdr.Read()
            intNextNo = rdr("NextNo").ToString()

            intNextNo = intNextNo + 1
            'define update statement
            Dim sqlUpdate As String = "UPDATE KeyGen SET KeyGen.NextNo = " & intNextNo & " WHERE TableName='" & srcTable & "'"

            Dim cmdUpdate As OleDbCommand = New OleDbCommand(sqlUpdate, conn)

            'execute nonquery to update an index
            cmdUpdate.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex)
        Finally
            ' Close connection
            conn.Close()
            Console.WriteLine("Connection closed.")
        End Try

        GetIndex = intNextNo
    End Function

    'Function that will format return a generated id
    Public Function GenerateID(ByVal srcNo As String, ByVal src1stStr As String, ByVal src2ndStr As String) As String
        If Len(src2ndStr) <= Len(srcNo) Then
            GenerateID = src1stStr & srcNo
        Else
            GenerateID = src1stStr & Left(src2ndStr, Len(src2ndStr) - Len(srcNo)) & srcNo
        End If
    End Function

    Public Function CountRows(ByVal sSQL As String)
        Dim conn As New OleDb.OleDbConnection(My.Settings.DataConnectionString)

        With conn
            If .State = ConnectionState.Open Then .Close()

            .ConnectionString = cnString
            .Open()
        End With

        Dim cmdCount As OleDbCommand = New OleDbCommand(sSQL, conn)

        CountRows = cmdCount.ExecuteScalar()
    End Function

    'Function that will return a currency format
    Public Function toMoney(ByVal srcCurr As String) As String
        toMoney = Format(IIf(Trim(srcCurr) = "", 0, CSng(srcCurr)), "#,##0.00")
    End Function

    Public Function toNumber(ByVal srcCurrency As String, Optional ByRef RetZeroIfNegative As Boolean = False) As Double
        Dim retValue As Double
        If srcCurrency = "" Then
            toNumber = 0
        Else
            If InStr(1, srcCurrency, ",") > 0 Then
                retValue = Val(Replace(srcCurrency, ",", "", , , CompareMethod.Text))
            Else
                retValue = Val(srcCurrency)
            End If
            If RetZeroIfNegative = True Then
                If retValue < 1 Then retValue = 0
            End If
            toNumber = retValue
            retValue = 0
        End If
    End Function

    Public Function IsValidTextbox(ByVal TxtBox As TextBox) As Boolean
        If IsNumeric(TxtBox.Text) Then
            TxtBox.Text = Format(CDbl(TxtBox.Text), "0.00")
            IsValidTextbox = True
        Else
            MsgBox("Please enter correct information", MsgBoxStyle.OkOnly)
            TxtBox.Focus()
            TxtBox.SelectAll()
            IsValidTextbox = False
        End If
    End Function
End Module
