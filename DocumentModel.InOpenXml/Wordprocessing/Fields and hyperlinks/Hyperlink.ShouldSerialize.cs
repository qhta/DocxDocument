namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Hyperlink<T> 
{
  public bool ShouldSerializeTargetFrame() => !String.IsNullOrEmpty(TargetFrame);
  public bool ShouldSerializeTooltip() => !String.IsNullOrEmpty(Tooltip);
  public bool ShouldSerializeDocLocation() => !String.IsNullOrEmpty(DocLocation);
  public bool ShouldSerializeHistory() => History is not null;
  public bool ShouldSerializeAnchor() => !String.IsNullOrEmpty(Anchor);
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
}
