using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingShape;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
}