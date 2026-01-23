namespace DocumentModel.Drawings;

public partial class BackgroundBlurProperties
{
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
