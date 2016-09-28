'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape namespace
Namespace Shape

    'Sphere Class - inherits from Shape, implements ISphere interface and IRenderer Interface
    Public Class Sphere
        Inherits Shape
        Implements ISphere, IRenderer

#Region "Properties"

        'Sphere properties

        'Field for Diameter of a Sphere
        Public Property Diameter As Single Implements ISphere.Diameter
        'Field for Radius of a Sphere
        Public Property Radius As Single Implements ISphere.Radius

#End Region

#Region "Methods"

        'Sphere constructor - accepts diameter and radius parameters
        Public Sub New(Diameter As Single, Radius As Single)

            'Assign parameter values to local fields

            'Assign Diameter parameter to Diameter field
            Me.Diameter = Diameter
            'Assign Radius parameter to Radius field
            Me.Radius = Radius

        End Sub

        'Renders Sphere and outputs to MessageBox.Show()
        Public Sub Render() Implements IRenderer.Render
            'Return MesssageBox.Show() method with the Sphere properties and method calculations
            'Returns - Radius, Diameter, Surface Area, Volume
            MessageBox.Show("Radius: " + Radius.ToString() + " Diameter: " + Diameter.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Sphere")
        End Sub

        'Calculates Surface Area of a Sphere
        Public Overrides Function SurfaceArea() As Single
            'Return the surface area of a Sphere rounded to 2 decimal places
            'A=4πr2
            Return 4 * System.Math.PI * Radius ^ 2
        End Function

        'Calcualtes Volume of a Sphere
        Public Overrides Function Volume() As Single
            'Return the volume of a Sphere rounded to 2 decimal places
            'V=4/3πr3
            Return 4 / 3 * System.Math.PI * Radius ^ 3
        End Function

#End Region

    End Class

End Namespace
