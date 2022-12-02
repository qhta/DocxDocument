namespace DocumentModel.Presentation;

/// <summary>
/// Slide Synchronization Properties.
/// </summary>
public interface ISlideSyncProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Server's Slide File ID
  /// </summary>
  public String? ServerSlideId { get ; set; }
  
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
  public IExtensionList? ExtensionList { get ; set; }
  
}
