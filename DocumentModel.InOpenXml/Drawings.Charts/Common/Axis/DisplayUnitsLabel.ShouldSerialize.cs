namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class DisplayUnitsLabel
{
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeChartText() => ChartText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
}
