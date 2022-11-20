namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public interface IPresenceInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? UserId { get ; set; }
  
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ProviderId { get ; set; }
  
}
