namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class PlotArea
{
  public bool ShouldSerializePlotAreaRegion() => PlotAreaRegion is not null;
  public bool ShouldSerializeAxes() => Axes is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
