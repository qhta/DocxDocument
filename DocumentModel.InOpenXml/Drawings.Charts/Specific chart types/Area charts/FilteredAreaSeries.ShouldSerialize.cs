namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class FilteredAreaSeries
{
  public bool ShouldSerializeAreaChartSeries() => AreaChartSeries is not null;
}
