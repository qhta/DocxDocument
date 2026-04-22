namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class ImageControl
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeEnabled() => Enabled is not null;
  public bool ShouldSerializeGetEnabled() => !String.IsNullOrEmpty(GetEnabled);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeImage() => !String.IsNullOrEmpty(Image);
  public bool ShouldSerializeImageMso() => !String.IsNullOrEmpty(ImageMso);
  public bool ShouldSerializeGetImage() => !String.IsNullOrEmpty(GetImage);
  public bool ShouldSerializeAltText() => !String.IsNullOrEmpty(AltText);
  public bool ShouldSerializeGetAltText() => !String.IsNullOrEmpty(GetAltText);
}
