namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class RadarChartExtension
{
  public bool ShouldSerializeFilteredRadarSeries() => FilteredRadarSeries is not null;
}
