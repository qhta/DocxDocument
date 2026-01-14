namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents presence information for a user in a WordprocessingML document.
/// This interface provides properties for the provider and user identifiers, enabling tracking and management of user presence and collaboration metadata.
/// </summary>
public interface PresenceInfo
{
  /// <summary>
  /// Identifier for the presence provider, specifying the source of presence information.
  /// </summary>
  public string? ProviderId { get; set; }

  /// <summary>
  /// Identifier for the user whose presence is being tracked.
  /// </summary>
  public string? UserId { get; set; }
}