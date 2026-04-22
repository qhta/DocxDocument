namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ImageLayer
{
  public bool ShouldSerializeEmbed() => !String.IsNullOrEmpty(Embed);
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
