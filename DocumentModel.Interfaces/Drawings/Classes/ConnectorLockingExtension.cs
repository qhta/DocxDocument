namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtension interface.
/// </summary>
public interface ConnectorLockingExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public Graphic? Graphic { get; set; }
}