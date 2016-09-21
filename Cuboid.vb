Public Class Cuboid
    Inherits Shapes
    Implements ICuboid, IRenderer

    Public Property Height As Single Implements ICuboid.Height
    Public Property Length As Single Implements ICuboid.Length
    Public Property Width As Single Implements ICuboid.Width
    Public Function Render() As String
        Return "Height: " + Height + " Length: " + Length + "Width" + Width + "\nSurface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function
    Public Function SurfaceArea() As Single
        Return 2 * (Length * Width + Width * Height + Height * Length)
    End Function

    Public Function Volume() As Single
        Return Length * Width * Height
    End Function

    Public Sub New(heightValue As Double, lengthValue As Double, widthValue As Double, surfaceAreaValue As Double, volumeValue As Double)
        Me.heightValue = heightValue
        Me.lengthValue = lengthValue
        Me.widthValue = widthValue
        Me.surfaceAreaValue = surfaceAreaValue
        Me.volumeValue = volumeValue
    End Sub
End Class
