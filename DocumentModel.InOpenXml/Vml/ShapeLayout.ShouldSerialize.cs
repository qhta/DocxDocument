namespace DocumentModel.Vml;

public partial class ShapeLayout
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeShapeIdMap() => ShapeIdMap is not null;
  public bool ShouldSerializeRegroupTable() => RegroupTable is not null;
  public bool ShouldSerializeRules() => Rules is not null;
}
