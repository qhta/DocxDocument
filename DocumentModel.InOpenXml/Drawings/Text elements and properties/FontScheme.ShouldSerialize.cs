namespace DocumentModel.Drawings;

public partial class FontScheme
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeMajorFont() => MajorFont is not null;
  public bool ShouldSerializeMinorFont() => MinorFont is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
