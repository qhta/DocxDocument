namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class StockChart
{
  public bool ShouldSerializeLineChartSeries() => LineChartSeries is not null;
  public bool ShouldSerializeDataLabels() => DataLabels is not null;
  public bool ShouldSerializeDropLines() => DropLines is not null;
  public bool ShouldSerializeHighLowLines() => HighLowLines is not null;
  public bool ShouldSerializeUpDownBars() => UpDownBars is not null;
  public bool ShouldSerializeAxisIds() => AxisIds is not null;
  public bool ShouldSerializeStockChartExtensionList() => StockChartExtensionList is not null;
}
