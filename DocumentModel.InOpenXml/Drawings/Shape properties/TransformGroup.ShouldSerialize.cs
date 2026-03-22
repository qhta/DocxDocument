namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class TransformGroup
{
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeHorizontalFlip() => HorizontalFlip is not null;
  public bool ShouldSerializeVerticalFlip() => VerticalFlip is not null;
  public bool ShouldSerializeOffset() => Offset is not null;
  public bool ShouldSerializeExtents() => Extents is not null;
  public bool ShouldSerializeChildOffset() => ChildOffset is not null;
  public bool ShouldSerializeChildExtents() => ChildExtents is not null;
}
