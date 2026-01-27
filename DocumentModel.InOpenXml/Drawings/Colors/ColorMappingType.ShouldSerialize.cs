namespace DocumentModel.Wordprocessing;

public partial class ColorMappingType
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
