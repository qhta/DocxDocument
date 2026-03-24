namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of window.
/// </summary>
public enum WdWindowType
{
  /// <summary>
  /// A document window.
  /// </summary>
  Document = unchecked((int)0),
  /// <summary>
  /// A template window.
  /// </summary>
  Template = unchecked((int)1)
}
