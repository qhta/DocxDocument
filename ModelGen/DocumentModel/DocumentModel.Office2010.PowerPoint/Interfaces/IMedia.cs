namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the Media Class.
/// </summary>
public interface IMedia // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// MediaTrim.
  /// </summary>
  public IMediaTrim? MediaTrim { get ; set; }
  
  /// <summary>
  /// MediaFade.
  /// </summary>
  public IMediaFade? MediaFade { get ; set; }
  
  /// <summary>
  /// MediaBookmarkList.
  /// </summary>
  public IMediaBookmarkList? MediaBookmarkList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
