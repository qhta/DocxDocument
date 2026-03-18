namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class LineChartExtension
{
  public bool ShouldSerializeFilteredLineSeriesExtension() => FilteredLineSeriesExtension is not null;
}
