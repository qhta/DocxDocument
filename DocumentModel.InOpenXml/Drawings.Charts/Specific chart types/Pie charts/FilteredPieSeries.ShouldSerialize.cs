namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class FilteredPieSeries
{
  public bool ShouldSerializePieChartSeries() => PieChartSeries is not null;
}
