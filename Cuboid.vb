'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape namespace
Namespace Shape

    'Cuboid Class - inherits from Shape, implements ICuboid interface and IRenderer Interface
    Public Class Cuboid
        Inherits Shape
        Implements ICuboid, IRenderer

#Region "Properties"

        'Cuboid properties

        'Field for Height of a Cuboid
        Public Property Height As Single Implements ICuboid.Height
        'Field for Length of a Cuboid
        Public Property Length As Single Implements ICuboid.Length
        'Field for Width of a Cuboid
        Public Property Width As Single Implements ICuboid.Width

#End Region

#Region "Methods"

        'Cuboid constructor - accepts Height, Length, and Width as parameters
        Public Sub New(Height As Single, Length As Single, Width As Single)

            'Assign parameter values to local fields

            'Assign Height parameter to Height field
            Me.Height = Height
            'Assign Length parameter to Length field
            Me.Length = Length
            'Assign Width parameter to Width field
            Me.Width = Width

        End Sub

        'Renders Cuboid and outputs to MessageBox.Show()
        Public Sub Render() Implements IRenderer.Render
            'Return MesssageBox.Show() method with the Cuboid properties and method calculations
            'Returns - Height, Length, Width, Surface Area, Volume
            MessageBox.Show("Height: " + Height.ToString() + " Length: " + Length.ToString() + " Width: " + Width.ToString() + Environment.NewLine + "Surface Area: " + SurfaceArea().ToString() + " Volume: " + Volume().ToString(), "Cuboid")
        End Sub

        'Calculates Surface Area of a Cuboid
        Public Overrides Function SurfaceArea() As Single
            'Return the surface area of a Cuboid rounded to 2 decimal places
            'A = 2 (lw + wh + hl) 
            Return 2 * (Length * Width + Width * Height + Height * Length)
        End Function

        'Caculates Volume of a Cuboid
        Public Overrides Function Volume() As Single
            'Return the volume of a Cuboid rounded to 2 decimal places
            'V=lwh
            Return Length * Width * Height
        End Function

#End Region

    End Class

End Namespace
