namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtension Class.
/// </summary>
public class ConnectorLockingExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public Graphic? Graphic { get; set; }
}