namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FilteredRadarSeries
{
  public bool ShouldSerializeRadarChartSeries() => RadarChartSeries is not null;
}
