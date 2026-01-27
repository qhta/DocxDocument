namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class ShapeDefaults
{
  public bool ShouldSerializeChildShapeDefaults() => ChildShapeDefaults is not null;
  public bool ShouldSerializeShapeLayout() => ShapeLayout is not null;
}
