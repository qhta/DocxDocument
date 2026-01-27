namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HyperlinkOnHover
{
  public bool ShouldSerializeHyperlinkSound() => HyperlinkSound is not null;
  public bool ShouldSerializeHyperlinkExtensionList() => HyperlinkExtensionList is not null;
}
