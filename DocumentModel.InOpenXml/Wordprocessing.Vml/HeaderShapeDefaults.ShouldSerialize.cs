namespace DocumentModel.Wordprocessing.Vml;

#pragma warning disable CS1591

public partial class HeaderShapeDefaults
{
  public bool ShouldSerializeShapeDefaults() => ShapeDefaults is not null;
  public bool ShouldSerializeShapeLayout() => ShapeLayout is not null;
}
