namespace DocumentModel.Drawings;
/// <summary>
///   IRectangle Alignments
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues))]
public enum RectangleAlignment
{
  /// <summary>
  ///   IRectangle Alignment Enum ( Top Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.TopLeft))]
  TopLeft,
  /// <summary>
  ///   IRectangle Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   IRectangle Alignment Enum ( Top Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.TopRight))]
  TopRight,
  /// <summary>
  ///   IRectangle Alignment Enum ( Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   IRectangle Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   IRectangle Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.BottomLeft))]
  BottomLeft,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  ///   IRectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues.BottomRight))]
  BottomRight
}
