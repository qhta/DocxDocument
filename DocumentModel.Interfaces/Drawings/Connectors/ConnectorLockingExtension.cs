namespace DocumentModel.Drawings;

/// <summary>
/// Represents an extension for connector locking, allowing additional properties or graphics to be associated with a connector lock.
/// </summary>
public interface ConnectorLockingExtension: CollectionItem
{
  /// <summary>
  /// URI that identifies the extension.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  /// Graphic element associated with the connector locking extension.
  /// </summary>
  public Graphic? Graphic { get; set; }
}