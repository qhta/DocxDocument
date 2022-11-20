namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.INonVisualGroupProperties))]
public class NonVisualGroupDrawingShapePropsExtension: INonVisualGroupDrawingShapePropsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
