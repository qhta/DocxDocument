namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public interface NonVisualGroupDrawingShapeProperties
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
