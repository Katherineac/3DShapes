
Namespace Shape
    Public MustInherit Class Shape
        Implements IMessageBox

#Region "Properties"

        Protected MessageBox As IMessageBox

#End Region

#Region "Methods"

        Sub New()
            Me.MessageBox = New MessageBox
        End Sub

        Protected MustOverride Sub Show(renderString As String, name As String) Implements IMessageBox.Show

        Public MustOverride Function SurfaceArea() As Single
        Public MustOverride Function Volume() As Single

#End Region

    End Class

End Namespace
