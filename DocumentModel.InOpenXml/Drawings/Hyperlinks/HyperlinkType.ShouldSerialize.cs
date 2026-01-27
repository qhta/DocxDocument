namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HyperlinkType
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeInvalidUrl() => InvalidUrl is not null;
  public bool ShouldSerializeAction() => Action is not null;
  public bool ShouldSerializeTargetFrame() => TargetFrame is not null;
  public bool ShouldSerializeTooltip() => Tooltip is not null;
  public bool ShouldSerializeHistory() => History is not null;
  public bool ShouldSerializeHighlightClick() => HighlightClick is not null;
  public bool ShouldSerializeEndSound() => EndSound is not null;
  public bool ShouldSerializeHyperlinkSound() => HyperlinkSound is not null;
  public bool ShouldSerializeHyperlinkExtensionList() => HyperlinkExtensionList is not null;
}
