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

    End Sub

    Public Sub Main()
        CompositionRoot()
        RenderShapes()
    End Sub

    Public Sub RenderShapes()
        For Each currentShape As Shape In shapeList
            currentShape.MessageBox.Show()
        Next

    End Sub





End Class
