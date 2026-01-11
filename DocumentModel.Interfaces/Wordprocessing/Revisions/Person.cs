namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a person associated with a revision in a WordprocessingML document.
/// This interface extends <see cref="CollectionItem"/> and provides properties for contact information, author name, and presence information, enabling tracking and management of user metadata for collaborative editing and revision history.
/// </summary>
public interface Person : CollectionItem
{

  /// <summary>
  /// Contact information for the person, available for backwards compatibility.
  /// </summary>
  public string? Contact { get; set; }

  /// <summary>
  /// Name of the author associated with the revision or document change.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  /// Presence information for the person, providing metadata about user presence and collaboration status.
  /// </summary>
  public PresenceInfo? PresenceInfo { get; set; }
}