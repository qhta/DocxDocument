namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PhotoAlbum Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface IPhotoAlbum // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White
  /// </summary>
  public bool? BlackWhite { get ; set; }
  
  /// <summary>
  /// Show/Hide Captions
  /// </summary>
  public bool? ShowCaptions { get ; set; }
  
  /// <summary>
  /// Photo Album Layout
  /// </summary>
  public PhotoAlbumLayout? Layout { get ; set; }
  
  /// <summary>
  /// Frame Type
  /// </summary>
  public PhotoAlbumFrameShape? Frame { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
