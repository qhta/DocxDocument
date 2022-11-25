namespace DocumentModel.Drawing.Pictures;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public interface INonVisualPictureProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.Pictures.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
