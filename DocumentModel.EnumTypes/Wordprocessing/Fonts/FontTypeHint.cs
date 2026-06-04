namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontTypeHintValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues))]
public enum FontTypeHint
{
  /// <summary>
  ///   High ANSI Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues.Default))]
  Default,
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues.EastAsia))]
  EastAsia,
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues.ComplexScript))]
  ComplexScript
}