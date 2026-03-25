namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies rectangle alignment options for positioning and layout in WordprocessingML drawings.
/// This enumeration provides values for various alignment positions, supporting precise control over the placement of rectangles and graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.RectangleAlignmentValues))]
public enum RectangleAlignment
{
  /// <summary>
  /// No alignment specified.
  /// </summary>
  None,
  /// <summary>
  /// Top left alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopLeft))]
  TopLeft,
  /// <summary>
  /// Top alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Top))]
  Top,
  /// <summary>
  /// Top right alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopRight))]
  TopRight,
  /// <summary>
  /// Left alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Left))]
  Left,
  /// <summary>
  /// Center alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Center))]
  Center,
  /// <summary>
  /// Right alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Right))]
  Right,
  /// <summary>
  /// Bottom left alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  /// Bottom alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  /// Bottom right alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomRight))]
  BottomRight
}