namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontPitchValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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