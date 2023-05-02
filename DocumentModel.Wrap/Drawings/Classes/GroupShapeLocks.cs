namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GroupShapeLocks Class.
/// </summary>
public class GroupShapeLocks: ModelElement
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallow Shape Ungrouping
  /// </summary>
  public bool? NoUngrouping { get; set; }

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
  ///   Disallow Moving Shape
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallow Shape Resizing
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}