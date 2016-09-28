'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape namespace
Namespace Shape

    'Cylinder Class - inherits from Shape, implements ICylinder interface and IRenderer Interface
    Public Class Cylinder
        Inherits Shape
        Implements ICylinder, IRenderer

#Region "Properties"

        'Cylinder properties

        'Field for Diameter of a Cylinder
        Public Property Diameter As Single Implements ICylinder.Diameter
        'Field for Height of a Cylinder
        Public Property Height As Single Implements ICylinder.Height
        'Field for Radius of a Cylinder
        Public Property Radius As Single Implements ICylinder.Radius

#End Region

#Region "Methods"

        'Cylinder constructor - accepts Diameter, Height, and Radius parameters
        Sub New(ByVal Diameter As Single, ByVal Height As Single, ByVal Radius As Single)

            'Assign parameter values to local fields

            'Assign Diameter parameter to Diameter field
            Me.Diameter = Diameter
            'Assign Height parameter to Height field
            Me.Height = Height
            'Assign Radius parameter to Radius field
            Me.Radius = Radius

        End Sub

        'Renders Cylinder and outputs to MessageBox.Show()
        Public Sub Render() Implements IRenderer.Render
            'Return MesssageBox.Show() method with the Cylinder properties and method calculations
            'Returns - Diameter, Height, Radius, Surface Area, Volume
            Me.MessageBox.Show("Diameter: " + Diameter.ToString() + " Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Cylinder")
        End Sub

        'Method to calculate the surface area of a Cylinder
        Public Overrides Function SurfaceArea() As Single
            'Return the surface area of a Cylinder rounded to 2 decimal places
            'A=2πrh+2πr2
            Return Math.Round((2 * System.Math.PI * Radius * Height) + (2 * System.Math.PI * System.Math.Pow(Radius, 2)), 2)
        End Function

        'Method to calculate the volume of a Cylinder
        Public Overrides Function Volume() As Single
            'Return the volume of a Cylinder rounded to 2 decimal places
            'V=πr2h
            Return Math.Round(System.Math.PI * System.Math.Pow(Radius, 2) * Height, 2)
        End Function

#End Region

    End Class

End Namespace