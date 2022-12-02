namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public interface IAdjustValueList // : DocumentModel.Drawing.IGeometryGuideListType
{
  public Collection<IShapeGuide>? ShapeGuides { get ; set; }
  
}
