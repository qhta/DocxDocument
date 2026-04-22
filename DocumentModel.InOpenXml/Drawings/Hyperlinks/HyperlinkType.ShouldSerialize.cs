namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HyperlinkType
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeInvalidUrl() => !String.IsNullOrEmpty(InvalidUrl);
  public bool ShouldSerializeAction() => !String.IsNullOrEmpty(Action);
  public bool ShouldSerializeTargetFrame() => !String.IsNullOrEmpty(TargetFrame);
  public bool ShouldSerializeTooltip() => !String.IsNullOrEmpty(Tooltip);
  public bool ShouldSerializeHistory() => History is not null;
  public bool ShouldSerializeHighlightClick() => HighlightClick is not null;
  public bool ShouldSerializeEndSound() => EndSound is not null;
  public bool ShouldSerializeHyperlinkSound() => HyperlinkSound is not null;
  public bool ShouldSerializeHyperlinkExtensionList() => HyperlinkExtensionList is not null;
}
