namespace DocumentModel.Drawings;
/// <summary>
///   Text Tab Alignment Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues))]
public enum TextTabAlignment
{
  /// <summary>
  ///   Text Tab Alignment Enum ( Left).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues.Left))]
  Left = 1,

  /// <summary>
  ///   Text Tab Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Text Tab Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Text Tab Alignment Enum ( Decimal ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues.Decimal))]
  Decimal
}