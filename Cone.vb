

Namespace Shape

    Public Class Cone
        Inherits Shape
        Implements ICone, IRenderer

#Region "Properties"

        Public Property Height As Single Implements ICone.Height
        Public Property Radius As Single Implements ICone.Radius

#End Region

#Region "Methods"

        'Constructor
        Public Sub New(ByVal Height As Single, ByVal Radius As Single)
            Me.Height = Height
            Me.Radius = Radius
        End Sub

        'Calculates Surface Area of a Cone
        Public Overrides Function SurfaceArea() As Single
            Return Math.Round(System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2))), 2)
        End Function

        'Calcualtes Volume of a Cone
        Public Overrides Function Volume() As Single
            Return Math.Round(System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3), 2)
        End Function

        Protected Overrides Sub Show(renderString As String, name As String)
            MessageBox.Show(Render(), "Cone")
        End Sub

        Public Function Render() As String Implements IRenderer.Render
            Return "Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
        End Function

#End Region

    End Class

End Namespace

