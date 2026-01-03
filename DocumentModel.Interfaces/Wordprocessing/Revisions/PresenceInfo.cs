namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PresenceInfo Class.
/// </summary>
public interface PresenceInfo: IModelElement
{
  /// <summary>
  ///   providerId
  /// </summary>
  public string? ProviderId { get; set; }
  /// <summary>
  ///   userId
  /// </summary>
  public string? UserId { get; set; }
}