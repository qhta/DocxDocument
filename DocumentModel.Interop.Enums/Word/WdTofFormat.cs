namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
public enum WdTofFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  wdTOFTemplate = unchecked((int)0),
  /// <summary>
  /// Classic formatting.
  /// </summary>
  wdTOFClassic = unchecked((int)1),
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  wdTOFDistinctive = unchecked((int)2),
  /// <summary>
  /// Centered formatting.
  /// </summary>
  wdTOFCentered = unchecked((int)3),
  /// <summary>
  /// Formal formatting.
  /// </summary>
  wdTOFFormal = unchecked((int)4),
  /// <summary>
  /// Simple formatting.
  /// </summary>
  wdTOFSimple = unchecked((int)5)
}
