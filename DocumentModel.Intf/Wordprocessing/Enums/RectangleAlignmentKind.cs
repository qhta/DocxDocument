namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RectangleAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RectangleAlignmentKind
{
  /// <summary>
  ///   none.
  /// </summary>
  None,

  /// <summary>
  ///   tl.
  /// </summary>
  TopLeft,

  /// <summary>
  ///   t.
  /// </summary>
  Top,

  /// <summary>
  ///   tr.
  /// </summary>
  TopRight,

  /// <summary>
  ///   l.
  /// </summary>
  Left,

  /// <summary>
  ///   ctr.
  /// </summary>
  Center,

  /// <summary>
  ///   r.
  /// </summary>
  Right,

  /// <summary>
  ///   bl.
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   b.
  /// </summary>
  Bottom,

  /// <summary>
  ///   br.
  /// </summary>
  BottomRight
}