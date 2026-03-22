namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class SeriesAxis
{
  public bool ShouldSerializeTickLabelSkip() => TickLabelSkip is not null;
  public bool ShouldSerializeTickMarkSkip() => TickMarkSkip is not null;
  public bool ShouldSerializeSerAxExtensionList() => SerAxExtensionList is not null && SerAxExtensionList.Count>0;
}
