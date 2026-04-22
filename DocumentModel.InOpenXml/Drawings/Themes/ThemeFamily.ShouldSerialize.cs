namespace DocumentModel;

#pragma warning disable CS1591

public partial class ThemeFamily
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeVid() => !String.IsNullOrEmpty(Vid);
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
