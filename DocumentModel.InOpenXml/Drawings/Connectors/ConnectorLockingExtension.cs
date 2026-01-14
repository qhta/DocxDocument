namespace DocumentModel.Drawings;

/// <summary>
/// Represents an extension for connector locking, allowing additional properties or graphics to be associated with a connector lock.
/// </summary>
public interface ConnectorLockingExtension: IExtension
{

  /// <summary>
  /// Graphic element associated with the connector locking extension.
  /// </summary>
  public Graphic? Graphic { get; set; }
}