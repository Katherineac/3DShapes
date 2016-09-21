Public Class Cylinder
    Inherits Shape
    Implements ICone, IRenderer

    Public Property Diameter As Single Implements ICone.Height
    Public Property Height As Single Implements ICone.Height
    Public Property Radius As Single Implements ICone.Radius

    Sub New()

    End Sub

    Public Function Render() As String
        Return "Diameter: " + Diameter + " Height: " + Height + " Radius: " + Radius + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function

    Public Function SurfaceArea() As Single
        Return (2 * System.Math.PI * Radius * Height) + (2 * System.Math.PI * System.Math.Pow(Radius, 2))
    End Function


    Public Function Volume() As Single
        Return System.Math.PI * System.Math.Pow(Radius, 2) * Height
    End Function

End Class
