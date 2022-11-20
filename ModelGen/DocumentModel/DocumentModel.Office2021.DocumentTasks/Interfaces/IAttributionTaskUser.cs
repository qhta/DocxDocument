namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the AttributionTaskUser Class.
/// </summary>
public interface IAttributionTaskUser // : DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement
{
  /// <summary>
  /// userId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserId { get ; set; }
  
  /// <summary>
  /// userName, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserName { get ; set; }
  
  /// <summary>
  /// userProvider, this property is only available in Office 2021 and later.
  /// </summary>
  public string? UserProvider { get ; set; }
  
}
