namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document from which to retain formatting during a document compare function.
/// </summary>
public enum WdMergeFormatFrom
{
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  Original = unchecked((int)0),
  /// <summary>
  /// Retains formatting from the revised document. wdMergeFormatFromPrompt2 Prompt the user for the document to use
  /// for formatting.
  /// </summary>
  Revised = unchecked((int)1),
  /// <summary>
  /// Specifies the document from which to retain formatting during a document compare function.
  /// </summary>
  Prompt = unchecked((int)2)
}
