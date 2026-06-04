namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the AbsolutePositionTabPositioningBaseValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues))]
public enum AbsolutePositionTabPositioningBase
{
  /// <summary>
  ///   Relative To Text Margins.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues.Margin))]
  Margin,
  /// <summary>
  ///   Relative To Indents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues.Indent))]
  Indent
}