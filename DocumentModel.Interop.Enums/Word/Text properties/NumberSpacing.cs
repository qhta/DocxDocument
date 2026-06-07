namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number spacing setting for an OpenType font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnumberspacing?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdNumberSpacing")]
public enum WdNumberSpacing
{
  /// <summary>
  /// Applies the default number spacing for the font.
  /// </summary>
  [InteropEnumValue("wdNumberSpacingDefault")]
  Default = 0,
  /// <summary>
  /// Applies proportional number spacing to the font.
  /// </summary>
  [InteropEnumValue("wdNumberSpacingProportional")]
  Proportional = 1,
  /// <summary>
  /// Applies tabular number spacing to the font.
  /// </summary>
  [InteropEnumValue("wdNumberSpacingTabular")]
  Tabular = 2
}
