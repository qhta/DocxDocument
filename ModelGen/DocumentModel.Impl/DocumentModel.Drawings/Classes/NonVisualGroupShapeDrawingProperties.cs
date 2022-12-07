namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public class NonVisualGroupShapeDrawingPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>, NonVisualGroupShapeDrawingProperties
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get;
    set;
  }
  
}
