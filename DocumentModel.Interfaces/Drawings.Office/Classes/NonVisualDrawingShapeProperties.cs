namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public class NonVisualDrawingShapeProperties: ModelElement
{
  /// <summary>
  ///   Text Box
  /// </summary>
  public bool? TextBox { get; set; }
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}