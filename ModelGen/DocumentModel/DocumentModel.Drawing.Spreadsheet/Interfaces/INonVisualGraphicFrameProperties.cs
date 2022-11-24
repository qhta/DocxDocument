namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Properties for a Graphic Frame.
/// </summary>
public interface INonVisualGraphicFrameProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Non-Visual Properties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  public INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}
