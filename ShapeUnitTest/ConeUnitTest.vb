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

    'Cone Test Class
    <TestClass()>
    Public Class ConeUnitTest

        'Fields for cone test class
        Private height As Single = 5
        Private radius As Single = 5
        Private expectedSurfaceArea As Single = 189.61
        Private expectedVolume As Single = 130.9

        'TODO Need to add TestMethod for RenderMethod

        'TestMethod for the Cone surface area method
        <TestMethod()> Public Sub ConeSurfaceAreaTest()

            'Instantiate a new Cone passing in local field values
            Dim testCone As New Cone(height, radius)

            'Assert that the surface area of test Cone is equal to the expectedSurfaceArea
            Assert.AreEqual(testCone.SurfaceArea(), expectedSurfaceArea)

        End Sub

        'TestMethod for the Cone volume method
        <TestMethod()> Public Sub ConeVolumeTest()

            'Instantiate a new Cone passing in local field values
            Dim testCone As New Cone(height, radius)

            'Assert that the volume of test Cone is equal to the expectedVolume
            Assert.AreEqual(testCone.Volume(), expectedVolume)

        End Sub

    End Class

End Namespace