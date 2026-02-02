namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FontTypeHintValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FontTypeHintValues))]
public enum FontTypeHint
{
  /// <summary>
  ///   High ANSI Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontTypeHintValues.Default))]
  Default,
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontTypeHintValues.EastAsia))]
  EastAsia,
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FontTypeHintValues.ComplexScript))]
  ComplexScript
}