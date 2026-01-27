namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HyperlinkOnMouseOver
{
  public bool ShouldSerializeHyperlinkSound() => HyperlinkSound is not null;
  public bool ShouldSerializeHyperlinkExtensionList() => HyperlinkExtensionList is not null;
}
