using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingShape;

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
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
}