namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Title
{
  public bool ShouldSerializeChartText() => ChartText is not null;
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeOverlay() => Overlay is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
