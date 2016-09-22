Public MustInherit Class Shapes
    Sub New()

    End Sub
    Public MustOverride Sub Shape()

    Public MustOverride Function SurfaceArea() As Single

    Public MustOverride Function Volume() As Single
    Protected MessageBox 'Getter or Setter
End Class
