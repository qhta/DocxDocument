namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextDirectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextDirectionKind
{
  /// <summary>
  ///   Left Ito Right, Top Ito Bottom.
  /// </summary>
  LefToRightTopToBottom,

  /// <summary>
  ///   tb.
  /// </summary>
  LeftToRightTopToBottom2010,

  /// <summary>
  ///   Top Ito Bottom, Right Ito Left.
  /// </summary>
  TopToBottomRightToLeft,

  /// <summary>
  ///   rl.
  /// </summary>
  TopToBottomRightToLeft2010,

  /// <summary>
  ///   Bottom Ito Top, Left Ito Right.
  /// </summary>
  BottomToTopLeftToRight,

  /// <summary>
  ///   lr.
  /// </summary>
  BottomToTopLeftToRight2010,

  /// <summary>
  ///   Left Ito Right, Top Ito Bottom Rotated.
  /// </summary>
  LefttoRightTopToBottomRotated,

  /// <summary>
  ///   tbV.
  /// </summary>
  LeftToRightTopToBottomRotated2010,

  /// <summary>
  ///   Top Ito Bottom, Right Ito Left Rotated.
  /// </summary>
  TopToBottomRightToLeftRotated,

  /// <summary>
  ///   rlV.
  /// </summary>
  TopToBottomRightToLeftRotated2010,

  /// <summary>
  ///   Top Ito Bottom, Left Ito Right Rotated.
  /// </summary>
  TopToBottomLeftToRightRotated,

  /// <summary>
  ///   lrV.
  /// </summary>
  TopToBottomLeftToRightRotated2010
}
