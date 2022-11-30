namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Guides.
/// </summary>
public interface IShapeGuideList // : DocumentModel.Drawing.IGeometryGuideListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IShapeGuide>? ShapeGuides { get ; set; }
  
}
