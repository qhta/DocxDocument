namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the NumberSpacingValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues))]
public enum NumberSpacing
{
  /// <summary>
  ///   default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues.Default))]
  Default,
  /// <summary>
  ///   proportional.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues.Proportional))]
  Proportional,
  /// <summary>
  ///   tabular.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues.Tabular))]
  Tabular
}