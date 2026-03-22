namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class DataTable
{
  public bool ShouldSerializeShowHorizontalBorder() => ShowHorizontalBorder is not null;
  public bool ShouldSerializeShowVerticalBorder() => ShowVerticalBorder is not null;
  public bool ShouldSerializeShowOutlineBorder() => ShowOutlineBorder is not null;
  public bool ShouldSerializeShowKeys() => ShowKeys is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
