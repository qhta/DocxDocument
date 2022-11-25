namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PhotoAlbum Class.
/// </summary>
public interface IPhotoAlbum // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White
  /// </summary>
  public System.Boolean? BlackWhite { get ; set; }
  
  /// <summary>
  /// Show/Hide Captions
  /// </summary>
  public System.Boolean? ShowCaptions { get ; set; }
  
  /// <summary>
  /// Photo Album Layout
  /// </summary>
  public DocumentModel.Presentation.PhotoAlbumLayoutKind? Layout { get ; set; }
  
  /// <summary>
  /// Frame Type
  /// </summary>
  public DocumentModel.Presentation.PhotoAlbumFrameShapeKind? Frame { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
