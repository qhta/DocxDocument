namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Guides.
/// </summary>
public interface IShapeGuideList // : DocumentModel.Drawing.IGeometryGuideListType
{
  public Collection<IShapeGuide>? ShapeGuides { get ; set; }
  
}
