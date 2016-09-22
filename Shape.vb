Imports Shapes3D

Public MustInherit Class Shape
    Implements IMessageBox
    Sub New()

    End Sub
    Public MustOverride Sub Shape()

    Public MustOverride Function SurfaceArea() As Single

    Public MustOverride Function Volume() As Single

    Public MustOverride Sub Show() Implements IMessageBox.Show

    Protected MessageBox 'Getter or Setter
End Class
