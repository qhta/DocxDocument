namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the GroupShapeLocks Class.
/// </summary>
public class GroupShapeLocks: ModelElement
{
  /// <summary>
  ///   Disallow IShape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallow IShape Ungrouping
  /// </summary>
  public bool? NoUngrouping { get; set; }

  /// <summary>
  ///   Disallow IShape ISelection
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallow IShape Rotation
  /// </summary>
  public bool? NoRotation { get; set; }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallow Moving IShape
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallow IShape Resizing
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
