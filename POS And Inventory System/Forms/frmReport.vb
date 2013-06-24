Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class frmReport
    Public Property strReport As String
    Public Property strVotingID As String
    Public Property ID As String
    Public Property TestID As String

    Private Sub frmReport_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rptDataSource As ReportDataSource

        Try
            With Me.ReportViewer1.LocalReport
                .ReportPath = "Reports\" & strReport & ".rdlc"
                .DataSources.Clear()
            End With

            Select Case strReport
                Case "SalesReport"
                    ' Set the parameters

                    Dim ds As New Sales_And_Inventory_System.SalesReportDataSet
                    Dim da As New Sales_And_Inventory_System.SalesReportDataSetTableAdapters.qry_SalesReportTableAdapter

                    da.Fill(ds.qry_SalesReport)

                    ' Use the same name as defined in the report Data Source Definition
                    rptDataSource = New ReportDataSource("SalesReportDataSet", ds.Tables("qry_SalesReport"))
            End Select

            Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)

            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class