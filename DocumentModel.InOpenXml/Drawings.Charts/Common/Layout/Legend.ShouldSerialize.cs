namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Legend
{
  public bool ShouldSerializeLegendPosition() => LegendPosition is not null;
  public bool ShouldSerializeLegendEntries() => LegendEntries is not null;
  public bool ShouldSerializeLayout() => Layout is not null;
  public bool ShouldSerializeOverlay() => Overlay is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
}
