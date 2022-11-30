namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public interface IAdjustValueList // : DocumentModel.Drawing.IGeometryGuideListType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IShapeGuide>? ShapeGuides { get ; set; }
  
}
