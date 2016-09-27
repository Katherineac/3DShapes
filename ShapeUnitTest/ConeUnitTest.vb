Option Explicit On

Imports NUnit.Framework
Imports Shape

Namespace Shape

    'Test Class
    <TestClass()>
    Public Class ConeUnitTest

        'Fields for cone test class
        Private height As Single = 5
        Private radius As Single = 5
        Private expectedSurfaceArea As Single = 189.61
        Private expectedVolume As Single = 130.9

        'TODO Need to add TestMethod for RenderMethod

        'TestMethod for the cone surface area method
        <TestMethod()> Public Sub ConeSurfaceAreaTest()

            Dim testCone As New Cone(height, radius)
            Assert.AreEqual(testCone.SurfaceArea(), expectedSurfaceArea)

        End Sub

        'TestMethod for the cone volume method
        <TestMethod()> Public Sub ConeVolumeTest()

            Dim testCone As New Cone(height, radius)
            Assert.AreEqual(testCone.Volume(), expectedVolume)

        End Sub

    End Class

End Namespace