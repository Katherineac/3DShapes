Option Explicit On

Imports NUnit.Framework
Imports Shape

Namespace Shape

    'Test Class
    <TestClass()>
    Public Class CylinderUnitTest

        'Fields for cylinder test class
        Private diameter As Single = 10
        Private height As Single = 5
        Private radius As Single = 5
        Private expectedSurfaceArea As Single = 314.16
        Private expectedVolume As Single = 392.7

        'TODO Need to add TestMethod for RenderMethod

        'TestMethod for the cylinder surface area method
        <TestMethod()> Public Sub CylinderSurfaceAreaTest()

            Dim testCylinder As New Cylinder(diameter, height, radius)

            Assert.AreEqual(testCylinder.SurfaceArea(), expectedSurfaceArea)

        End Sub

        'TestMethod for the cylinder volume method
        <TestMethod()> Public Sub Volume()

            Dim testCylinder As New Cylinder(diameter, height, radius)

            Assert.AreEqual(testCylinder.Volume(), expectedVolume)

        End Sub

    End Class

End Namespace

