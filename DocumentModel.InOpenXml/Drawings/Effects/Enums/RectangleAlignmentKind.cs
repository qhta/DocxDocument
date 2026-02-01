namespace DocumentModel.Drawings;
/// <summary>
///   Rectangle Alignments
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.RectangleAlignmentValues))]
public enum RectangleAlignmentKind
{
  /// <summary>
  ///   Rectangle Alignment Enum ( Top Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopLeft))]
  TopLeft,
  /// <summary>
  ///   Rectangle Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Rectangle Alignment Enum ( Top Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopRight))]
  TopRight,
  /// <summary>
  ///   Rectangle Alignment Enum ( Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Rectangle Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Rectangle Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   Rectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomRight))]
  BottomRight
}