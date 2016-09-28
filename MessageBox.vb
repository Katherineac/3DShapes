'Shapes Assignment
'Agile Programming
'Fall 2016
'Katie Cater, Lucas Lokken, Austing Prueher, Pheng Vang

'All fields must be explicitly declared
Option Explicit On

'Uses Shape Namespace
Namespace Shape

    'MessageBox Class - implements IMessageBox interface
    Public Class MessageBox
        Implements IMessageBox

        'MessageBox constructor
        Sub New()
        End Sub

        'Show() method - accepts renderString and name as parameters
        Public Sub Show(renderString As String, name As String) Implements IMessageBox.Show
            'Display a message box for the user - outputs renderString parameter, OK button(0), name for message box title
            MsgBox(renderString, 0, name)
        End Sub

    End Class

End Namespace

