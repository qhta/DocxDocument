namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class FilteredScatterSeries
{
  public bool ShouldSerializeScatterChartSeries() => ScatterChartSeries is not null;
}
