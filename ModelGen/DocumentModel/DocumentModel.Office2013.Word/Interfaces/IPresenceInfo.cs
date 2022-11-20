namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the PresenceInfo Class.
/// </summary>
public interface IPresenceInfo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ProviderId { get ; set; }
  
  /// <summary>
  /// userId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? UserId { get ; set; }
  
}
