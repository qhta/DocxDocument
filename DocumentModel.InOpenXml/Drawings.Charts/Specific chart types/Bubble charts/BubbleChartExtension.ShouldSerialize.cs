namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class BubbleChartExtension
{
  public bool ShouldSerializeFilteredBubbleSeries() => FilteredBubbleSeries is not null;
}
