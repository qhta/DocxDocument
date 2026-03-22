namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class ErrorBars
{
  public bool ShouldSerializeErrorDirection() => ErrorDirection is not null;
  public bool ShouldSerializeErrorBarType() => ErrorBarType is not null;
  public bool ShouldSerializeErrorBarValueType() => ErrorBarValueType is not null;
  public bool ShouldSerializeNoEndCap() => NoEndCap is not null;
  public bool ShouldSerializePlus() => Plus is not null;
  public bool ShouldSerializeMinus() => Minus is not null;
  public bool ShouldSerializeErrorBarValue() => ErrorBarValue is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
