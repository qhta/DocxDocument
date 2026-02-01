namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the text direction options for content in a WordprocessingML document.
/// This enumeration provides values for various writing directions and orientations, supporting complex scripts, vertical and horizontal layouts, and compatibility with different Word versions and platforms.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.TextDirectionValues))]
public enum TextDirectionKind
{
  /// <summary>
  /// Left to Right, Top to Bottom.
  /// </summary>
  LefToRightTopToBottom,
  /// <summary>
  /// Left to Right, Top to Bottom (2010 compatibility).
  /// </summary>
  LeftToRightTopToBottom2010,
  /// <summary>
  /// Top to Bottom, Right to Left.
  /// </summary>
  TopToBottomRightToLeft,
  /// <summary>
  /// Top to Bottom, Right to Left (2010 compatibility).
  /// </summary>
  TopToBottomRightToLeft2010,
  /// <summary>
  /// Bottom to Top, Left to Right.
  /// </summary>
  BottomToTopLeftToRight,
  /// <summary>
  /// Bottom to Top, Left to Right (2010 compatibility).
  /// </summary>
  BottomToTopLeftToRight2010,
  /// <summary>
  /// Left to Right, Top to Bottom Rotated.
  /// </summary>
  LeftToRightTopToBottomRotated,
  /// <summary>
  /// Left to Right, Top to Bottom Rotated (2010 compatibility).
  /// </summary>
  LeftToRightTopToBottomRotated2010,
  /// <summary>
  /// Top to Bottom, Right to Left Rotated.
  /// </summary>
  TopToBottomRightToLeftRotated,
  /// <summary>
  /// Top to Bottom, Right to Left Rotated (2010 compatibility).
  /// </summary>
  TopToBottomRightToLeftRotated2010,
  /// <summary>
  /// Top to Bottom, Left to Right Rotated.
  /// </summary>
  TopToBottomLeftToRightRotated,
  /// <summary>
  /// Top to Bottom, Left to Right Rotated (2010 compatibility).
  /// </summary>
  TopToBottomLeftToRightRotated2010
}