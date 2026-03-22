namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the compatibility mode that Word 2010 uses when opening a document.
/// </summary>
public enum WdCompatibilityMode
{
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  wdWord2003 = unchecked((int)11),
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  wdWord2007 = unchecked((int)12),
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  wdWord2010 = unchecked((int)14),
  /// <summary>
  /// Specifies the compatibility mode that Word 2010 uses when opening a document.
  /// </summary>
  wdWord2013 = unchecked((int)15),
  /// <summary>
  /// Compatibility mode equivalent to the latest version of Word.
  /// </summary>
  wdCurrent = unchecked((int)65535)
}
