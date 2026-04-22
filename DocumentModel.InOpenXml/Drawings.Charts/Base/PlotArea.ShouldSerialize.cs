namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class PlotArea
{
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeCharts() => Charts is not null;
  public bool ShouldSerializeAxes() => Axes is not null;
  public bool ShouldSerializeDataTable() => DataTable is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
