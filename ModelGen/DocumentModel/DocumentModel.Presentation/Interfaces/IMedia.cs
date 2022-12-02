namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Media Class.
/// </summary>
public interface IMedia // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public System.String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// MediaTrim.
  /// </summary>
  public DocumentModel.Presentation.IMediaTrim? MediaTrim { get ; set; }
  
  /// <summary>
  /// MediaFade.
  /// </summary>
  public DocumentModel.Presentation.IMediaFade? MediaFade { get ; set; }
  
  /// <summary>
  /// MediaBookmarkList.
  /// </summary>
  public DocumentModel.Presentation.IMediaBookmarkList? MediaBookmarkList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
