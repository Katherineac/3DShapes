Namespace Shape

    Public Class MessageBox
        Implements IMessageBox

        Sub New()
        End Sub

        Public Sub Show(renderString As String, name As String) Implements IMessageBox.Show
            MsgBox(renderString, 0, name)
        End Sub

    End Class

End Namespace

