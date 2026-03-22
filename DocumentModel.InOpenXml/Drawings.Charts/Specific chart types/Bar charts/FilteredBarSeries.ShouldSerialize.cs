namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FilteredBarSeries
{
  public bool ShouldSerializeBarChartSeries() => BarChartSeries is not null;
}
