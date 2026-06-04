namespace DocumentModel.Drawings;
/// <summary>
///   Text Alignment Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues))]
public enum TextAlignment
{
  /// <summary>
  ///   Text Alignment Enum ( Left ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Text Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Text Alignment Enum ( Right ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Text Alignment Enum ( Justified ).
  /// </summary>
  Justified,
  /// <summary>
  ///   Text Alignment Enum ( Justified Low ).
  /// </summary>
  JustifiedLow,
  /// <summary>
  ///   Text Alignment Enum ( Distributed ).
  /// </summary>
  Distributed,
  /// <summary>
  ///   Text Alignment Enum ( Thai Distributed ).
  /// </summary>
  ThaiDistributed
}