namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Hyperlink<T> 
{
  public bool ShouldSerializeTargetFrame() => TargetFrame is not null;
  public bool ShouldSerializeTooltip() => Tooltip is not null;
  public bool ShouldSerializeDocLocation() => DocLocation is not null;
  public bool ShouldSerializeHistory() => History is not null;
  public bool ShouldSerializeAnchor() => Anchor is not null;
  public bool ShouldSerializeId() => Id is not null;
}
