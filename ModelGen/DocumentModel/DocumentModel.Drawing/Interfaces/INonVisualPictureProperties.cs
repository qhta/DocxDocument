namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public interface INonVisualPictureProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
