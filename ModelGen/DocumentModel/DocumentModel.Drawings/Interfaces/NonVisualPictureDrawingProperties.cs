namespace DocumentModel.Drawings;

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
  public PictureLocks? PictureLocks { get ; set; }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
