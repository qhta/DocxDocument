namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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