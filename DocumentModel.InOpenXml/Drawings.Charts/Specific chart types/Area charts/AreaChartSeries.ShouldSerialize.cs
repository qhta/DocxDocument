namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class AreaChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeAreaSerExtensionList() => AreaSerExtensionList is not null && AreaSerExtensionList.Count > 0;
}
