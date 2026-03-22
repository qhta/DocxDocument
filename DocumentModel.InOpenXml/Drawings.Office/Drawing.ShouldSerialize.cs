namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591
public partial class Drawing
{
  public bool ShouldSerializeShapeTree() => ShapeTree is not null;
}
