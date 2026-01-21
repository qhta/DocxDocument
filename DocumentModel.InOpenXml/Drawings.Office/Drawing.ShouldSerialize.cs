namespace DocumentModel.Drawings.Office;

public partial class Drawing
{
  public bool ShouldSerializeShapeTree() => ShapeTree is not null;
}
