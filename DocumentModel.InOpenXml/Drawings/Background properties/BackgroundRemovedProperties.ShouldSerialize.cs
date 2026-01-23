namespace DocumentModel.Drawings;

public partial class BackgroundRemovedProperties
{
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
