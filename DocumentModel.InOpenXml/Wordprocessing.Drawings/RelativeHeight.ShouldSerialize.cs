namespace DocumentModel.Wordprocessing.Drawings;

public partial class RelativeHeight
{
  public bool ShouldSerializeRelativeFrom() => RelativeFrom is not null;
  public bool ShouldSerializePercentageHeight() => PercentageHeight is not null;
}
