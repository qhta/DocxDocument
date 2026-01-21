namespace DocumentModel;

public partial class ThemeFamily
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeVid() => Vid is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
