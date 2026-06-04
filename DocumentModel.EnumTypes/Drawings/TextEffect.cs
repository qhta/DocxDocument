namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextEffectValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues))]
public enum TextEffect
{
  /// <summary>
  ///   Blinking Background Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.BlinkBackground))]
  BlinkBackground = 1,

  /// <summary>
  ///   Colored Lights Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.Lights))]
  Lights,
  /// <summary>
  ///   Black Dashed ILine Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.AntsBlack))]
  AntsBlack,
  /// <summary>
  ///   Marching Red Ants.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.AntsRed))]
  AntsRed,
  /// <summary>
  ///   Shimmer Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.Shimmer))]
  Shimmer,
  /// <summary>
  ///   Sparkling Lights Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.Sparkle))]
  Sparkle,
  /// <summary>
  ///   No Animation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextEffectValues.None))]
  None
}
