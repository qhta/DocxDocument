namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class ColorMappingType
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
