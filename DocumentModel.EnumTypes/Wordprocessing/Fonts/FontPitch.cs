namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FontPitchValues))]
public enum FontPitch
{
  /// <summary>
  ///   Default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Default))]
  Default = 0,
  /// <summary>
  ///   Fixed Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Fixed))]
  Fixed = 1,
  /// <summary>
  ///   Proportional Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Variable))]
  Variable = 2,

}