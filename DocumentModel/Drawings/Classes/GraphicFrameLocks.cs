namespace DocumentModel.Drawings;

/// <summary>
///   Graphic Frame Locks.
/// </summary>
public record GraphicFrameLocks
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public Boolean? NoGrouping { get; set; }

  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  public Boolean? NoDrilldown { get; set; }

  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  public Boolean? NoSelection { get; set; }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallow Shape Movement
  /// </summary>
  public Boolean? NoMove { get; set; }

  /// <summary>
  ///   Disallow Shape Resize
  /// </summary>
  public Boolean? NoResize { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}