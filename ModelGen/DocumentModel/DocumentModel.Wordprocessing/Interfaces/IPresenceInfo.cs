namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public interface IPresenceInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? ProviderId { get ; set; }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? UserId { get ; set; }
  
}
