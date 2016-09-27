Option Explicit On

Imports System
Imports NUnit.Framework
Imports Shape
Imports System.Diagnostics

Namespace ShapeUnitTest

    <TestFixture>
    Public Class SphereUnitTest

        Private radius As Single = 5
        Private diameter As Single = 5

        <Test>
        Public Sub SurfaceArea()
            Dim surfaceArea As New Sphere(diameter, radius)
            Assert.AreEqual(Math.Round(surfaceArea.SurfaceArea(), 2), 314.16)
        End Sub

        <Test>
        Public Sub Volume()
            Dim volume As New Sphere(diameter, radius)
            Assert.AreEqual(Math.Round(volume.Volume(), 2), 523.6)
        End Sub

    End Class

End Namespace