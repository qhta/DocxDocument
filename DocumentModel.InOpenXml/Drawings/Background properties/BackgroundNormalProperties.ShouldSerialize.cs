namespace DocumentModel.Drawings;

public partial class BackgroundNormalProperties
{
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
