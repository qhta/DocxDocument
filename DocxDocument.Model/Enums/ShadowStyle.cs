namespace DocxDocument.Model;

/// <summary>
/// Specifies the type of shadowing effect.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ShadowStyle
{
  /// <summary>
  /// Specifies a combination of  inner and outer shadow effects.
  /// </summary>
  Mixed = -2, // 0xFFFFFFFE
  /// <summary>
  /// Specifies the inner shadow effect.
  /// </summary>
  InnerShadow = 1,
  /// <summary>
  /// Specifies the outer shadow effect.
  /// </summary>
  OuterShadow = 2,
}