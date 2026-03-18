namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class AreaChartSeries3
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeTrendline() => Trendline is not null;
  public bool ShouldSerializeErrorBars() => ErrorBars is not null;
  public bool ShouldSerializeCategoryAxisData() => CategoryAxisData is not null;
  public bool ShouldSerializeValues() => Values is not null;
  public bool ShouldSerializeAreaSerExtensionList() => AreaSerExtensionList is not null && AreaSerExtensionList.Count > 0;
}
