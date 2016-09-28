Namespace Shape

    Public Class Sphere
        Inherits Shape
        Implements ISphere, IRenderer

#Region "Properties"

        Public Property Diameter As Single Implements ISphere.Diameter
        Public Property Radius As Single Implements ISphere.Radius

#End Region

#Region "Methods"

        'Constructor
        Public Sub New(Diameter As Single, Radius As Single)
            Me.Diameter = Diameter
            Me.Radius = Radius
        End Sub

        'Calculates Surface Area of a Sphere
        Public Overrides Function SurfaceArea() As Single
            Return 4 * System.Math.PI * Radius ^ 2
        End Function

        'Calcualtes Volume of a Sphere
        Public Overrides Function Volume() As Single
            Return 4 / 3 * System.Math.PI * Radius ^ 3
        End Function

        Public Function Render() As String Implements IRenderer.Render
            Return "Radius: " + Radius.ToString() + " Diameter: " + Diameter.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString()
        End Function

        Protected Overrides Sub Show(renderString As String, name As String)
            MessageBox.Show(Render(), "Sphere")
        End Sub

#End Region

    End Class

End Namespace
