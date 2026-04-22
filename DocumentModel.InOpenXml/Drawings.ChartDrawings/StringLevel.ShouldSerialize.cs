namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class StringLevel
{
  public bool ShouldSerializePtCount() => PtCount is not null;
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeChartStringValues() => ChartStringValues is not null;
}
