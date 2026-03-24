namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document format. This enumeration is commonly used when saving a document.
/// </summary>
public enum WdOriginalFormat
{
  /// <summary>
  /// Microsoft Word document format.
  /// </summary>
  WordDocument = unchecked((int)0),
  /// <summary>
  /// Original document format.
  /// </summary>
  OriginalDocumentFormat = unchecked((int)1),
  /// <summary>
  /// Prompt user to select a document format.
  /// </summary>
  PromptUser = unchecked((int)2)
}
