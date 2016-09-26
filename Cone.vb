

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

        'Renders Cone and outputs to MessageBox.Show()
        Public Sub Render() Implements IRenderer.Render
            MessageBox.Show("Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Cone")
        End Sub

        'Calculates Surface Area of a Cone
        Public Overrides Function SurfaceArea() As Single
            Return System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2)))
        End Function

        'Calcualtes Volume of a Cone
        Public Overrides Function Volume() As Single
            Return System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3)
        End Function

#End Region

    End Class

End Namespace

