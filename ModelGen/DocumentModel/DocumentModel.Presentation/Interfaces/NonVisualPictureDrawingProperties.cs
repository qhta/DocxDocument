namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public interface NonVisualPictureDrawingProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize { get ; set; }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public DocumentModel.Drawings.PictureLocks? PictureLocks { get ; set; }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
