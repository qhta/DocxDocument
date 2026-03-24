namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a source to copy formatting from.
/// </summary>
public enum WdUseFormattingFrom
{
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Current = unchecked((int)0),
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Selected = unchecked((int)1),
  /// <summary>
  /// Specifies a source to copy formatting from.
  /// </summary>
  Prompt = unchecked((int)2)
}
