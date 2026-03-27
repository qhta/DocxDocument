namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the text direction options for content in a WordprocessingML document.
/// This enumeration provides values for various writing directions and orientations, supporting complex scripts, vertical and horizontal layouts, and compatibility with different Word versions and platforms.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TextDirectionValues))]
public enum TextDirection
{
  /// <summary>
  /// Left to Right, Top to Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.LefToRightTopToBottom))]
  [Obsolete]
  LefToRightTopToBottom = 1,

  /// <summary>
  /// Left to Right, Top to Bottom (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.LeftToRightTopToBottom2010))]
  TopToBottom,

  /// <summary>
  /// Top to Bottom, Right to Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomRightToLeft))]
  [Obsolete]
  TopToBottomRightToLeft,

  /// <summary>
  /// Top to Bottom, Right to Left (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomRightToLeft2010))]
  RightToLeft,

  /// <summary>
  /// Bottom to Top, Left to Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.BottomToTopLeftToRight))]
  [Obsolete]
  BottomToTopLeftToRight,

  /// <summary>
  /// Bottom to Top, Left to Right (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.BottomToTopLeftToRight2010))]
  LeftToRight,

  /// <summary>
  /// Left to Right, Top to Bottom Rotated.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.LefttoRightTopToBottomRotated))]
  [Obsolete]
  LeftToRightTopToBottomRotated,

  /// <summary>
  /// Left to Right, Top to Bottom Rotated (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.LeftToRightTopToBottomRotated2010))]
  TopToBottomVertical,

  /// <summary>
  /// Top to Bottom, Right to Left Rotated.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomRightToLeftRotated))]
  [Obsolete]
  TopToBottomRightToLeftRotated,

  /// <summary>
  /// Top to Bottom, Right to Left Rotated (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomRightToLeftRotated2010))]
  RightToLeftVertical,

  /// <summary>
  /// Top to Bottom, Left to Right Rotated.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomLeftToRightRotated))]
  [Obsolete]
  TopToBottomLeftToRightRotated,

  /// <summary>
  /// Top to Bottom, Left to Right Rotated (2010 compatibility).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextDirectionValues.TopToBottomLeftToRightRotated2010))]
  LeftToRightVertical
}