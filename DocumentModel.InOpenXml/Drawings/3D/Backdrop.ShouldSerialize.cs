namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Backdrop
{
  public bool ShouldSerializeAnchor() => Anchor is not null;
  public bool ShouldSerializeNormal() => Normal is not null;
  public bool ShouldSerializeUpVector() => UpVector is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
