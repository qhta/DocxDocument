namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ScatterChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializeMarker() => Marker is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeTrendline() => Trendline is not null;
  public bool ShouldSerializeErrorBars() => ErrorBars is not null;
  public bool ShouldSerializeXValues() => XValues is not null;
  public bool ShouldSerializeYValues() => YValues is not null;
  public bool ShouldSerializeSmooth() => Smooth is not null;
  public bool ShouldSerializeScatterSerExtensionList() => ScatterSerExtensionList is not null;
}
