namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting for indexes in a document.
/// </summary>
public enum WdIndexFormat
{
  /// <summary>
  /// From template.
  /// </summary>
  wdIndexTemplate = unchecked((int)0),
  /// <summary>
  /// Classic.
  /// </summary>
  wdIndexClassic = unchecked((int)1),
  /// <summary>
  /// Fancy.
  /// </summary>
  wdIndexFancy = unchecked((int)2),
  /// <summary>
  /// Modern.
  /// </summary>
  wdIndexModern = unchecked((int)3),
  /// <summary>
  /// Bulleted.
  /// </summary>
  wdIndexBulleted = unchecked((int)4),
  /// <summary>
  /// Formal.
  /// </summary>
  wdIndexFormal = unchecked((int)5),
  /// <summary>
  /// Simple.
  /// </summary>
  wdIndexSimple = unchecked((int)6)
}
