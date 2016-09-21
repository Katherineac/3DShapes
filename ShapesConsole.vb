Public Class ShapesConsole

    ' Visual Studio won't let me name as shapes
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
        Throw New NotImplementedException()
    End Sub

    Public Sub Main()
        Throw New NotImplementedException()
    End Sub

    Public Sub RenderShapes()
        Throw New NotImplementedException()
    End Sub





End Class
