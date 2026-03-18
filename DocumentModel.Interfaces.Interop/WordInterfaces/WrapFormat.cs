namespace DocumentModel.Interop;

/// <summary>
/// Represents all the properties for wrapping text around a shape or shape range.
/// </summary>
public interface WrapFormat : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdWrapType Type { get; set; }
  /// <summary>
  /// The side.
  /// </summary>
  public WdWrapSideType Side { get; set; }
  /// <summary>
  /// The distance top.
  /// </summary>
  public float DistanceTop { get; set; }
  /// <summary>
  /// The distance bottom.
  /// </summary>
  public float DistanceBottom { get; set; }
  /// <summary>
  /// The distance left.
  /// </summary>
  public float DistanceLeft { get; set; }
  /// <summary>
  /// The distance right.
  /// </summary>
  public float DistanceRight { get; set; }
  /// <summary>
  /// The allow overlap.
  /// </summary>
  public int AllowOverlap { get; set; }

}
