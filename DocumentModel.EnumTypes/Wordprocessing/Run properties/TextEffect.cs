namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextEffectValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TextEffectValues))]
public enum TextEffect
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Blinking Background Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.BlinkBackground))]
  BlinkBackground = 1,

  /// <summary>
  ///   Colored Lights Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.Lights))]
  Lights,
  /// <summary>
  ///   Black Dashed Line Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.AntsBlack))]
  AntsBlack,
  /// <summary>
  ///   Marching Red Ants.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.AntsRed))]
  AntsRed,
  /// <summary>
  ///   Shimmer Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.Shimmer))]
  Shimmer,
  /// <summary>
  ///   Sparkling Lights Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.Sparkle))]
  Sparkle,
  /// <summary>
  ///   No Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextEffectValues.None))]
  None
}