namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class NumericValue
{
  public bool ShouldSerializeIdx() => Idx is not null;
}
