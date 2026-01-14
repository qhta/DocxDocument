namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public interface NonVisualGroupDrawingShapeProperties
{
  /// <summary>
  ///   GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks { get; set; }
  /// <summary>
  ///   NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get; set; }
}