namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Axis Position
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AxisPositionKind
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,
  /// <summary>
  ///   Left.
  /// </summary>
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  Right,
  /// <summary>
  ///   Top.
  /// </summary>
  Top
}