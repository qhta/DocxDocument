namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Non-Visual IShape Drawing Properties.
/// </summary>
public class NonVisualShapeDrawingProperties: ModelElement
{
  /// <summary>
  ///   Text Box
  /// </summary>
  public bool? TextBox { get; set; }

  /// <summary>
  ///   IShape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
