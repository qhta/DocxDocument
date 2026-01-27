namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AdjustHandleXY
{
  public bool ShouldSerializeXAdjustmentGuide() => XAdjustmentGuide is not null;
  public bool ShouldSerializeMinX() => MinX is not null;
  public bool ShouldSerializeMaxX() => MaxX is not null;
  public bool ShouldSerializeYAdjustmentGuide() => YAdjustmentGuide is not null;
  public bool ShouldSerializeMinY() => MinY is not null;
  public bool ShouldSerializeMaxY() => MaxY is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
