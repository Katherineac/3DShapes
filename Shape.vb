'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape namespace
Namespace Shape

    'Shape Class - implements IMessageBox
    Public MustInherit Class Shape
        Implements IMessageBox

#Region "Properties"

        'Shape properties

        'Field for MessageBox
        Protected MessageBox As IMessageBox

#End Region

#Region "Methods"

        'Shape Constructor
        Sub New()

            'Assign new MessageBox object to MessageBox field
            Me.MessageBox = New MessageBox

        End Sub

        'Show method
        Public Sub Show(renderString As String, name As String) Implements IMessageBox.Show
            Throw New NotImplementedException()
        End Sub

        'SurfaceArea method
        Public MustOverride Function SurfaceArea() As Single

        'Volume method
        Public MustOverride Function Volume() As Single

#End Region

    End Class

End Namespace
