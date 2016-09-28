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

    'Cylinder Test Class
    <TestClass()>
    Public Class CylinderUnitTest

        'Fields for cylinder test class

        'Assign 10 to diameter field
        Private diameter As Single = 10
        'Assign 5 to height field
        Private height As Single = 5
        'Assign 5 to radius field
        Private radius As Single = 5
        'Assign 314.16 as the expectedSurfaceArea
        Private expectedSurfaceArea As Single = 314.16
        'Assign 392.7 as the expectedVolume
        Private expectedVolume As Single = 392.7


        'TestMethod for MessageBox?
        <TestMethod()> Public Sub CylinderMessageBoxTest()

            'No idea is this is correct?
            Dim testMessageBox As New MessageBox()

            testMessageBox = New MessageBox()

            Assert.IsInstanceOf(Of IMessageBox)(testMessageBox)

        End Sub

        'TestMethod for the cylinder surface area method
        <TestMethod()> Public Sub CylinderSurfaceAreaTest()

            'Instantiate a new cylinder passing in local field values
            Dim testCylinder As New Cylinder(diameter, height, radius)

            'Assert that the surface area of test cylinder is equal to the expectedSurfaceArea
            Assert.AreEqual(testCylinder.SurfaceArea(), expectedSurfaceArea)

        End Sub

        'TestMethod for the cylinder volume method
        <TestMethod()> Public Sub CylinderVolumeTest()

            'Instantiate a new cylinder passing in local field values
            Dim testCylinder As New Cylinder(diameter, height, radius)

            'Assert that the volume of test cylinder is equal to the expectedVolume
            Assert.AreEqual(testCylinder.Volume(), expectedVolume)

        End Sub

    End Class

End Namespace

