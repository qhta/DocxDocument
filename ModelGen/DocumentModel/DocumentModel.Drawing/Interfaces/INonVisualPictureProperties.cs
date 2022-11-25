namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Picture.
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
