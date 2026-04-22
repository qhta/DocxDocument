namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AdjustHandleXY
{
  public bool ShouldSerializeXAdjustmentGuide() => !String.IsNullOrEmpty(XAdjustmentGuide);
  public bool ShouldSerializeMinX() => !String.IsNullOrEmpty(MinX);
  public bool ShouldSerializeMaxX() => !String.IsNullOrEmpty(MaxX);
  public bool ShouldSerializeYAdjustmentGuide() => !String.IsNullOrEmpty(YAdjustmentGuide);
  public bool ShouldSerializeMinY() => !String.IsNullOrEmpty(MinY);
  public bool ShouldSerializeMaxY() => !String.IsNullOrEmpty(MaxY);
  public bool ShouldSerializePosition() => Position is not null;
}
