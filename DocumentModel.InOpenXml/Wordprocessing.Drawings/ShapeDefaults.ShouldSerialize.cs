namespace DocumentModel.Wordprocessing.Drawings;

public partial class ShapeDefaults
{
  public bool ShouldSerializeChildShapeDefaults() => ChildShapeDefaults is not null;
  public bool ShouldSerializeShapeLayout() => ShapeLayout is not null;
}
