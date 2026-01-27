namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AdjustHandleList
{
  public bool ShouldSerializeAdjustHandleXY() => AdjustHandleXY is not null;
  public bool ShouldSerializeAdjustHandlePolar() => AdjustHandlePolar is not null;
}
