namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Person Class.
/// </summary>
public interface Person: CollectionItem
{
  /// <summary>
  ///   Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public string? Contact { get; set; }
  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo { get; set; }
}