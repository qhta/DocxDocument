namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FontPitchValues))]
public enum FontPitchKind
{
  /// <summary>
  ///   Fixed Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Fixed))]
  Fixed,
  /// <summary>
  ///   Proportional Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Variable))]
  Variable,
  /// <summary>
  ///   Default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontPitchValues.Default))]
  Default
}