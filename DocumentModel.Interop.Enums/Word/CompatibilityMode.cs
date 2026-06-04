namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the compatibility mode that Word 2010 uses when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibilitymode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCompatibilityMode))]
public enum CompatibilityMode
{
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibilityMode.wdWord2003))]
  Word2003 = 11,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibilityMode.wdWord2007))]
  Word2007 = 12,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibilityMode.wdWord2010))]
  Word2010 = 14,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibilityMode.wdWord2013))]
  Word2013 = 15,
  /// <summary>
  /// Compatibility mode equivalent to the latest version of Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCompatibilityMode.wdCurrent))]
  Current = 65535
}
