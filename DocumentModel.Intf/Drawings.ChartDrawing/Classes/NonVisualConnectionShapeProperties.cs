namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Non-Visual Connection Shape Drawing Properties.
/// </summary>
public class NonVisualConnectionShapeProperties: ModelElement
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
  public ExtensionList? ExtensionList { get; set; }
}