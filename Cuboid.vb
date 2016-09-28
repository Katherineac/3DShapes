
Namespace Shape

    Public Class Cuboid
        Inherits Shape
        Implements ICuboid, IRenderer

#Region "Properties"

        Public Property Height As Single Implements ICuboid.Height
        Public Property Length As Single Implements ICuboid.Length
        Public Property Width As Single Implements ICuboid.Width

#End Region

#Region "Methods"

        'Constructor
        Public Sub New(Height As Single, Length As Single, Width As Single)
            Me.Height = Height
            Me.Length = Length
            Me.Width = Width
        End Sub

        'Renders Cuboid and outputs to MessageBox.Show()
        ' Public Overrides Function Render() As String Implements IRenderer.Render
        'Return "Height: " + Height.ToString() + " Length: " + Length.ToString() + " Width: " + Width.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
        '   End Function

        'Calculates Surface Area of a Cuboid
        Public Overrides Function SurfaceArea() As Single
            Return 2 * (Length * Width + Width * Height + Height * Length)
        End Function

        'Caculates Volume of a Cuboid
        Public Overrides Function Volume() As Single
            Return Length * Width * Height
        End Function

        Protected Overrides Sub Show(renderString As String, name As String)
            MessageBox.Show(Render(), "Cuboid")
        End Sub

        Private Function Render() As String Implements IRenderer.Render
            Return "Height: " + Height.ToString() + " Length: " + Length.ToString() + " Width: " + Width.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
        End Function

#End Region

    End Class

End Namespace
