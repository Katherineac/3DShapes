Public Class ShapesConsole

    ' Switch to Irenderer
    Private shapeList As List(Of IRenderer)

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
        Dim newCone As New Cone(5, 5)
        Shapes.Add(newCone)

    End Sub

    Public Shared Sub Main()
        Dim instance As New ShapesConsole()
        instance.CompositionRoot()
        instance.RenderShapes()
    End Sub

    Public Sub RenderShapes()
        For Each render As IRenderer In Shapes
            MsgBox(render.Render())
        Next
    End Sub





End Class
