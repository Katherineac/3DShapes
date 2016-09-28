'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape namespace
Namespace Shape

    'Cone Class - inherits from Shape, implements ICone interface and IRenderer Interface
    Public Class Cone
        Inherits Shape
        Implements ICone, IRenderer

#Region "Properties"

        'Cylinder properties

        'Field for Height of a Cone
        Public Property Height As Single Implements ICone.Height
        'Field for Radius of a Cone
        Public Property Radius As Single Implements ICone.Radius

#End Region

#Region "Methods"

        'Cone Constructor - accepts height and radius as parameters
        Public Sub New(ByVal Height As Single, ByVal Radius As Single)

            'Assign parameter values to local fields

            'Assign Height parameter to Height field
            Me.Height = Height
            'Assign Radius parameter to Radius field
            Me.Radius = Radius

        End Sub

        'Renders Cone and outputs to MessageBox.Show()
        Public Sub Render() Implements IRenderer.Render
            'Return MesssageBox.Show() method with the Cone properties and method calculations
            'Returns - Height, Radius, Surface Area, Volume
            MessageBox.Show("Height: " + Height.ToString() + " Radius: " + Radius.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Cone")
        End Sub

        'Calculates Surface Area of a Cone
        Public Overrides Function SurfaceArea() As Single
            'Return the surface area of a Cone rounded to 2 decimal places
            'A=πr(r+h2+r2)
            Return Math.Round(System.Math.PI * Radius * (Radius + System.Math.Sqrt(System.Math.Pow(Height, 2) + System.Math.Pow(Radius, 2))), 2)
        End Function

        'Calcualtes Volume of a Cone
        Public Overrides Function Volume() As Single
            'Return the volume of a Cone rounded to 2 decimal places
            'V=πr2h/3
            Return Math.Round(System.Math.PI * System.Math.Pow(Radius, 2) * (Height / 3), 2)
        End Function

#End Region

    End Class

End Namespace

