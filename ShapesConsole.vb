Namespace Shape

    Public Class ShapesConsole

        ' Switch to Irenderer
        Private shapeList As List(Of Shape)

        Private Property Shapes As List(Of Shape)
            Get
                Return shapeList
            End Get
            Set(value As List(Of Shape))
                shapeList = value
            End Set
        End Property

        Public Sub CompositionRoot()
            shapeList = New List(Of Shape)
            Shapes = New List(Of Shape)

            Dim newCone As New Cone(5, 5)
            Shapes.Add(newCone)

            Dim newCylinder As New Cylinder(5, 5, 5)
            Shapes.Add(newCylinder)

            Dim newSphere As New Sphere(5, 5)
            Shapes.Add(newSphere)

            Dim newCuboid As New Cuboid(5, 5, 5)
            Shapes.Add(newCuboid)

        End Sub

        Public Shared Sub Main()
            Dim instance As New ShapesConsole()
            instance.CompositionRoot()
            instance.RenderShapes()
        End Sub

        Public Sub RenderShapes()
            For Each currentShape As Shape In Shapes
                currentShape.Show()
            Next
        End Sub


    End Class

End Namespace
