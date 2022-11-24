namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public interface IPresenceInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? UserId { get ; set; }
  
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ProviderId { get ; set; }
  
}
