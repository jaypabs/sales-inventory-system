Option Strict Off
Option Explicit On

Module modGlobal
    'Variable structure for user
    Public Structure USER_INFO
        Dim USERNAME As String
        Dim USER_ISADMIN As Boolean
    End Structure

    'Enumerator for form state
    Public Enum FormState
        adStateAddMode = 0
        adStateEditMode = 1
        adStatePopupMode = 2
        adStateViewMode = 3
    End Enum

    Public Structure BUSINESS_INFO
        Dim BUSINESS_NAME As String
        Dim BUSINESS_ADDRESS As String
        Dim BUSINESS_CONTACT_INFO As String
    End Structure
End Module
