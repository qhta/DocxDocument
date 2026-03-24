namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revision marks are displayed in the document.
/// </summary>
public enum WdRevisionsWrap
{
  /// <summary>
  /// Never wrap revisions.
  /// </summary>
  Never = unchecked((int)0),
  /// <summary>
  /// Revisions are wrapped.
  /// </summary>
  Always = unchecked((int)1),
  /// <summary>
  /// Ask the user if revisions should be wrapped.
  /// </summary>
  Ask = unchecked((int)2)
}
