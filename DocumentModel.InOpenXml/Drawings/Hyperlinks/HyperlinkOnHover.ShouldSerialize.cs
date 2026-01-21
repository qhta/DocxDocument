namespace DocumentModel.Drawings;

public partial class HyperlinkOnHover
{
  public bool ShouldSerializeHyperlinkSound() => HyperlinkSound is not null;
  public bool ShouldSerializeHyperlinkExtensionList() => HyperlinkExtensionList is not null;
}
