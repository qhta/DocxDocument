namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BarChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeInvertIfNegative() => InvertIfNegative is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeTrendline() => Trendline is not null;
  public bool ShouldSerializeErrorBars() => ErrorBars is not null;
  public bool ShouldSerializeCategoryAxisData() => CategoryAxisData is not null;
  public bool ShouldSerializeValues() => Values is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeBarSerExtensionList() => BarSerExtensionList is not null;
}
