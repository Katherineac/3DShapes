
Option Explicit On

Namespace Shape

    Public Class Cylinder
        Inherits Shape
        Implements ICylinder, IRenderer

#Region "Properties"

        Public Property Diameter As Single Implements ICylinder.Diameter
        Public Property Height As Single Implements ICylinder.Height
        Public Property Radius As Single Implements ICylinder.Radius

#End Region

#Region "Methods"

        'Constructor
        Sub New(ByVal Diameter As Single, ByVal Height As Single, ByVal Radius As Single)

            Me.Diameter = Diameter
            Me.Height = Height
            Me.Radius = Radius

        End Sub

        Public Overrides Function SurfaceArea() As Single
            Return Math.Round((2 * System.Math.PI * Radius * Height) + (2 * System.Math.PI * System.Math.Pow(Radius, 2)), 2)
        End Function

        Public Overrides Function Volume() As Single
            Return Math.Round(System.Math.PI * System.Math.Pow(Radius, 2) * Height, 2)
        End Function

        Protected Overrides Sub Show(renderString As String, name As String)
            MessageBox.Show(Render(), "Cylinder")
        End Sub

        Public Function Render() As String Implements IRenderer.Render
            Return "Diameter: " + Diameter.ToString() + " Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
        End Function

#End Region

    End Class

End Namespace