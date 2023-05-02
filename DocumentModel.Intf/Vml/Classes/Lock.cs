namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Lock Class.
/// </summary>
public class Lock: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Position Lock
  /// </summary>
  public bool? Position { get; set; }

  /// <summary>
  ///   Selection Lock
  /// </summary>
  public bool? Selection { get; set; }

  /// <summary>
  ///   Grouping Lock
  /// </summary>
  public bool? Grouping { get; set; }

  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  public bool? Ungrouping { get; set; }

  /// <summary>
  ///   Rotation Lock
  /// </summary>
  public bool? Rotation { get; set; }

  /// <summary>
  ///   Cropping Lock
  /// </summary>
  public bool? Cropping { get; set; }

  /// <summary>
  ///   Vertices Lock
  /// </summary>
  public bool? Verticies { get; set; }

  /// <summary>
  ///   Handles Lock
  /// </summary>
  public bool? AdjustHandles { get; set; }

  /// <summary>
  ///   Text Lock
  /// </summary>
  public bool? TextLock { get; set; }

  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  public bool? AspectRatio { get; set; }

  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  public bool? ShapeType { get; set; }
}