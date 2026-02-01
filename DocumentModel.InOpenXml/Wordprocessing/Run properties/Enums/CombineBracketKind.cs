namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CombineBracketValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.CombineBracketValues))]
public enum CombineBracketKind
{
  /// <summary>
  ///   No Enclosing Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CombineBracketValues.None))]
  None,
  /// <summary>
  ///   Round Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CombineBracketValues.Round))]
  Round,
  /// <summary>
  ///   Square Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CombineBracketValues.Square))]
  Square,
  /// <summary>
  ///   Angle Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CombineBracketValues.Angle))]
  Angle,
  /// <summary>
  ///   Curly Brackets.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CombineBracketValues.Curly))]
  Curly
}