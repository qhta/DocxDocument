namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class BackgroundBlurProperties
{
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
