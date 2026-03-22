namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the criteria by which Word sorts the specified index.
/// </summary>
public enum WdIndexSortBy
{
  /// <summary>
  /// Sort by the number of strokes in a character.
  /// </summary>
  wdIndexSortByStroke = unchecked((int)0),
  /// <summary>
  /// Sort phonetically.
  /// </summary>
  wdIndexSortBySyllable = unchecked((int)1)
}
