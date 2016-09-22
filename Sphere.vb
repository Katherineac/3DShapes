Public Class Sphere
    Inherits Shape
    Implements Isphere, IRenderer

#Region "Properties"

    Public Property Diameter As Single Implements Isphere.Diameter
    Public Property Radius As Single Implements Isphere.Radius

#End Region

#Region "Methods"

    'Constructor
    Public Sub New(Diameter As Single, Radius As Single)
        Me.Diameter = Diameter
        Me.Radius = Radius
    End Sub

    'Renders Sphere and outputs to MessageBox.Show()
    Public Sub Render() Implements IRenderer.Render
        MessageBox.Show("Radius: " + Radius.ToString() + " Diameter: " + Diameter.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Sphere")
    End Sub

    'Calculates Surface Area of a Sphere
    Public Overrides Function SurfaceArea() As Single
        Return 4 * System.Math.PI * Radius ^ 2
    End Function

    'Calcualtes Volume of a Sphere
    Public Overrides Function Volume() As Single
        Return 4 / 3 * System.Math.PI * Radius ^ 3
    End Function

#End Region

End Class
