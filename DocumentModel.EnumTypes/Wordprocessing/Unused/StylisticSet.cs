namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the S enumeration.
/// Used in types such as Font, _Font.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum S
{

  /// <summary>
  /// Default stylistic set for the specified font.
  /// </summary>
  Default = 0,
  /// <summary>
  /// First stylistic set for the specified font.
  /// </summary>
  S01 = 1,
  /// <summary>
  /// Second stylistic set for the specified font.
  /// </summary>
  S02 = 2,
  /// <summary>
  /// Third stylistic set for the specified font.
  /// </summary>
  S03 = 4,
  /// <summary>
  /// Fourth stylistic set for the specified font.
  /// </summary>
  S04 = 8,
  /// <summary>
  /// Fifth stylistic set for the specified font.
  /// </summary>
  S05 = 16,
  /// <summary>
  /// Sixth stylistic set for the specified font.
  /// </summary>
  S06 = 32,
  /// <summary>
  /// Seventh stylistic set for the specified font.
  /// </summary>
  S07 = 64,
  /// <summary>
  /// Eighth stylistic set for the specified font.
  /// </summary>
  S08 = 128,
  /// <summary>
  /// Ninth stylistic set for the specified font.
  /// </summary>
  S09 = 256,
  /// <summary>
  /// Tenth stylistic set for the specified font.
  /// </summary>
  S10 = 512,
  /// <summary>
  /// Eleventh stylistic set for the specified font.
  /// </summary>
  S11 = 1024,
  /// <summary>
  /// Twelfth stylistic set for the specified font.
  /// </summary>
  S12 = 2048,
  /// <summary>
  /// Thirteenth stylistic set for the specified font.
  /// </summary>
  S13 = 4096,
  /// <summary>
  /// Fourtheenth stylistic set for the specified font.
  /// </summary>
  S14 = 8192,
  /// <summary>
  /// Fifthteenth stylistic set for the specified font.
  /// </summary>
  S15 = 16384,
  /// <summary>
  /// Sixteenth stylistic set for the specified font.
  /// </summary>
  S16 = 32768,
  /// <summary>
  /// Seventeenth stylistic set for the specified font.
  /// </summary>
  S17 = 65536,
  /// <summary>
  /// Eighteenth stylistic set for the specified font.
  /// </summary>
  S18 = 131072,
  /// <summary>
  /// Nineteenth stylistic set for the specified font.
  /// </summary>
  S19 = 262144,
  /// <summary>
  /// Twentieth stylistic set for the specified font.
  /// </summary>
  S20 = 524288
}
