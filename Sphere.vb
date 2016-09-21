Public MustInherit Class Sphere
    Inherits Shapes
    Implements Isphere, IRenderer

    Public Property Diameter As Single Implements Isphere.Diameter
    Public Property Radius As Single Implements Isphere.Radius

    Sub New()

    End Sub

    Public Function Render() As String Implements IRenderer.Render
        Return "Radius: " + Radius + " Diameter: " + Diameter + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function

    Public Overrides Function SurfaceArea() As Single
        Return 4 * System.Math.PI * Radius ^ 2
    End Function

    Public Overrides Function Volume() As Single
        Return 4 / 3 * System.Math.PI * Radius ^ 3
    End Function


End Class
