using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
///   Defines the NonVisualConnectorProperties Class.
/// </summary>
public class NonVisualConnectorProperties: ModelElement
{
  /// <summary>
  ///   Connection Shape Locks.
  /// </summary>
  public ConnectionShapeLocks? ConnectionShapeLocks { get; set; }
  /// <summary>
  ///   Connection Start.
  /// </summary>
  public ConnectionType? StartConnection { get; set; }
  /// <summary>
  ///   Connection End.
  /// </summary>
  public ConnectionType? EndConnection { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
}