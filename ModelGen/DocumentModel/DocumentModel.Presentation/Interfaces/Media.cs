namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Media Class.
/// </summary>
public interface Media // : DocumentModel.BaseTypes.ModelElement
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
  public MediaTrim? MediaTrim { get ; set; }
  
  /// <summary>
  /// MediaFade.
  /// </summary>
  public MediaFade? MediaFade { get ; set; }
  
  /// <summary>
  /// MediaBookmarkList.
  /// </summary>
  public MediaBookmarkList? MediaBookmarkList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
