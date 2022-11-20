namespace DocumentModel.Presentation;

/// <summary>
/// Slide Synchronization Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface ISlideSyncProperties // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Server's Slide File ID
  /// </summary>
  public string? ServerSlideId { get ; set; }
  
  /// <summary>
  /// Server's Slide File's modification date/time
  /// </summary>
  public DateTime? ServerSlideModifiedTime { get ; set; }
  
  /// <summary>
  /// Client Slide Insertion date/time
  /// </summary>
  public DateTime? ClientInsertedTime { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
