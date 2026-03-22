namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class RelativeHeight
{
  public bool ShouldSerializeRelativeFrom() => RelativeFrom is not null;
  public bool ShouldSerializePercentageHeight() => PercentageHeight is not null;
}
