namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of contents in the active document.
/// </summary>
public enum WdTocFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  wdTOCTemplate = unchecked((int)0),
  /// <summary>
  /// Classic formatting.
  /// </summary>
  wdTOCClassic = unchecked((int)1),
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  wdTOCDistinctive = unchecked((int)2),
  /// <summary>
  /// Fancy formatting.
  /// </summary>
  wdTOCFancy = unchecked((int)3),
  /// <summary>
  /// Modern formatting.
  /// </summary>
  wdTOCModern = unchecked((int)4),
  /// <summary>
  /// Formal formatting.
  /// </summary>
  wdTOCFormal = unchecked((int)5),
  /// <summary>
  /// Simple formatting.
  /// </summary>
  wdTOCSimple = unchecked((int)6)
}
