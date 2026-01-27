namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class BackgroundNormalProperties
{
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
