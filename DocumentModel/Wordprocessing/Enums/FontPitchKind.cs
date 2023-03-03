namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontPitchKind
{
  /// <summary>
  ///   Fixed Width.
  /// </summary>
  Fixed,

  /// <summary>
  ///   Proportional Width.
  /// </summary>
  Variable,

  /// <summary>
  ///   Default.
  /// </summary>
  Default
}