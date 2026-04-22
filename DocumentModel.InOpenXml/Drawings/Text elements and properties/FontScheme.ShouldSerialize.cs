namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class FontScheme
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeMajorFont() => MajorFont is not null;
  public bool ShouldSerializeMinorFont() => MinorFont is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
