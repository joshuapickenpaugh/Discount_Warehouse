Module CalculateTotalModule

    Public Function GetTotal(ByVal num1 As Decimal, ByVal num2 As Decimal)

        Dim decTotal As Decimal

        num2 = num2 / 100
        decTotal = num1 - (num1 * num2)

        Return decTotal

    End Function

End Module
