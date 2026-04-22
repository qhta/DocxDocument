namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CompatExtension
{
  public bool ShouldSerializeShapeId() => !String.IsNullOrEmpty(ShapeId);
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
}
