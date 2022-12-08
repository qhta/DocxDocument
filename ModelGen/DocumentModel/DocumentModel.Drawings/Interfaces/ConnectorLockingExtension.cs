namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public interface ConnectorLockingExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public Graphic? Graphic { get ; set; }
  
}
