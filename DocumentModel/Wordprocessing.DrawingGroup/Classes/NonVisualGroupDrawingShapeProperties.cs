using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public class NonVisualGroupDrawingShapeProperties: ModelElement
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