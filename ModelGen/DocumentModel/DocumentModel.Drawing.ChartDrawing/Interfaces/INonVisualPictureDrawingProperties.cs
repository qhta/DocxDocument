namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public interface INonVisualPictureDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public System.Boolean? PreferRelativeResize { get ; set; }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public DocumentModel.Drawing.IPictureLocks? PictureLocks { get ; set; }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
