namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public interface INonVisualPictureProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
