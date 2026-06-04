namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CombineBracketValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues))]
public enum CombineBracket
{
  /// <summary>
  ///   No Enclosing Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues.None))]
  None,
  /// <summary>
  ///   Round Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues.Round))]
  Round,
  /// <summary>
  ///   Square Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues.Square))]
  Square,
  /// <summary>
  ///   Angle Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues.Angle))]
  Angle,
  /// <summary>
  ///   Curly Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues.Curly))]
  Curly
}