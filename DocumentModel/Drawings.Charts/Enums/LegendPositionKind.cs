namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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