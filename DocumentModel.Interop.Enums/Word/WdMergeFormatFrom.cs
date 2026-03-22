namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document from which to retain formatting during a document compare function.
/// </summary>
public enum WdMergeFormatFrom
{
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  wdMergeFormatFromOriginal = unchecked((int)0),
  /// <summary>
  /// Retains formatting from the revised document. wdMergeFormatFromPrompt2 Prompt the user for the document to use
  /// for formatting.
  /// </summary>
  wdMergeFormatFromRevised = unchecked((int)1),
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  wdMergeFormatFromPrompt = unchecked((int)2)
}
