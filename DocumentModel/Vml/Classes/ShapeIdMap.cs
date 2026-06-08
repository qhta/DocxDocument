namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IShape ID Map.
/// </summary>
public class ShapeIdMap: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   IShape IDs
  /// </summary>
  public string? Data { get; set; }
}
