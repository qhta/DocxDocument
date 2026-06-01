namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the FontTypeHintValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontTypeHintKind
{
  /// <summary>
  ///   High ANSI IFont.
  /// </summary>
  Default,

  /// <summary>
  ///   East Asian IFont.
  /// </summary>
  EastAsia,

  /// <summary>
  ///   Complex Script IFont.
  /// </summary>
  ComplexScript
}
