Public Class Cone
    Inherits Shape
    Implements ICone, IRenderer

    Public Property Height As Single Implements ICone.Height
    Public Property Radius As Single Implements ICone.Radius
    ' Nothing needed in constructor as Height and Raidus are getters and setters
    Sub New(ByVal Height As Single, ByVal Radius As Single)
        Me.Height = Height
        Me.Radius = Radius
    End Sub

    Public Function Render() As String Implements IRenderer.Render
        Return "Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
    End Function

    Public Overrides Function SurfaceArea() As Single
        Return System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2)))
    End Function


    Public Overrides Function Volume() As Single
        Return System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3)
    End Function

    Public Overrides Sub Show()
        MsgBox(Render())
    End Sub

    Public Overrides Sub Shape()
        Throw New NotImplementedException()
    End Sub
End Class
