Public Class Cone
    Inherits Shape

    Property Height As Single
    Property Radius As Single


    Sub New()


    End Sub

    Public Function Render() As String
        Return "Nothing"
    End Function

    Public Function SurfaceArea() As Single
        Return System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2)))
    End Function


    Public Function Volume()
        Return System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3)
    End Function

End Class
