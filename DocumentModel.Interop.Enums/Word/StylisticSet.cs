namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the stylistic set to apply to the font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylisticset?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStylisticSet")]
public enum OtStylisticSet
{
  /// <summary>
  /// Default stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSetDefault")]
  Default = 0,
  /// <summary>
  /// First stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet01")]
  StylisticSet01 = 1,
  /// <summary>
  /// Second stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet02")]
  StylisticSet02 = 2,
  /// <summary>
  /// Third stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet03")]
  StylisticSet03 = 4,
  /// <summary>
  /// Fourth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet04")]
  StylisticSet04 = 8,
  /// <summary>
  /// Fifth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet05")]
  StylisticSet05 = 16,
  /// <summary>
  /// Sixth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet06")]
  StylisticSet06 = 32,
  /// <summary>
  /// Seventh stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet07")]
  StylisticSet07 = 64,
  /// <summary>
  /// Eighth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet08")]
  StylisticSet08 = 128,
  /// <summary>
  /// Ninth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet09")]
  StylisticSet09 = 256,
  /// <summary>
  /// Tenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet10")]
  StylisticSet10 = 512,
  /// <summary>
  /// Eleventh stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet11")]
  StylisticSet11 = 1024,
  /// <summary>
  /// Twelfth stylistic set for the specified font. public enum StylisticSet
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet12")]
  StylisticSet12 = 2048,
  /// <summary>
  /// Thirteenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet13")]
  StylisticSet13 = 4096,
  /// <summary>
  /// Fourtheenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet14")]
  StylisticSet14 = 8192,
  /// <summary>
  /// Fifthteenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet15")]
  StylisticSet15 = 16384,
  /// <summary>
  /// Sixteenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet16")]
  StylisticSet16 = 32768,
  /// <summary>
  /// Seventeenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet17")]
  StylisticSet17 = 65536,
  /// <summary>
  /// Eighteenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet18")]
  StylisticSet18 = 131072,
  /// <summary>
  /// Nineteenth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet19")]
  StylisticSet19 = 262144,
  /// <summary>
  /// Twentieth stylistic set for the specified font.
  /// </summary>
  [WordInteropEnumValue("wdStylisticSet20")]
  StylisticSet20 = 524288
}
