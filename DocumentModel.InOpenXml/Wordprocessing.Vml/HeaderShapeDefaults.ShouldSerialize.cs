namespace DocumentModel.Wordprocessing.Vml;

public partial class HeaderShapeDefaults
{
  public bool ShouldSerializeShapeDefaults() => ShapeDefaults is not null;
  public bool ShouldSerializeShapeLayout() => ShapeLayout is not null;
}
