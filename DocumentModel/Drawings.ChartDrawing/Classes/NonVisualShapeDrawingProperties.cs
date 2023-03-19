namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Shape Drawing Properties.
/// </summary>
public class NonVisualShapeDrawingProperties: ModelElement
{
  /// <summary>
  ///   Text Box
  /// </summary>
  public Boolean? TextBox { get; set; }

  /// <summary>
  ///   Shape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}