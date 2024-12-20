namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExpandValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ExpandKind
{
  /// <summary>
  ///   topLeft.
  /// </summary>
  TopLeft,

  /// <summary>
  ///   top.
  /// </summary>
  Top,

  /// <summary>
  ///   topRight.
  /// </summary>
  TopRight,

  /// <summary>
  ///   left.
  /// </summary>
  Left,

  /// <summary>
  ///   center.
  /// </summary>
  Center,

  /// <summary>
  ///   right.
  /// </summary>
  Right,

  /// <summary>
  ///   bottomLeft.
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   bottomRight.
  /// </summary>
  BottomRight
}