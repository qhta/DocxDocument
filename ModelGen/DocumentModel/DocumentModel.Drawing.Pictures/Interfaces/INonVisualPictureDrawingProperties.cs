namespace DocumentModel.Drawing.Pictures;

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
  public IPictureLocks? PictureLocks { get ; set; }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public INonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
