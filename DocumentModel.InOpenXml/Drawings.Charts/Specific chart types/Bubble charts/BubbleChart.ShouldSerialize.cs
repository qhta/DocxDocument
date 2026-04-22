namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BubbleChart
{
  public bool ShouldSerializeVaryColors() => VaryColors is not null;
  public bool ShouldSerializeBubbleChartSeries() => BubbleChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeBubble3D() => Bubble3D is not null;
  public bool ShouldSerializeBubbleScale() => BubbleScale is not null;
  public bool ShouldSerializeShowNegativeBubbles() => ShowNegativeBubbles is not null;
  public bool ShouldSerializeSizeRepresents() => SizeRepresents is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeBubbleChartExtensionList() => BubbleChartExtensionList is not null;
}
