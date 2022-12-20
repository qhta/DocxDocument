namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public partial interface ConnectorLockingExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Graphic? Graphic { get; set; }
  
}
