namespace DocumentModel.Drawings;

/// <summary>
///   Shape Locks.
/// </summary>
public class ShapeLocks: ModelElement
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }
  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  public bool? NoSelection { get; set; }
  /// <summary>
  ///   Disallow Shape Rotation
  /// </summary>
  public bool? NoRotation { get; set; }
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect { get; set; }
  /// <summary>
  ///   Disallow Shape Movement
  /// </summary>
  public bool? NoMove { get; set; }
  /// <summary>
  ///   Disallow Shape Resize
  /// </summary>
  public bool? NoResize { get; set; }
  /// <summary>
  ///   Disallow Shape Point Editing
  /// </summary>
  public bool? NoEditPoints { get; set; }
  /// <summary>
  ///   Disallow Showing Adjust Handles
  /// </summary>
  public bool? NoAdjustHandles { get; set; }
  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  public bool? NoChangeArrowheads { get; set; }
  /// <summary>
  ///   Disallow Shape Type Change
  /// </summary>
  public bool? NoChangeShapeType { get; set; }
  /// <summary>
  ///   Disallow Shape Text Editing
  /// </summary>
  public bool? NoTextEdit { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}