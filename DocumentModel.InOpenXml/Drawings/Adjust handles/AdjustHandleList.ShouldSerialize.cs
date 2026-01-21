namespace DocumentModel.Drawings;

public partial class AdjustHandleList
{
  public bool ShouldSerializeAdjustHandleXY() => AdjustHandleXY is not null;
  public bool ShouldSerializeAdjustHandlePolar() => AdjustHandlePolar is not null;
}
