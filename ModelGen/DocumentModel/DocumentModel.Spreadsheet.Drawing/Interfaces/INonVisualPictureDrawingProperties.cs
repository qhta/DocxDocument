namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public interface INonVisualPictureDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize { get ; set; }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public DocumentModel.Drawing.IPictureLocks? PictureLocks { get ; set; }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DocumentModel.Drawing.INonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
