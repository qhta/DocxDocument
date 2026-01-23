namespace DocumentModel.Drawings;

public partial class CompatExtension
{
  public bool ShouldSerializeShapeId() => ShapeId is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
