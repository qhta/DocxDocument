namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues))]
public enum VerticalPosition
{
  /// <summary>
  ///   Regular Vertical Positioning.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues.Baseline))]
  Baseline,
  /// <summary>
  ///   Superscript.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues.Superscript))]
  Superscript,
  /// <summary>
  ///   Subscript.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues.Subscript))]
  Subscript
}