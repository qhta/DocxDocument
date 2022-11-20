namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LinePropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchStyleProperties))]
public class LinePropertiesExtension: ILinePropertiesExtension
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
