namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextDirectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextDirectionKind
{
  /// <summary>
  ///   Left to Right, Top to Bottom.
  /// </summary>
  LefToRightTopToBottom,

  /// <summary>
  ///   tb.
  /// </summary>
  LeftToRightTopToBottom2010,

  /// <summary>
  ///   Top to Bottom, Right to Left.
  /// </summary>
  TopToBottomRightToLeft,

  /// <summary>
  ///   rl.
  /// </summary>
  TopToBottomRightToLeft2010,

  /// <summary>
  ///   Bottom to Top, Left to Right.
  /// </summary>
  BottomToTopLeftToRight,

  /// <summary>
  ///   lr.
  /// </summary>
  BottomToTopLeftToRight2010,

  /// <summary>
  ///   Left to Right, Top to Bottom Rotated.
  /// </summary>
  LefttoRightTopToBottomRotated,

  /// <summary>
  ///   tbV.
  /// </summary>
  LeftToRightTopToBottomRotated2010,

  /// <summary>
  ///   Top to Bottom, Right to Left Rotated.
  /// </summary>
  TopToBottomRightToLeftRotated,

  /// <summary>
  ///   rlV.
  /// </summary>
  TopToBottomRightToLeftRotated2010,

  /// <summary>
  ///   Top to Bottom, Left to Right Rotated.
  /// </summary>
  TopToBottomLeftToRightRotated,

  /// <summary>
  ///   lrV.
  /// </summary>
  TopToBottomLeftToRightRotated2010
}