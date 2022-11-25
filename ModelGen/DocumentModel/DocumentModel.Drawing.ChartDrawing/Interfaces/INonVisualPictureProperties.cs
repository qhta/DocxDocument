namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public interface INonVisualPictureProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
