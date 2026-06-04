namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.FontPitchValues))]
public enum FontPitch
{
  /// <summary>
  ///   Default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontPitchValues.Default))]
  Default = 0,
  /// <summary>
  ///   Fixed Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontPitchValues.Fixed))]
  Fixed = 1,
  /// <summary>
  ///   Proportional Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.FontPitchValues.Variable))]
  Variable = 2,

}