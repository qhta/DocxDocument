namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Transform2D<T> 
{
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeHorizontalFlip() => HorizontalFlip is not null;
  public bool ShouldSerializeVerticalFlip() => VerticalFlip is not null;
  public bool ShouldSerializeOffset() => Offset is not null;
  public bool ShouldSerializeExtents() => Extents is not null;
}
