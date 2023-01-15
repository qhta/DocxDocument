namespace DocumentModel.Vml;

/// <summary>
///   Defines the Lock Class.
/// </summary>
public class Lock
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Position Lock
  /// </summary>
  public Boolean? Position { get; set; }

  /// <summary>
  ///   Selection Lock
  /// </summary>
  public Boolean? Selection { get; set; }

  /// <summary>
  ///   Grouping Lock
  /// </summary>
  public Boolean? Grouping { get; set; }

  /// <summary>
  ///   Ungrouping Lock
  /// </summary>
  public Boolean? Ungrouping { get; set; }

  /// <summary>
  ///   Rotation Lock
  /// </summary>
  public Boolean? Rotation { get; set; }

  /// <summary>
  ///   Cropping Lock
  /// </summary>
  public Boolean? Cropping { get; set; }

  /// <summary>
  ///   Vertices Lock
  /// </summary>
  public Boolean? Verticies { get; set; }

  /// <summary>
  ///   Handles Lock
  /// </summary>
  public Boolean? AdjustHandles { get; set; }

  /// <summary>
  ///   Text Lock
  /// </summary>
  public Boolean? TextLock { get; set; }

  /// <summary>
  ///   Aspect Ratio Lock
  /// </summary>
  public Boolean? AspectRatio { get; set; }

  /// <summary>
  ///   AutoShape Type Lock
  /// </summary>
  public Boolean? ShapeType { get; set; }
}