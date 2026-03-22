namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Lock
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeSelection() => Selection is not null;
  public bool ShouldSerializeGrouping() => Grouping is not null;
  public bool ShouldSerializeUngrouping() => Ungrouping is not null;
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeCropping() => Cropping is not null;
  public bool ShouldSerializeVerticies() => Verticies is not null;
  public bool ShouldSerializeAdjustHandles() => AdjustHandles is not null;
  public bool ShouldSerializeTextLock() => TextLock is not null;
  public bool ShouldSerializeAspectRatio() => AspectRatio is not null;
  public bool ShouldSerializeShapeType() => ShapeType is not null;
}
