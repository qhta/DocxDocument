namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of window.
/// </summary>
public enum WdWindowType
{
  /// <summary>
  /// A document window.
  /// </summary>
  wdWindowDocument = unchecked((int)0),
  /// <summary>
  /// A template window.
  /// </summary>
  wdWindowTemplate = unchecked((int)1)
}
