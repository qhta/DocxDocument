namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape.
/// </summary>
public class Shape: ModelElement
{
  /// <summary>
  ///   Rotation
  /// </summary>
  public Double? Rotation { get; set; }
  /// <summary>
  ///   Shape Type
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   Relationship to Image Part
  /// </summary>
  public string? Blip { get; set; }
  /// <summary>
  ///   Z-Order Offset
  /// </summary>
  public Int32? ZOrderOffset { get; set; }
  /// <summary>
  ///   Hide Geometry
  /// </summary>
  public bool? HideGeometry { get; set; }
  /// <summary>
  ///   Prevent Text Editing
  /// </summary>
  public bool? LockedText { get; set; }
  /// <summary>
  ///   Image Placeholder
  /// </summary>
  public bool? BlipPlaceholder { get; set; }
  /// <summary>
  ///   Shape Adjust List.
  /// </summary>
  public AdjustList? AdjustList { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}