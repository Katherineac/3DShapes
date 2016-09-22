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

    'Renders Cone and outputs to MessageBox.Show()
    Public Sub Render() Implements IRenderer.Render
        Me.MessageBox.Show("Diameter: " + Diameter.ToString() + " Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Cylinder")
    End Sub

    Public Overrides Function SurfaceArea() As Single
        Return (2 * System.Math.PI * Radius * Height) + (2 * System.Math.PI * System.Math.Pow(Radius, 2))
    End Function

    Public Overrides Function Volume() As Single
        Return System.Math.PI * System.Math.Pow(Radius, 2) * Height
    End Function

#End Region

End Class
