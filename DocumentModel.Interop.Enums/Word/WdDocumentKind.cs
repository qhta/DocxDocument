namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format type that Microsoft Word uses when automatically formatting a document.
/// </summary>
public enum WdDocumentKind
{
  /// <summary>
  /// No format specified.
  /// </summary>
  NotSpecified = 0,
  /// <summary>
  /// Letter format.
  /// </summary>
  Letter = 1,
  /// <summary>
  /// E-mail format.
  /// </summary>
  Email = 2
}
