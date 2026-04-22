namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BubbleChartSeries
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeOrder() => Order is not null;
  public bool ShouldSerializeSeriesText() => SeriesText is not null;
  public bool ShouldSerializeChartShapeProperties() => ChartShapeProperties is not null;
  public bool ShouldSerializePictureOptions() => PictureOptions is not null;
  public bool ShouldSerializeInvertIfNegative() => InvertIfNegative is not null;
  public bool ShouldSerializeDataPoints() => DataPoints is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeTrendline() => Trendline is not null;
  public bool ShouldSerializeErrorBars() => ErrorBars is not null;
  public bool ShouldSerializeXValues() => XValues is not null;
  public bool ShouldSerializeYValues() => YValues is not null;
  public bool ShouldSerializeBubbleSize() => BubbleSize is not null;
  public bool ShouldSerializeBubble3D() => Bubble3D is not null;
  public bool ShouldSerializeBubbleSerExtensionList() => BubbleSerExtensionList is not null;
}
