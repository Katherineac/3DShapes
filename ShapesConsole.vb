Public Class ShapesConsole

    ' Switch to Irenderer
    Private shapeList As List(Of IRenderer)
    Dim height = 5
    Dim length = 5
    Dim width = 5
    Dim radius = 5
    Dim diameter = 5

    Private Property Shapes As List(Of IRenderer)
        Get
            Return shapeList
        End Get
        Set(value As List(Of IRenderer))
            shapeList = value
        End Set
    End Property

    Public Sub CompositionRoot()
        shapeList = New List(Of IRenderer)
        Shapes = New List(Of IRenderer)

        Dim newCone As New Cone(height, radius)
        Shapes.Add(newCone)

        Dim newCylinder As New Cylinder(diameter, height, radius)
        Shapes.Add(newCylinder)

        Dim newSphere As New Sphere(diameter, radius)
        Shapes.Add(newSphere)

        Dim newCuboid As New Cuboid(height, length, width)
        Shapes.Add(newCuboid)

    End Sub

    Public Shared Sub Main()
        Dim instance As New ShapesConsole()
        instance.CompositionRoot()
        instance.RenderShapes()
    End Sub

    Public Sub RenderShapes()
        For Each render As IRenderer In Shapes
            render.Render()
        Next
    End Sub


End Class
