namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies wrap behavior if a selection or range is specified for a find operation and the search text isn't
/// found in the selection or range.
/// </summary>
public enum WdFindWrap
{
  /// <summary>
  /// The find operation ends if the beginning or end of the search range is reached. wdFindContinue1 The find
  /// operation continues if the beginning or end of the search range is reached.
  /// </summary>
  Stop = unchecked((int)0),
  /// <summary>
  /// Specifies wrap behavior if a selection or range is specified for a find operation and the search text isn't
  /// found in the selection or range.
  /// </summary>
  Continue = unchecked((int)1),
  /// <summary>
  /// After searching the selection or range, Microsoft Word displays a message asking whether to search the
  /// remainder of the document.
  /// </summary>
  Ask = unchecked((int)2)
}
