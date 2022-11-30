namespace DocumentModel.Presentation;

/// <summary>
/// Slide Synchronization Properties.
/// </summary>
public interface ISlideSyncProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Server's Slide File ID
  /// </summary>
  public System.String? ServerSlideId { get ; set; }
  
  /// <summary>
  /// Server's Slide File's modification date/time
  /// </summary>
  public System.DateTime? ServerSlideModifiedTime { get ; set; }
  
  /// <summary>
  /// Client Slide Insertion date/time
  /// </summary>
  public System.DateTime? ClientInsertedTime { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
