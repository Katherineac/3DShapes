Option Explicit On

Imports NUnit.Framework
Imports Shape

Namespace Shape

    'Test Class
    <TestClass()>
    Public Class CuboidUnitTest

        'Fields for cuboid test class

        Dim testCuboidOne As New Cuboid(5, 5, 5)
        Private expectedSurfaceAreaOne As Single = 150
        Private expectedVolumeOne As Single = 125

        Dim testCuboidTwo As New Cuboid(2, 6, 13)
        Private expectedSurfaceAreaTwo As Single = 232
        Private expectedVolumeTwo As Single = 156

        'TODO Need to add TestMethod for RenderMethod

        'TestMethod for the cuboid surface area method
        <TestMethod()> Public Sub CuboidTestOne()
            Assert.AreEqual(testCuboidOne.SurfaceArea(), expectedSurfaceAreaOne)
            Assert.AreEqual(testCuboidOne.Volume(), expectedVolumeOne)
        End Sub

        'TestMethod for the cuboid volume method
        <TestMethod()> Public Sub CuboidTestTwo()
            Assert.AreEqual(testCuboidTwo.SurfaceArea(), expectedSurfaceAreaTwo)
            Assert.AreEqual(testCuboidTwo.Volume(), expectedVolumeTwo)
        End Sub

    End Class

End Namespace