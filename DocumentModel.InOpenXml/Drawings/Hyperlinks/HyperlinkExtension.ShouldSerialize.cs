namespace DocumentModel.Drawings;

public partial class HyperlinkExtension
{
  public bool ShouldSerializeHyperlinkColor() => HyperlinkColor is not null;
}
