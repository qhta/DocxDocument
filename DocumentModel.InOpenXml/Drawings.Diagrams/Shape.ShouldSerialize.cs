namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Shape
{
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeType() => !String.IsNullOrEmpty(Type);
  public bool ShouldSerializeBlip() => !String.IsNullOrEmpty(Blip);
  public bool ShouldSerializeZOrderOffset() => ZOrderOffset is not null;
  public bool ShouldSerializeHideGeometry() => HideGeometry is not null;
  public bool ShouldSerializeLockedText() => LockedText is not null;
  public bool ShouldSerializeBlipPlaceholder() => BlipPlaceholder is not null;
  public bool ShouldSerializeAdjustList() => AdjustList is not null && AdjustList.Count > 0;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
