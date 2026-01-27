namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HyperlinkExtension
{
  public bool ShouldSerializeHyperlinkColor() => HyperlinkColor is not null;
}
