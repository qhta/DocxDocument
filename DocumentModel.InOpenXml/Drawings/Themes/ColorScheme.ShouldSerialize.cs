namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ColorScheme
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeDark1Color() => Dark1Color is not null;
  public bool ShouldSerializeLight1Color() => Light1Color is not null;
  public bool ShouldSerializeDark2Color() => Dark2Color is not null;
  public bool ShouldSerializeLight2Color() => Light2Color is not null;
  public bool ShouldSerializeAccent1Color() => Accent1Color is not null;
  public bool ShouldSerializeAccent2Color() => Accent2Color is not null;
  public bool ShouldSerializeAccent3Color() => Accent3Color is not null;
  public bool ShouldSerializeAccent4Color() => Accent4Color is not null;
  public bool ShouldSerializeAccent5Color() => Accent5Color is not null;
  public bool ShouldSerializeAccent6Color() => Accent6Color is not null;
  public bool ShouldSerializeHyperlink() => Hyperlink is not null;
  public bool ShouldSerializeFollowedHyperlink() => FollowedHyperlink is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
