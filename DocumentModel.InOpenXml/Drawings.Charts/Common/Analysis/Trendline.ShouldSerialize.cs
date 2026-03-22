namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class Trendline
{
  public bool ShouldSerializeTrendlineName() => !String.IsNullOrEmpty(TrendlineName);
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeTrendlineType() => TrendlineType is not null;
  public bool ShouldSerializePolynomialOrder() => PolynomialOrder is not null;
  public bool ShouldSerializePeriod() => Period is not null;
  public bool ShouldSerializeForward() => Forward is not null;
  public bool ShouldSerializeBackward() => Backward is not null;
  public bool ShouldSerializeIntercept() => Intercept is not null;
  public bool ShouldSerializeDisplayRSquaredValue() => DisplayRSquaredValue is not null;
  public bool ShouldSerializeDisplayEquation() => DisplayEquation is not null;
  public bool ShouldSerializeTrendlineLabel() => TrendlineLabel is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
