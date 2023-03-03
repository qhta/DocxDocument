namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontTypeHintValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontTypeHintKind
{
  /// <summary>
  ///   High ANSI Font.
  /// </summary>
  Default,

  /// <summary>
  ///   East Asian Font.
  /// </summary>
  EastAsia,

  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  ComplexScript
}