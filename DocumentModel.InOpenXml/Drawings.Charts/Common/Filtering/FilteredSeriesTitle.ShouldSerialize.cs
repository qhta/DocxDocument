namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FilteredSeriesTitle
{
  public bool ShouldSerializeChartText() => ChartText is not null;
}
