namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ImageLayer
{
  public bool ShouldSerializeEmbed() => Embed is not null;
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
