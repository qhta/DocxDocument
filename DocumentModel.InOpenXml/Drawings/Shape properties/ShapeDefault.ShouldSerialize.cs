namespace DocumentModel.Drawings;

public partial class ShapeDefault
{
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeBodyProperties() => BodyProperties is not null;
  public bool ShouldSerializeListStyle() => ListStyle is not null;
  public bool ShouldSerializeShapeStyle() => ShapeStyle is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
