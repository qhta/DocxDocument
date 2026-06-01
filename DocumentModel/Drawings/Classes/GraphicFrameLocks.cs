namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Graphic IFrame Locks.
/// </summary>
public class GraphicFrameLocks: ModelElement
{
  /// <summary>
  ///   Disallow IShape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallow ISelection of Child IShapes
  /// </summary>
  public bool? NoDrilldown { get; set; }

  /// <summary>
  ///   Disallow IShape ISelection
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallow IShape Movement
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallow IShape Resize
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
