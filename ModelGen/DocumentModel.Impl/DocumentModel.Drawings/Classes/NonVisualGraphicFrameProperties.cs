namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public class NonVisualGraphicFramePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>, NonVisualGraphicFrameProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public NonVisualDrawingProperties2? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
}
