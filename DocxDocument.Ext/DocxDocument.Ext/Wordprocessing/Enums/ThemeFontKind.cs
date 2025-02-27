namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ThemeFontValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum ThemeFontKind
{
  /// <summary>
  ///   Major East Asian Theme Font.
  /// </summary>
  MajorEastAsia,

  /// <summary>
  ///   Major Complex Script Theme Font.
  /// </summary>
  MajorBidi,

  /// <summary>
  ///   Major ASCII Theme Font.
  /// </summary>
  MajorAscii,

  /// <summary>
  ///   Major High ANSI Theme Font.
  /// </summary>
  MajorHighAnsi,

  /// <summary>
  ///   Minor East Asian Theme Font.
  /// </summary>
  MinorEastAsia,

  /// <summary>
  ///   Minor Complex Script Theme Font.
  /// </summary>
  MinorBidi,

  /// <summary>
  ///   Minor ASCII Theme Font.
  /// </summary>
  MinorAscii,

  /// <summary>
  ///   Minor High ANSI Theme Font.
  /// </summary>
  MinorHighAnsi
}