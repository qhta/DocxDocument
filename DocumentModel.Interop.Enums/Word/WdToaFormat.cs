namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of authorities in the active document.
/// </summary>
public enum WdToaFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  wdTOATemplate = unchecked((int)0),
  /// <summary>
  /// Classic formatting.
  /// </summary>
  wdTOAClassic = unchecked((int)1),
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  wdTOADistinctive = unchecked((int)2),
  /// <summary>
  /// Formal formatting.
  /// </summary>
  wdTOAFormal = unchecked((int)3),
  /// <summary>
  /// Simple formatting.
  /// </summary>
  wdTOASimple = unchecked((int)4)
}
