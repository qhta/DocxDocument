namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextEffectValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextEffectKind
{
  /// <summary>
  ///   Blinking Background Animation.
  /// </summary>
  BlinkBackground,

  /// <summary>
  ///   Colored Lights Animation.
  /// </summary>
  Lights,

  /// <summary>
  ///   Black Dashed Line Animation.
  /// </summary>
  AntsBlack,

  /// <summary>
  ///   Marching Red Ants.
  /// </summary>
  AntsRed,

  /// <summary>
  ///   Shimmer Animation.
  /// </summary>
  Shimmer,

  /// <summary>
  ///   Sparkling Lights Animation.
  /// </summary>
  Sparkle,

  /// <summary>
  ///   No Animation.
  /// </summary>
  None
}