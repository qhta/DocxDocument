namespace DocumentModel.Vml;

/// <summary>
///   Shape Layout Properties.
/// </summary>
public record ShapeLayout
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Shape ID Map.
  /// </summary>
  public ShapeIdMap? ShapeIdMap { get; set; }

  /// <summary>
  ///   Shape Grouping History.
  /// </summary>
  public RegroupTable? RegroupTable { get; set; }

  /// <summary>
  ///   Rule Set.
  /// </summary>
  public Rules? Rules { get; set; }
}