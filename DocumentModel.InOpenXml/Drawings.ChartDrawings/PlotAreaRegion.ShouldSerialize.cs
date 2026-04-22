namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class PlotAreaRegion
{
  public bool ShouldSerializePlotSurface() => PlotSurface is not null;
  public bool ShouldSerializeSeries() => Series is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
