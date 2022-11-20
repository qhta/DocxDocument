namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGraphicFrameDrawingProperties))]
public class NonVisualGraphicFrameProperties: INonVisualGraphicFrameProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
  {
    get;
    set;
  }
  
}
