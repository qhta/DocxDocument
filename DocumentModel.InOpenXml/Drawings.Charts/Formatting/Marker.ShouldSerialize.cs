namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Marker
{
  public bool ShouldSerializeSymbol() => Symbol is not null;
  public bool ShouldSerializeSize() => Size is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
