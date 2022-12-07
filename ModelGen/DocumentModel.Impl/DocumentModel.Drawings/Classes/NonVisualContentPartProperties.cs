namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public class NonVisualContentPartPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.NonVisualContentPartProperties>, NonVisualContentPartProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties3? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get;
    set;
  }
  
}
