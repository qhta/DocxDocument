namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BarChartExtension
{
  public bool ShouldSerializeFilteredBarSeries() => FilteredBarSeries is not null;
}
