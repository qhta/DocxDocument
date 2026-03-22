namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a source to copy formatting from.
/// </summary>
public enum WdUseFormattingFrom
{
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  wdFormattingFromCurrent = unchecked((int)0),
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  wdFormattingFromSelected = unchecked((int)1),
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  wdFormattingFromPrompt = unchecked((int)2)
}
