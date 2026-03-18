namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class TrendlineLabel
{
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeChartText() => ChartText is not null;
  public bool ShouldSerializeNumberingFormat() => NumberingFormat is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
