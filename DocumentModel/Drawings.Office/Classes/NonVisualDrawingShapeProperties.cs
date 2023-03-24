namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public class NonVisualDrawingShapeProperties: ModelElement
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