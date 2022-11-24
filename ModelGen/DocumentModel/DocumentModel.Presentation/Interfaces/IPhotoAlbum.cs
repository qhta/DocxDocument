namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PhotoAlbum Class.
/// </summary>
public interface IPhotoAlbum // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White
  /// </summary>
  public Boolean? BlackWhite { get ; set; }
  
  /// <summary>
  /// Show/Hide Captions
  /// </summary>
  public Boolean? ShowCaptions { get ; set; }
  
  /// <summary>
  /// Photo Album Layout
  /// </summary>
  public PhotoAlbumLayoutValues? Layout { get ; set; }
  
  /// <summary>
  /// Frame Type
  /// </summary>
  public PhotoAlbumFrameShapeValues? Frame { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
