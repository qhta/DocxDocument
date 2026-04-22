namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Chart
{
  public bool ShouldSerializeChartTitle() => ChartTitle is not null;
  public bool ShouldSerializePlotArea() => PlotArea is not null;
  public bool ShouldSerializeLegend() => Legend is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
