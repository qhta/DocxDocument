namespace DocumentModel.Math;
/// <summary>
///   Defines the BreakBinarySubtractionValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues))]
public enum BreakBinarySubtraction
{
  /// <summary>
  ///   Minus is left on the end of the line and repeated on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues.MinusMinus))]
  MinusMinus,
  /// <summary>
  ///   Minus is left on the end of the line and plus is placed on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues.MinusPlus))]
  MinusPlus,
  /// <summary>
  ///   Plus is left on the end of the line and minus is placed on the beginning of the next line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues.PlusMinus))]
  PlusMinus
}