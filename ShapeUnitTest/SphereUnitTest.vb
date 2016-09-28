'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Imports Nunit Framework for tests
Imports NUnit.Framework
'Imports Shape Class
Imports Shape

'Uses Shape Namespace
Namespace Shape

    'Sphere Test Class
    <TestClass()>
    Public Class SphereUnitTest

        'Fields for Sphere test class

        'Assign 5 to radius field
        Private radius As Single = 5
        'Assign 5 to diameter field
        Private diameter As Single = 5

        'TestMethod for the Sphere surface area method
        <TestMethod()>
        Public Sub SphereSurfaceAreaTest()

            'Instantiate a new Sphere passing in local field values
            Dim surfaceArea As New Sphere(diameter, radius)

            'Assert that the surface area of test Sphere is equal to the expectedSurfaceArea
            Assert.AreEqual(Math.Round(surfaceArea.SurfaceArea(), 2), 314.16)

        End Sub

        'TestMethod for the Sphere volume method
        <TestMethod()>
        Public Sub SphereVolumeTest()

            'Instantiate a new Sphere passing in local field values
            Dim volume As New Sphere(diameter, radius)

            'Assert that the volume of test Sphere is equal to the expectedVolume
            Assert.AreEqual(Math.Round(volume.Volume(), 2), 523.6)

        End Sub

    End Class

End Namespace