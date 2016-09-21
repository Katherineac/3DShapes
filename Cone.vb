Public MustInherit Class Cone
    Inherits Shapes
    Implements ICone, IRenderer

    Public Property Height As Single Implements ICone.Height
    Public Property Radius As Single Implements ICone.Radius
    ' Nothing needed in constructor as Height and Raidus are getters and setters
    Sub New()


    End Sub

    Public Function Render() As String
        Return "Height: " + Height + " Radius: " + Radius + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function

    Public Overrides Function SurfaceArea() As Single
        Return System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2)))
    End Function


    Public Overrides Function Volume() As Single
        Return System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3)
    End Function

End Class
