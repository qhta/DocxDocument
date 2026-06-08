namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ThemeFontValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ThemeFontKind
{
  /// <summary>
  ///   Major East Asian Theme IFont.
  /// </summary>
  MajorEastAsia,

  /// <summary>
  ///   Major Complex Script Theme IFont.
  /// </summary>
  MajorBidi,

  /// <summary>
  ///   Major ASCII Theme IFont.
  /// </summary>
  MajorAscii,

  /// <summary>
  ///   Major High ANSI Theme IFont.
  /// </summary>
  MajorHighAnsi,

  /// <summary>
  ///   Minor East Asian Theme IFont.
  /// </summary>
  MinorEastAsia,

  /// <summary>
  ///   Minor Complex Script Theme IFont.
  /// </summary>
  MinorBidi,

  /// <summary>
  ///   Minor ASCII Theme IFont.
  /// </summary>
  MinorAscii,

  /// <summary>
  ///   Minor High ANSI Theme IFont.
  /// </summary>
  MinorHighAnsi
}
