namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number form setting for an OpenType font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumberform?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdNumberForm")]
public enum OtNumberForm
{
  /// <summary>
  /// Applies the default number form for the font.
  /// </summary>
  [WordInteropEnumValue("wdNumberFormDefault")]
  Default = 0,
  /// <summary>
  /// Applies the lining number form to the font.
  /// </summary>
  [WordInteropEnumValue("wdNumberFormLining")]
  Lining = 1,
  /// <summary>
  /// Applies the "old-style" number form to the font.
  /// </summary>
  [WordInteropEnumValue("wdNumberFormOldStyle")]
  OldStyle = 2
}
