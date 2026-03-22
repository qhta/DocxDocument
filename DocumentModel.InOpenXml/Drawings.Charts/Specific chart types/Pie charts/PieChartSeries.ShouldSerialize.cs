namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class PieChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeExplosion() => Explosion is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeCategoryAxisData() => CategoryAxisData is not null;
  public bool ShouldSerializeValues() => Values is not null;
  public bool ShouldSerializePieSerExtensionList() => PieSerExtensionList is not null && PieSerExtensionList.Count > 0;
}
