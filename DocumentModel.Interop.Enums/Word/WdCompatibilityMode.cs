namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the compatibility mode that Word 2010 uses when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcompatibilitymode?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCompatibilityMode
{
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  Word2003 = 11,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  Word2007 = 12,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  Word2010 = 14,
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  Word2013 = 15,
  /// <summary>
  /// Compatibility mode equivalent to the latest version of Word.
  /// </summary>
  Current = 65535
}
