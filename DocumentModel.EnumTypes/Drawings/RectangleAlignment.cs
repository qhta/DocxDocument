namespace DocumentModel.Drawings;
/// <summary>
///   IRectangle Alignments
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.RectangleAlignmentValues))]
public enum RectangleAlignment
{
  /// <summary>
  ///   IRectangle Alignment Enum ( Top Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopLeft))]
  TopLeft,
  /// <summary>
  ///   IRectangle Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   IRectangle Alignment Enum ( Top Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.TopRight))]
  TopRight,
  /// <summary>
  ///   IRectangle Alignment Enum ( Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   IRectangle Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   IRectangle Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.RectangleAlignmentValues.BottomRight))]
  BottomRight
}
