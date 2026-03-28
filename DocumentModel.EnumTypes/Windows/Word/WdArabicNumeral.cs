namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the numeral style for an Arabic-language document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdarabicnumeral?view=office-pia` for Office interop details.
/// </remarks>
public enum WdArabicNumeral
{
  /// <summary>
  /// Arabic shape is used for numerals.
  /// </summary>
  Arabic = 0,
  /// <summary>
  /// Hindi shape is used for numerals.
  /// </summary>
  Hindi = 1,
  /// <summary>
  /// Numeral shape depends on text surrounding it.
  /// </summary>
  Context = 2,
  /// <summary>
  /// Numeral shape is determined by system settings.
  /// </summary>
  System = 3
}
