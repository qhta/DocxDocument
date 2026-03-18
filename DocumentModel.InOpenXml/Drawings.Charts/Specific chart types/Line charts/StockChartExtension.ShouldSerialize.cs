namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class StockChartExtension
{
  public bool ShouldSerializeFilteredLineSeriesExtension() => FilteredLineSeriesExtension is not null;
}
