namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public class LineSketchTypePropertiesImpl: ModelElementImpl, LineSketchTypeProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public Boolean? LineSketchNoneEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public Boolean? LineSketchCurvedEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public Boolean? LineSketchFreehandEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public Boolean? LineSketchScribbleEmpty
  {
    get;
    set;
  }
  
}
