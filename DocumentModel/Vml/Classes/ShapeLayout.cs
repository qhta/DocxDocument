namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Layout Properties.
/// </summary>
public class ShapeLayout: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   IShape ID Map.
  /// </summary>
  public ShapeIdMap? ShapeIdMap { get; set; }

  /// <summary>
  ///   IShape Grouping History.
  /// </summary>
  public RegroupTable? RegroupTable { get; set; }

  /// <summary>
  ///   Rule Set.
  /// </summary>
  public Rules? Rules { get; set; }
}
