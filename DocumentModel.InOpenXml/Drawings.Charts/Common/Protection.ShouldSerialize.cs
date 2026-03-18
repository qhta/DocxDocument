namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class Protection
{
  public bool ShouldSerializeChartObject() => ChartObject is not null;
  public bool ShouldSerializeData() => Data is not null;
  public bool ShouldSerializeFormatting() => Formatting is not null;
  public bool ShouldSerializeSelection() => Selection is not null;
}
