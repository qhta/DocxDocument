namespace DocumentModel.Office2010.PowerPoint;

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
  public DocumentModel.Office2010.PowerPoint.IMediaTrim? MediaTrim { get ; set; }
  
  /// <summary>
  /// MediaFade.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IMediaFade? MediaFade { get ; set; }
  
  /// <summary>
  /// MediaBookmarkList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? MediaBookmarkList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
