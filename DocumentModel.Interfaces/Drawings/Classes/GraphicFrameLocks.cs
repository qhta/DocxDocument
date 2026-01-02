namespace DocumentModel.Drawings;

/// <summary>
///   Graphic Frame Locks.
/// </summary>
public class GraphicFrameLocks: ModelElement
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }
  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  public bool? NoDrilldown { get; set; }
  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  public bool? NoSelection { get; set; }
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
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}