namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualGraphicFrameDrawingProperties))]
public class NonVisualGraphicFrameProperties: INonVisualGraphicFrameProperties
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
}
