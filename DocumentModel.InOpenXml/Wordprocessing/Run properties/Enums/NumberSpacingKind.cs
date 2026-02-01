namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10W.NumberSpacingValues))]
public enum NumberSpacingKind
{
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberSpacingValues.Default))]
  Default,
  /// <summary>
  ///   proportional.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberSpacingValues.Proportional))]
  Proportional,
  /// <summary>
  ///   tabular.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.NumberSpacingValues.Tabular))]
  Tabular
}