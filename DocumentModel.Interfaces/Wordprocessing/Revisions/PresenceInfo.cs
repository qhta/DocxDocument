namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PresenceInfo Class.
/// </summary>
public interface PresenceInfo: IModelElement
{
  /// <summary>
  ///   providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ProviderId { get; set; }
  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? UserId { get; set; }
}