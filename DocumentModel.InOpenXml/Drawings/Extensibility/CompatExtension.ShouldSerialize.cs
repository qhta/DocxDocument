namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CompatExtension
{
  public bool ShouldSerializeShapeId() => ShapeId is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
