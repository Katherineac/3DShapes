Public MustInherit Class Cuboid
    Inherits Shapes
    Implements ICuboid, IRenderer

    Public Property Height As Single Implements ICuboid.Height
    Public Property Length As Single Implements ICuboid.Length
    Public Property Width As Single Implements ICuboid.Width
    Public Function Render() As String
        Return "Height: " + Height + " Length: " + Length + "Width" + Width + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function
    Public Overrides Function SurfaceArea() As Single
        Return 2 * (Length * Width + Width * Height + Height * Length)
    End Function

    Public Overrides Function Volume() As Single
        Return Length * Width * Height
    End Function

    Sub New()

    End Sub
End Class
