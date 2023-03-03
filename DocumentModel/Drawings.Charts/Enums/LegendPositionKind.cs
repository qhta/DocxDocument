namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Legend Position
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LegendPositionKind
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Top Right.
  /// </summary>
  TopRight,

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