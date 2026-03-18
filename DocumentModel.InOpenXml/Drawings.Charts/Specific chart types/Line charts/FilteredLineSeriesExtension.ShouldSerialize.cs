namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class FilteredLineSeriesExtension
{
  public bool ShouldSerializeLineChartSeries() => LineChartSeries is not null;
}
