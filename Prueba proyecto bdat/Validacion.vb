﻿Imports System.Text.RegularExpressions


Module Validation

    Function OnlyLetters(ByRef value As String) As Boolean
        Return Regex.IsMatch(value, "^[a-zA-Z]*$")
    End Function

End Module
