namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ChartStringValue
{
  public bool ShouldSerializeIndex() => Index is not null;
}
