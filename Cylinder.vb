Public MustInherit Class Cylinder
    Inherits Shapes
    Implements ICylinder, IRenderer

    Public Property Diameter As Single Implements ICylinder.Diameter
    Public Property Height As Single Implements ICylinder.Height
    Public Property Radius As Single Implements ICylinder.Radius

    Sub New()

    End Sub

    Public Function Render() As String
        Return "Diameter: " + Diameter + " Height: " + Height + " Radius: " + Radius + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function

    Public Overrides Function SurfaceArea() As Single
        Return (2 * System.Math.PI * Radius * Height) + (2 * System.Math.PI * System.Math.Pow(Radius, 2))
    End Function


    Public Overrides Function Volume() As Single
        Return System.Math.PI * System.Math.Pow(Radius, 2) * Height
    End Function

End Class
