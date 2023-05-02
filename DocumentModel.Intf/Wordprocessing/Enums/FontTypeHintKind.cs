namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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