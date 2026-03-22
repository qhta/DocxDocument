namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FilteredBubbleSeries
{
  public bool ShouldSerializeBubbleChartSeries() => BubbleChartSeries is not null;
}
