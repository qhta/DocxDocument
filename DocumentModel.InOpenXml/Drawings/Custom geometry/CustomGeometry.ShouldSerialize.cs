namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class CustomGeometry
{
  public bool ShouldSerializeAdjustValueList() => AdjustValueList is not null;
  public bool ShouldSerializeShapeGuideList() => ShapeGuideList is not null;
  public bool ShouldSerializeAdjustHandleList() => AdjustHandleList is not null;
  public bool ShouldSerializeConnectionSiteList() => ConnectionSiteList is not null;
  public bool ShouldSerializeRectangle() => Rectangle is not null;
  public bool ShouldSerializePathList() => PathList is not null;
}
