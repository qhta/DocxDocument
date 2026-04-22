namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class Item
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeImage() => !String.IsNullOrEmpty(Image);
  public bool ShouldSerializeImageMso() => !String.IsNullOrEmpty(ImageMso);
  public bool ShouldSerializeScreentip() => !String.IsNullOrEmpty(Screentip);
  public bool ShouldSerializeSupertip() => !String.IsNullOrEmpty(Supertip);
}
